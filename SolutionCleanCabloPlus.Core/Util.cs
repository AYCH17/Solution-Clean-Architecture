using System;
using System.Collections.Generic;
using System.Data;
using SolutionCleanCabloPlus.Core;

//Steve Gagné 2007-11-01

//Cette classe contient des procédures et fonctions qui peuvent être utilisées n'importe où.
//Le seul but de cette classe est de centraliser et d'économiser le code.
public static class Util
{

    #region Conversion

    public static int StringToInt(string psString)
    {
        if (isNULL(psString))
            return int.MinValue;
        if (psString.Length == 0)
            return int.MinValue;
        try
        {
            int liTemp = int.Parse(psString);

            return liTemp;
        }
        catch
        {
            return int.MinValue;
        }
    }
    
    #endregion
    
    #region TraitementChaine
    
    public static string RemoveDoubleSpaces(string psString)
    {
        string lsTemp = "";

        psString = psString.Trim();
        while (lsTemp != psString)
        {
            lsTemp = psString;
            psString = psString.Replace("  ", " ");
        }
        return psString;
    }
    
    public static string FillLenghtString(string psStringToBeFilled, int piLenght, bool pbFromStart, char pcFillingChar)
    {
        int liLenght = psStringToBeFilled.Length;

        while (piLenght > liLenght)
        {
            if (pbFromStart)
                psStringToBeFilled = pcFillingChar + psStringToBeFilled;
            else
                psStringToBeFilled += pcFillingChar;
            liLenght += 1;
        }
        return psStringToBeFilled;
    }
    
    public static string ZeroFill(int piNumber, int piQtyOfZero)
    {
        return ZeroFill(piNumber.ToString(), piQtyOfZero);
    }
    
    public static string ZeroFill(string psToBeFilled, int piQtyOfZero)
    {
        if (isNULL(psToBeFilled))
            return null;
        while (psToBeFilled.Length < piQtyOfZero)
            psToBeFilled = "0" + psToBeFilled;
        return psToBeFilled;
    }
    
    #endregion
    
    #region Validation

    public static bool isNULL(object pNullableObj)
    {
        return (pNullableObj == null);
    }

    public static bool isValidGuid(string psGuid)
    {
        if (isNULL(psGuid))
            return false;
        if (psGuid == "")
            return false;
        try
        {
            Guid lGuid = new Guid(psGuid);
            return true;
        }
        catch
        {
            return false;
        }
    }
   
    public static bool isCharAlphaNum(char pcChar)
    {
        if (isNULL(pcChar))
            return false;

        int liChar = Convert.ToInt32(pcChar);

        //48..57        = 0..9
        //65..90        = A..Z
        //97..122       = a..z
        //128..154      = ÇüéâäàåçêëèïîìÄÅÉæÆôöòûùÿÖÜ
        //160..165      = áíóúñÑ
        //181..183      = ÁÂÀ
        //198           = ã
        //199           = Ã
        //210..212      = ÊËÈ
        //214..216      = ÍÎÏ
        //222           = Ì
        //224           = Ó
        //226..229      = ÔÒõÕ
        //233..237      = ÚÛÙýÝ
        return ((liChar >= 48 && liChar <= 57) || (liChar >= 65 && liChar <= 90) || (liChar >= 97 && liChar <= 122) ||
                (liChar >= 128 && liChar <= 154) || (liChar >= 160 && liChar <= 165) || (liChar >= 181 && liChar <= 183) ||
                (liChar == 198) || (liChar == 199) || (liChar >= 210 && liChar <= 212) ||
                (liChar >= 214 && liChar <= 216) || (liChar == 222) || (liChar == 224) ||
                (liChar >= 226 && liChar <= 229) || (liChar >= 233 && liChar <= 237));
    }

    #endregion
/**
    #region FormatTables
    
    public static DataTable TransactionsTable(List<Transaction> transactions)
    {
        var dd = new List<string>
        {
            "EstPayée"
        };

        var doubles = new List<string>
        {
            "Volume", "PrixUnitaire", "MontantTotal", "MontantTaxe"
        };
        var dt = new DataTable();
        foreach (var t in transactions)
        {
            var r = dt.NewRow();
            foreach (var f in t.GetType().GetProperties())
            {
                if (!dt.Columns.Contains(f.Name) && !dd.Contains(f.Name))
                {
                    dt.Columns.Add(f.Name);
                }

                if (!dd.Contains(f.Name))
                {
                    r[f.Name] = f.GetValue(t);
                }

                if (doubles.Contains(f.Name))
                {
                    r[f.Name] = f.GetValue(t);
                }
            }
            dt.Rows.Add(r);
        }
        return dt;
    }
    public static DataTable TransactionsTableForRapportTransactions(List<Transaction> transactions)
    {
        var dt = new DataTable();
        foreach (var t in transactions)
        {
            var r = dt.NewRow();
            foreach (var f in t.GetType().GetProperties())
            {
                if (!dt.Columns.Contains(f.Name) && !f.Name.Contains("Client") && !f.Name.Contains("Paiements") && !f.Name.Contains("Pompe"))
                {
                    dt.Columns.Add(f.Name);
                }

                if (!f.Name.Contains("Client") && !f.Name.Contains("Paiements") && !f.Name.Contains("Pompe"))
                    r[f.Name] = f.GetValue(t);
            }
            if (!dt.Columns.Contains("MontantTotal")) dt.Columns.Add("MontantTotal");
            r["MontantTotal"] = t.MontantTotal(); 
            dt.Rows.Add(r);
        }
         return dt;
    }

    public static DataTable PaiementsTableForRapportTransactions(List<Paiement> paiements)
    {
        var dt = new DataTable();
        foreach (var p in paiements)
        {
            var r = dt.NewRow();
            foreach (var f in p.GetType().GetProperties())
            {
                if (!dt.Columns.Contains(f.Name) && !f.Name.Contains("Transaction"))
                {
                    dt.Columns.Add(f.Name);
                }

                if (!f.Name.Contains("Transaction"))
                    r[f.Name] = f.GetValue(p);
            }
            if (!dt.Columns.Contains("TypePaiement")) dt.Columns.Add("TypePaiement");
            if (p is PaiementEspèce) r["TypePaiement"] = "PaiementEspèce";
            else if (p is PaiementCarteCrédit) r["TypePaiement"] = "PaiementCarteCrédit";
                    else if (p is PaiementEnCompte) r["TypePaiement"] = "PaiementEnCompte";
            dt.Rows.Add(r);
        }
        return dt;
    }

    public static DataTable ComptesTable(List<Compte> comptes)
    {
        var dt = new DataTable();
        foreach (var o in comptes)
        {
            var r = dt.NewRow();
            foreach (var f in o.GetType().GetProperties())
            {
                if (!dt.Columns.Contains(f.Name) && (!f.Name.Contains("Client") || f.Name.Equals("ClientId")))
                {
                    dt.Columns.Add(f.Name);
                }

                if (!f.Name.Contains("Client") || f.Name.Equals("ClientId"))
                {
                    r[f.Name] = f.GetValue(o);
                }

            }
            dt.Rows.Add(r);
        }
        return dt;
    }
    #endregion
**/
}