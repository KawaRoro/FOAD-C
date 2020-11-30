using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CL_Check
{
    public static class Check
    {
        private const string regexName = @"^[A-Za-z]+$";
        //private const string regexDate = @"^((((0[13578])|([13578])|(1[02]))[\/](([1-9])|([0-2][0-9])|(3[01])))|(((0[469])|([469])|(11))[\/](([1-9])|([0-2][0-9])|(30)))|((2|02)[\/](([1-9])|([0-2][0-9]))))[\/]\d{4}$|^\d{4}$"; //https://webdevdesigner.com/q/regex-to-validate-date-format-dd-mm-yyyy-duplicate-55660/
        private const string regexAmount = @"^([0-9.,]*)$"; //@"^[+] ? ([0 - 9] + ([.,][0 - 9] *) ?|[.,][0 - 9] +)$"; //@"^[1-9]*[0-9]*$"; // [+] ?
        private const string regexZipCode = @"^(?:[0-8]\d|9[0-8])\d{3}$";
        private const string regexNumber = @"^([0-9]*)$";

        public static bool CheckLengthEmpty(string _valeur)
        {
            if (_valeur.Trim().Length == 0)
            {
                return false;
            }
            return true;
        }

        public static bool CheckLengthMinTextBox(string _valeur, int _nbChar)
        {
            if (_valeur.Trim().Length >= _nbChar)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// textBox "CheckLengthMaxTextBox" check Maximum value of text boxes
        public static bool CheckLengthMaxTextBox(string _valeur, int _nbChar)
        {
            if (_valeur.Trim().Length <= _nbChar)
            {
                return false;
            }
            return true;
        }

        public static string CheckName(string _valeur)
        {
            if (!CheckLengthEmpty(_valeur))
            {
                return $@"Le champ est obligatoire.";
            }
            else if (CheckLengthMaxTextBox(_valeur, 30)) // CheckLengthMinTextBox(tbName, 2) || 
            {
                return $@"Le champ nécessite moins de trente caractères.";
            }
            else if (!Regex.IsMatch(_valeur, regexName))
            {
                return $@"Le champ est incorrect.";
            }
            return "";
        }

        public static string CheckDate(string _valeur)
        {
            if (!CheckLengthEmpty(_valeur))
            {
                return $@"Le champ est obligatoire.";
            }
            if (CheckLengthMinTextBox(_valeur, 10) && CheckLengthMaxTextBox(_valeur, 10))
            {
                return $@"Le champ nécessite dix caractères.";
            }

            /*if (!Regex.IsMatch(_valeur, regexDate))
            {
                //_errorProvider.SetError(_date, "Seul les dates à la française sont acceptées.");
                //_date.Focus();
                return "Seul les dates à la française sont acceptées.";
            }*/

            DateTime d = DateTime.MinValue;
            CultureInfo myCIintl = new CultureInfo("fr-FR", false);

            if (!DateTime.TryParseExact(_valeur, "dd/MM/yyyy", myCIintl, DateTimeStyles.None, out d))
            {
                return "La date doit être valide.";
            }
            else if (!(d >= DateTime.Today))
            {
                return "La date doit être à venir.";
            }

            return "";

        }

        public static string CheckAmount(string _valeur)
        {
            if (!CheckLengthEmpty(_valeur))
            {
                return $@"Le champ est obligatoire.";
            }
            if (CheckLengthMinTextBox(_valeur, 1))
            {
                return $@"Le champ nécessite au moins un caractère.";
            }

            if (!Regex.IsMatch(_valeur, regexAmount))
            {
                return "Le montant doit être un nombre valide. V1";
            }

            _valeur = _valeur.Replace('.', ',');
            _valeur = _valeur.Replace('+', ' ');

            if (!(double.TryParse(_valeur, out double number) && number >= 0))
            {
                return "Le montant doit être un nombre valide. V2";
            }
            return "";
        }

        public static string CheckZipCode(string _valeur)
        {
            if (!CheckLengthEmpty(_valeur))
            {
                return $@"Le champ est obligatoire.";
            }
            if (CheckLengthMinTextBox(_valeur, 2))
            {
                return $@"Le champ nécessite au moins deux caractères.";
            }
            if (!Regex.IsMatch(_valeur, regexZipCode))
            {
                return "Le Zip Code doit être un nombre à cinq chiffres valides.";
            }
            if (!(int.TryParse(_valeur, out int result)))
            {
                return "Le Zip Code doit être un nombre à cinq chiffres valides.";
            }

            return "";
        }

        public static string CheckNumber(string _valeur)
        {
            if (!CheckLengthEmpty(_valeur))
            {
                return $@"Le champ est vide.";
            }
            if (CheckLengthMinTextBox(_valeur, 1))
            {
                return $@"Le champ nécessite au moins deux caractères.";
            }
            if (!Regex.IsMatch(_valeur, regexNumber))
            {
                return "Le nombre doit être un nombre à un ou plusieurs chiffres valides.";
            }
            if (!(int.TryParse(_valeur, out int result)))
            {
                return "Le champ doit contenir un nombre à chiffre(s) valide(s).";
            }

            return "";
        }
    }
}
