//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class empresas
    {
        public int Id_Empresa { get; set; }
        public string Nombre_Empresa { get; set; }
        public Nullable<int> Porcentaje_Iva_Anterior { get; set; }
        public Nullable<int> Porcentaje_iva { get; set; }
        public string Periodo { get; set; }
        public Nullable<int> Lmodifica_Precios { get; set; }
        public Nullable<int> Sig_Orden_Servicio { get; set; }
        public Nullable<decimal> Porcentaje_Utilidad { get; set; }
        public Nullable<System.DateTime> apartirde { get; set; }
        public string Id_Bodega_Facturacion { get; set; }
        public string Id_Cuenta_Cxp { get; set; }
        public int Lmodifica_Costos { get; set; }
        public int total_detalle_lineas { get; set; }
        public string id_cuenta_efectivo { get; set; }
        public string id_cuenta_banco { get; set; }
        public string id_cuenta_credito { get; set; }
        public string id_cuenta_anticipo { get; set; }
        public string id_cuenta_debito { get; set; }
        public string id_cuenta_debito_fiscal { get; set; }
        public string direccion { get; set; }
        public string telefonos { get; set; }
        public string fax { get; set; }
        public string email { get; set; }
        public int Id_contrasena { get; set; }
        public string Id_cuenta_anticipo_proveedores { get; set; }
        public string Id_cuenta_cxc { get; set; }
        public string Id_cuenta_vtas { get; set; }
        public string Id_depto_vtas { get; set; }
        public string id_cuenta_dep_transito_cxc { get; set; }
        public int Sig_numero_presupuesto { get; set; }
        public Nullable<int> Porcentaje_utilidad_sobre { get; set; }
        public string Factura_con { get; set; }
        public string Nombre_comercial { get; set; }
        public string Id_cuenta_rebaja_sventa { get; set; }
        public int Usa_orden_despacho { get; set; }
        public string Opera_con_moneda { get; set; }
        public Nullable<decimal> Tasa_cambio { get; set; }
        public Nullable<int> Ingresa_fecha_al_facturar { get; set; }
        public Nullable<int> Facturacion_multibodega { get; set; }
        public string Id_cuenta_Retencion_iva_clientes { get; set; }
        public Nullable<int> Factura_en_base_aplantillas { get; set; }
        public Nullable<int> Utiliza_correlativo_contraseñas_pago { get; set; }
        public string directorio_logo { get; set; }
        public Nullable<int> Permite_existencia_negativa { get; set; }
        public string Id_propina { get; set; }
        public Nullable<int> Tipo_Orden_a_actualizar { get; set; }
        public Nullable<int> Orden_Envio_Pos_Factura { get; set; }
        public string Mascara_Cantidad { get; set; }
        public Nullable<int> Agente_Retenedor_IVA { get; set; }
        public string Regimen_Fiscal_isr { get; set; }
        public string Id_Cuenta_Retencion_ISR_Clientes { get; set; }
        public Nullable<int> Tipo_Cola_Ordenes { get; set; }
        public Nullable<int> Tipo_Correl_Orden { get; set; }
        public bool ImprimeCopia { get; set; }
        public int CorrelativoComanda { get; set; }
        public Nullable<System.DateTime> FechaSistema { get; set; }
        public string Afiliacion_iva { get; set; }
        public string Codigo_Postal { get; set; }
        public string Correo { get; set; }
        public string Departamento { get; set; }
        public string FE_Token { get; set; }
        public Nullable<System.DateTime> Fecha_Hora_Expira_Token { get; set; }
        public string Municipio { get; set; }
        public string NIT { get; set; }
        public string Nombre { get; set; }
        public string Numero_Establecimiento { get; set; }
        public string Pais { get; set; }
        public bool UsaFel { get; set; }
        public int id_tbl_certificador { get; set; }
        public bool Es_Armeria { get; set; }
        public Nullable<int> Dias_Credito_Cliente { get; set; }
    }
}
