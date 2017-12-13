//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FcsClassLibrary {
  using System;
  using Devart.Data.Oracle;
  
  
  public class FCS_GET_VOLCSGRS : Devart.Data.Oracle.OraclePackage {
    
    public FCS_GET_VOLCSGRS() {
      base.PackageName = "FCS_BIOSUM.FCS_GET_VOLCSGRS";
    }
    
    [System.ComponentModel.ReadOnlyAttribute(true)]
    public new string PackageName {
      get {
        return base.PackageName;
      }
    }
    
    public System.Nullable<decimal> FIA_VOLCSGRS(
          string CONFIGID, 
          System.Nullable<decimal> SPN, 
          System.Nullable<decimal> DBH, 
          System.Nullable<decimal> HT, 
          System.Nullable<decimal> SAWHT, 
          System.Nullable<decimal> BOLEHT, 
          System.Nullable<decimal> STEMS, 
          System.Nullable<decimal> STAND_SI, 
          System.Nullable<decimal> STAND_BA, 
          System.Nullable<decimal> QUAL, 
          System.Nullable<decimal> HT_BREAK, 
          System.Nullable<decimal> DIA_UPPER, 
          System.Nullable<decimal> HT_UPPER, 
          System.Nullable<decimal> DIA_CENTROID, 
          System.Nullable<decimal> HT_CENTROID, 
          System.Nullable<decimal> HT_DBH, 
          System.Nullable<decimal> STATUSCD, 
          System.Nullable<decimal> TREECLCD) {
      OracleParameterCollection parameters;
      parameters = this.Parameters;
      parameters.Clear();
      OracleParameter parameter;
      parameter = new OracleParameter("RESULT", Devart.Data.Oracle.OracleDbType.Number);
      parameter.Direction = System.Data.ParameterDirection.ReturnValue;
      parameters.Add(parameter);
      parameter = new OracleParameter("CONFIGID", Devart.Data.Oracle.OracleDbType.VarChar);
      parameter.Direction = System.Data.ParameterDirection.Input;
      parameter.Value = CONFIGID;
      parameters.Add(parameter);
      parameter = new OracleParameter("SPN", Devart.Data.Oracle.OracleDbType.Number);
      parameter.Direction = System.Data.ParameterDirection.Input;
      if (SPN.HasValue) {
        parameter.Value = SPN;
      }
      else {
        parameter.Value = System.DBNull.Value;
      }
      parameter.Direction = System.Data.ParameterDirection.Input;
      parameters.Add(parameter);
      parameter = new OracleParameter("DBH", Devart.Data.Oracle.OracleDbType.Number);
      parameter.Direction = System.Data.ParameterDirection.Input;
      if (DBH.HasValue) {
        parameter.Value = DBH;
      }
      else {
        parameter.Value = System.DBNull.Value;
      }
      parameter.Direction = System.Data.ParameterDirection.Input;
      parameters.Add(parameter);
      parameter = new OracleParameter("HT", Devart.Data.Oracle.OracleDbType.Number);
      parameter.Direction = System.Data.ParameterDirection.Input;
      if (HT.HasValue) {
        parameter.Value = HT;
      }
      else {
        parameter.Value = System.DBNull.Value;
      }
      parameter.Direction = System.Data.ParameterDirection.Input;
      parameters.Add(parameter);
      parameter = new OracleParameter("SAWHT", Devart.Data.Oracle.OracleDbType.Number);
      parameter.Direction = System.Data.ParameterDirection.Input;
      if (SAWHT.HasValue) {
        parameter.Value = SAWHT;
      }
      else {
        parameter.Value = System.DBNull.Value;
      }
      parameter.Direction = System.Data.ParameterDirection.Input;
      parameters.Add(parameter);
      parameter = new OracleParameter("BOLEHT", Devart.Data.Oracle.OracleDbType.Number);
      parameter.Direction = System.Data.ParameterDirection.Input;
      if (BOLEHT.HasValue) {
        parameter.Value = BOLEHT;
      }
      else {
        parameter.Value = System.DBNull.Value;
      }
      parameter.Direction = System.Data.ParameterDirection.Input;
      parameters.Add(parameter);
      parameter = new OracleParameter("STEMS", Devart.Data.Oracle.OracleDbType.Number);
      parameter.Direction = System.Data.ParameterDirection.Input;
      if (STEMS.HasValue) {
        parameter.Value = STEMS;
      }
      else {
        parameter.Value = System.DBNull.Value;
      }
      parameter.Direction = System.Data.ParameterDirection.Input;
      parameters.Add(parameter);
      parameter = new OracleParameter("STAND_SI", Devart.Data.Oracle.OracleDbType.Number);
      parameter.Direction = System.Data.ParameterDirection.Input;
      if (STAND_SI.HasValue) {
        parameter.Value = STAND_SI;
      }
      else {
        parameter.Value = System.DBNull.Value;
      }
      parameter.Direction = System.Data.ParameterDirection.Input;
      parameters.Add(parameter);
      parameter = new OracleParameter("STAND_BA", Devart.Data.Oracle.OracleDbType.Number);
      parameter.Direction = System.Data.ParameterDirection.Input;
      if (STAND_BA.HasValue) {
        parameter.Value = STAND_BA;
      }
      else {
        parameter.Value = System.DBNull.Value;
      }
      parameter.Direction = System.Data.ParameterDirection.Input;
      parameters.Add(parameter);
      parameter = new OracleParameter("QUAL", Devart.Data.Oracle.OracleDbType.Number);
      parameter.Direction = System.Data.ParameterDirection.Input;
      if (QUAL.HasValue) {
        parameter.Value = QUAL;
      }
      else {
        parameter.Value = System.DBNull.Value;
      }
      parameter.Direction = System.Data.ParameterDirection.Input;
      parameters.Add(parameter);
      parameter = new OracleParameter("HT_BREAK", Devart.Data.Oracle.OracleDbType.Number);
      parameter.Direction = System.Data.ParameterDirection.Input;
      if (HT_BREAK.HasValue) {
        parameter.Value = HT_BREAK;
      }
      else {
        parameter.Value = System.DBNull.Value;
      }
      parameter.Direction = System.Data.ParameterDirection.Input;
      parameters.Add(parameter);
      parameter = new OracleParameter("DIA_UPPER", Devart.Data.Oracle.OracleDbType.Number);
      parameter.Direction = System.Data.ParameterDirection.Input;
      if (DIA_UPPER.HasValue) {
        parameter.Value = DIA_UPPER;
      }
      else {
        parameter.Value = System.DBNull.Value;
      }
      parameter.Direction = System.Data.ParameterDirection.Input;
      parameters.Add(parameter);
      parameter = new OracleParameter("HT_UPPER", Devart.Data.Oracle.OracleDbType.Number);
      parameter.Direction = System.Data.ParameterDirection.Input;
      if (HT_UPPER.HasValue) {
        parameter.Value = HT_UPPER;
      }
      else {
        parameter.Value = System.DBNull.Value;
      }
      parameter.Direction = System.Data.ParameterDirection.Input;
      parameters.Add(parameter);
      parameter = new OracleParameter("DIA_CENTROID", Devart.Data.Oracle.OracleDbType.Number);
      parameter.Direction = System.Data.ParameterDirection.Input;
      if (DIA_CENTROID.HasValue) {
        parameter.Value = DIA_CENTROID;
      }
      else {
        parameter.Value = System.DBNull.Value;
      }
      parameter.Direction = System.Data.ParameterDirection.Input;
      parameters.Add(parameter);
      parameter = new OracleParameter("HT_CENTROID", Devart.Data.Oracle.OracleDbType.Number);
      parameter.Direction = System.Data.ParameterDirection.Input;
      if (HT_CENTROID.HasValue) {
        parameter.Value = HT_CENTROID;
      }
      else {
        parameter.Value = System.DBNull.Value;
      }
      parameter.Direction = System.Data.ParameterDirection.Input;
      parameters.Add(parameter);
      parameter = new OracleParameter("HT_DBH", Devart.Data.Oracle.OracleDbType.Number);
      parameter.Direction = System.Data.ParameterDirection.Input;
      if (HT_DBH.HasValue) {
        parameter.Value = HT_DBH;
      }
      else {
        parameter.Value = System.DBNull.Value;
      }
      parameter.Direction = System.Data.ParameterDirection.Input;
      parameters.Add(parameter);
      parameter = new OracleParameter("STATUSCD", Devart.Data.Oracle.OracleDbType.Number);
      parameter.Direction = System.Data.ParameterDirection.Input;
      if (STATUSCD.HasValue) {
        parameter.Value = STATUSCD;
      }
      else {
        parameter.Value = System.DBNull.Value;
      }
      parameter.Direction = System.Data.ParameterDirection.Input;
      parameters.Add(parameter);
      parameter = new OracleParameter("TREECLCD", Devart.Data.Oracle.OracleDbType.Number);
      parameter.Direction = System.Data.ParameterDirection.Input;
      if (TREECLCD.HasValue) {
        parameter.Value = TREECLCD;
      }
      else {
        parameter.Value = System.DBNull.Value;
      }
      parameter.Direction = System.Data.ParameterDirection.Input;
      parameters.Add(parameter);
      ExecuteProcedure("FIA_VOLCSGRS", parameters);
      if ((Parameters["Result"].Value == System.DBNull.Value)) {
        return null;
      }
      else {
        return ((System.Nullable<decimal>)(Parameters["Result"].Value));
      }
    }
    
    public string GET_VALUE_CHAR(string CONFIGID, System.Nullable<decimal> SPN, string PAR) {
      OracleParameterCollection parameters;
      parameters = this.Parameters;
      parameters.Clear();
      OracleParameter parameter;
      parameter = new OracleParameter("RESULT", Devart.Data.Oracle.OracleDbType.VarChar);
      parameter.Direction = System.Data.ParameterDirection.ReturnValue;
      parameters.Add(parameter);
      parameter = new OracleParameter("CONFIGID", Devart.Data.Oracle.OracleDbType.VarChar);
      parameter.Direction = System.Data.ParameterDirection.Input;
      parameter.Value = CONFIGID;
      parameters.Add(parameter);
      parameter = new OracleParameter("SPN", Devart.Data.Oracle.OracleDbType.Number);
      parameter.Direction = System.Data.ParameterDirection.Input;
      if (SPN.HasValue) {
        parameter.Value = SPN;
      }
      else {
        parameter.Value = System.DBNull.Value;
      }
      parameter.Direction = System.Data.ParameterDirection.Input;
      parameters.Add(parameter);
      parameter = new OracleParameter("PAR", Devart.Data.Oracle.OracleDbType.VarChar);
      parameter.Direction = System.Data.ParameterDirection.Input;
      parameter.Value = PAR;
      parameters.Add(parameter);
      ExecuteProcedure("GET_VALUE_CHAR", parameters);
      if ((Parameters["Result"].Value == System.DBNull.Value)) {
        return "";
      }
      else {
        return ((string)(Parameters["Result"].Value));
      }
    }
    
    public System.Nullable<decimal> GET_VALUE_NUM(string CONFIGID, System.Nullable<decimal> SPN, string PAR) {
      OracleParameterCollection parameters;
      parameters = this.Parameters;
      parameters.Clear();
      OracleParameter parameter;
      parameter = new OracleParameter("RESULT", Devart.Data.Oracle.OracleDbType.Number);
      parameter.Direction = System.Data.ParameterDirection.ReturnValue;
      parameters.Add(parameter);
      parameter = new OracleParameter("CONFIGID", Devart.Data.Oracle.OracleDbType.VarChar);
      parameter.Direction = System.Data.ParameterDirection.Input;
      parameter.Value = CONFIGID;
      parameters.Add(parameter);
      parameter = new OracleParameter("SPN", Devart.Data.Oracle.OracleDbType.Number);
      parameter.Direction = System.Data.ParameterDirection.Input;
      if (SPN.HasValue) {
        parameter.Value = SPN;
      }
      else {
        parameter.Value = System.DBNull.Value;
      }
      parameter.Direction = System.Data.ParameterDirection.Input;
      parameters.Add(parameter);
      parameter = new OracleParameter("PAR", Devart.Data.Oracle.OracleDbType.VarChar);
      parameter.Direction = System.Data.ParameterDirection.Input;
      parameter.Value = PAR;
      parameters.Add(parameter);
      ExecuteProcedure("GET_VALUE_NUM", parameters);
      if ((Parameters["Result"].Value == System.DBNull.Value)) {
        return null;
      }
      else {
        return ((System.Nullable<decimal>)(Parameters["Result"].Value));
      }
    }
    
    public System.Nullable<decimal> GET_VOLCSGRS(
          string CONFIGID, 
          System.Nullable<decimal> SPN, 
          System.Nullable<decimal> DBH, 
          System.Nullable<decimal> HT, 
          System.Nullable<decimal> SAWHT, 
          System.Nullable<decimal> BOLEHT, 
          System.Nullable<decimal> STEMS, 
          System.Nullable<decimal> STAND_SI, 
          System.Nullable<decimal> STAND_BA, 
          System.Nullable<decimal> QUAL, 
          System.Nullable<decimal> HT_BREAK, 
          System.Nullable<decimal> DIA_UPPER, 
          System.Nullable<decimal> HT_UPPER, 
          System.Nullable<decimal> DIA_CENTROID, 
          System.Nullable<decimal> HT_CENTROID, 
          System.Nullable<decimal> HT_DBH) {
      OracleParameterCollection parameters;
      parameters = this.Parameters;
      parameters.Clear();
      OracleParameter parameter;
      parameter = new OracleParameter("RESULT", Devart.Data.Oracle.OracleDbType.Number);
      parameter.Direction = System.Data.ParameterDirection.ReturnValue;
      parameters.Add(parameter);
      parameter = new OracleParameter("CONFIGID", Devart.Data.Oracle.OracleDbType.VarChar);
      parameter.Direction = System.Data.ParameterDirection.Input;
      parameter.Value = CONFIGID;
      parameters.Add(parameter);
      parameter = new OracleParameter("SPN", Devart.Data.Oracle.OracleDbType.Number);
      parameter.Direction = System.Data.ParameterDirection.Input;
      if (SPN.HasValue) {
        parameter.Value = SPN;
      }
      else {
        parameter.Value = System.DBNull.Value;
      }
      parameter.Direction = System.Data.ParameterDirection.Input;
      parameters.Add(parameter);
      parameter = new OracleParameter("DBH", Devart.Data.Oracle.OracleDbType.Number);
      parameter.Direction = System.Data.ParameterDirection.Input;
      if (DBH.HasValue) {
        parameter.Value = DBH;
      }
      else {
        parameter.Value = System.DBNull.Value;
      }
      parameter.Direction = System.Data.ParameterDirection.Input;
      parameters.Add(parameter);
      parameter = new OracleParameter("HT", Devart.Data.Oracle.OracleDbType.Number);
      parameter.Direction = System.Data.ParameterDirection.Input;
      if (HT.HasValue) {
        parameter.Value = HT;
      }
      else {
        parameter.Value = System.DBNull.Value;
      }
      parameter.Direction = System.Data.ParameterDirection.Input;
      parameters.Add(parameter);
      parameter = new OracleParameter("SAWHT", Devart.Data.Oracle.OracleDbType.Number);
      parameter.Direction = System.Data.ParameterDirection.Input;
      if (SAWHT.HasValue) {
        parameter.Value = SAWHT;
      }
      else {
        parameter.Value = System.DBNull.Value;
      }
      parameter.Direction = System.Data.ParameterDirection.Input;
      parameters.Add(parameter);
      parameter = new OracleParameter("BOLEHT", Devart.Data.Oracle.OracleDbType.Number);
      parameter.Direction = System.Data.ParameterDirection.Input;
      if (BOLEHT.HasValue) {
        parameter.Value = BOLEHT;
      }
      else {
        parameter.Value = System.DBNull.Value;
      }
      parameter.Direction = System.Data.ParameterDirection.Input;
      parameters.Add(parameter);
      parameter = new OracleParameter("STEMS", Devart.Data.Oracle.OracleDbType.Number);
      parameter.Direction = System.Data.ParameterDirection.Input;
      if (STEMS.HasValue) {
        parameter.Value = STEMS;
      }
      else {
        parameter.Value = System.DBNull.Value;
      }
      parameter.Direction = System.Data.ParameterDirection.Input;
      parameters.Add(parameter);
      parameter = new OracleParameter("STAND_SI", Devart.Data.Oracle.OracleDbType.Number);
      parameter.Direction = System.Data.ParameterDirection.Input;
      if (STAND_SI.HasValue) {
        parameter.Value = STAND_SI;
      }
      else {
        parameter.Value = System.DBNull.Value;
      }
      parameter.Direction = System.Data.ParameterDirection.Input;
      parameters.Add(parameter);
      parameter = new OracleParameter("STAND_BA", Devart.Data.Oracle.OracleDbType.Number);
      parameter.Direction = System.Data.ParameterDirection.Input;
      if (STAND_BA.HasValue) {
        parameter.Value = STAND_BA;
      }
      else {
        parameter.Value = System.DBNull.Value;
      }
      parameter.Direction = System.Data.ParameterDirection.Input;
      parameters.Add(parameter);
      parameter = new OracleParameter("QUAL", Devart.Data.Oracle.OracleDbType.Number);
      parameter.Direction = System.Data.ParameterDirection.Input;
      if (QUAL.HasValue) {
        parameter.Value = QUAL;
      }
      else {
        parameter.Value = System.DBNull.Value;
      }
      parameter.Direction = System.Data.ParameterDirection.Input;
      parameters.Add(parameter);
      parameter = new OracleParameter("HT_BREAK", Devart.Data.Oracle.OracleDbType.Number);
      parameter.Direction = System.Data.ParameterDirection.Input;
      if (HT_BREAK.HasValue) {
        parameter.Value = HT_BREAK;
      }
      else {
        parameter.Value = System.DBNull.Value;
      }
      parameter.Direction = System.Data.ParameterDirection.Input;
      parameters.Add(parameter);
      parameter = new OracleParameter("DIA_UPPER", Devart.Data.Oracle.OracleDbType.Number);
      parameter.Direction = System.Data.ParameterDirection.Input;
      if (DIA_UPPER.HasValue) {
        parameter.Value = DIA_UPPER;
      }
      else {
        parameter.Value = System.DBNull.Value;
      }
      parameter.Direction = System.Data.ParameterDirection.Input;
      parameters.Add(parameter);
      parameter = new OracleParameter("HT_UPPER", Devart.Data.Oracle.OracleDbType.Number);
      parameter.Direction = System.Data.ParameterDirection.Input;
      if (HT_UPPER.HasValue) {
        parameter.Value = HT_UPPER;
      }
      else {
        parameter.Value = System.DBNull.Value;
      }
      parameter.Direction = System.Data.ParameterDirection.Input;
      parameters.Add(parameter);
      parameter = new OracleParameter("DIA_CENTROID", Devart.Data.Oracle.OracleDbType.Number);
      parameter.Direction = System.Data.ParameterDirection.Input;
      if (DIA_CENTROID.HasValue) {
        parameter.Value = DIA_CENTROID;
      }
      else {
        parameter.Value = System.DBNull.Value;
      }
      parameter.Direction = System.Data.ParameterDirection.Input;
      parameters.Add(parameter);
      parameter = new OracleParameter("HT_CENTROID", Devart.Data.Oracle.OracleDbType.Number);
      parameter.Direction = System.Data.ParameterDirection.Input;
      if (HT_CENTROID.HasValue) {
        parameter.Value = HT_CENTROID;
      }
      else {
        parameter.Value = System.DBNull.Value;
      }
      parameter.Direction = System.Data.ParameterDirection.Input;
      parameters.Add(parameter);
      parameter = new OracleParameter("HT_DBH", Devart.Data.Oracle.OracleDbType.Number);
      parameter.Direction = System.Data.ParameterDirection.Input;
      if (HT_DBH.HasValue) {
        parameter.Value = HT_DBH;
      }
      else {
        parameter.Value = System.DBNull.Value;
      }
      parameter.Direction = System.Data.ParameterDirection.Input;
      parameters.Add(parameter);
      ExecuteProcedure("GET_VOLCSGRS", parameters);
      if ((Parameters["Result"].Value == System.DBNull.Value)) {
        return null;
      }
      else {
        return ((System.Nullable<decimal>)(Parameters["Result"].Value));
      }
    }
    
    public void LOAD_LOC_CONFIG(string CONFIGID) {
      OracleParameterCollection parameters;
      parameters = this.Parameters;
      parameters.Clear();
      OracleParameter parameter;
      parameter = new OracleParameter("CONFIGID", Devart.Data.Oracle.OracleDbType.VarChar);
      parameter.Direction = System.Data.ParameterDirection.Input;
      parameter.Value = CONFIGID;
      parameters.Add(parameter);
      ExecuteProcedure("LOAD_LOC_CONFIG", parameters);
    }
  }
}
