﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BackEnd3.AccesoDatos
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="bdForo")]
	public partial class conexionLinqDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    #endregion
		
		public conexionLinqDataContext() : 
				base(global::clase4.Properties.Settings.Default.bdForoConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public conexionLinqDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public conexionLinqDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public conexionLinqDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public conexionLinqDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_INGRESAR_USUARIO")]
		public int SP_INGRESAR_USUARIO([global::System.Data.Linq.Mapping.ParameterAttribute(Name="NOMBRE", DbType="NVarChar(50)")] string nOMBRE, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="APELLIDOS", DbType="NVarChar(50)")] string aPELLIDOS, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="CORREO_ELECTRONICO", DbType="NVarChar(MAX)")] string cORREO_ELECTRONICO, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PASSWORD", DbType="NVarChar(MAX)")] string pASSWORD, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NUMEROVERIFICACION", DbType="NVarChar(MAX)")] string nUMEROVERIFICACION, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDRETURN", DbType="Int")] ref System.Nullable<int> iDRETURN, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORID", DbType="Int")] ref System.Nullable<int> eRRORID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORDESCRIPCION", DbType="NVarChar(MAX)")] ref string eRRORDESCRIPCION)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nOMBRE, aPELLIDOS, cORREO_ELECTRONICO, pASSWORD, nUMEROVERIFICACION, iDRETURN, eRRORID, eRRORDESCRIPCION);
			iDRETURN = ((System.Nullable<int>)(result.GetParameterValue(5)));
			eRRORID = ((System.Nullable<int>)(result.GetParameterValue(6)));
			eRRORDESCRIPCION = ((string)(result.GetParameterValue(7)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_Login")]
		public int sp_Login([global::System.Data.Linq.Mapping.ParameterAttribute(Name="CORREO_ELECTRONICO", DbType="NVarChar(50)")] string cORREO_ELECTRONICO, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PASSWORD", DbType="NVarChar(MAX)")] string pASSWORD, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] ref System.Nullable<int> id_usuario, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] ref System.Nullable<int> estado, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] ref string nombre, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] ref string apellidos)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), cORREO_ELECTRONICO, pASSWORD, id_usuario, estado, nombre, apellidos);
			id_usuario = ((System.Nullable<int>)(result.GetParameterValue(2)));
			estado = ((System.Nullable<int>)(result.GetParameterValue(3)));
			nombre = ((string)(result.GetParameterValue(4)));
			apellidos = ((string)(result.GetParameterValue(5)));
			return ((int)(result.ReturnValue));
		}
	}
}
#pragma warning restore 1591