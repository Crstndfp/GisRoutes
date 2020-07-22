using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Models.ModelsWms3
{
    public partial class WMS3Context : DbContext
    {
        public WMS3Context()
        {
        }

        public WMS3Context(DbContextOptions<WMS3Context> options)
            : base(options)
        {
        }

        public virtual DbSet<ArchDetFactura> ArchDetFactura { get; set; }
        public virtual DbSet<ArchDetFacturaAnulada> ArchDetFacturaAnulada { get; set; }
        public virtual DbSet<ArchDetMovBodega> ArchDetMovBodega { get; set; }
        public virtual DbSet<ArchDetNotaCred> ArchDetNotaCred { get; set; }
        public virtual DbSet<ArchDetNotaCredAnulada> ArchDetNotaCredAnulada { get; set; }
        public virtual DbSet<ArchDetOla> ArchDetOla { get; set; }
        public virtual DbSet<ArchDetPedido> ArchDetPedido { get; set; }
        public virtual DbSet<Calendarioretail> Calendarioretail { get; set; }
        public virtual DbSet<CompExistencia> CompExistencia { get; set; }
        public virtual DbSet<CrgArticulo> CrgArticulo { get; set; }
        public virtual DbSet<CrgArticulo1> CrgArticulo1 { get; set; }
        public virtual DbSet<CrgArticuloConsignado> CrgArticuloConsignado { get; set; }
        public virtual DbSet<CrgArticuloDef> CrgArticuloDef { get; set; }
        public virtual DbSet<CrgArticuloGrupo> CrgArticuloGrupo { get; set; }
        public virtual DbSet<CrgBarras> CrgBarras { get; set; }
        public virtual DbSet<CrgBarras1> CrgBarras1 { get; set; }
        public virtual DbSet<CrgDetFactura> CrgDetFactura { get; set; }
        public virtual DbSet<CrgDetFacturaAnulada> CrgDetFacturaAnulada { get; set; }
        public virtual DbSet<CrgDetListaPrecios> CrgDetListaPrecios { get; set; }
        public virtual DbSet<CrgDetListaPrecios1> CrgDetListaPrecios1 { get; set; }
        public virtual DbSet<CrgDetListaPreciosDev> CrgDetListaPreciosDev { get; set; }
        public virtual DbSet<CrgDetListaPreciosEspecial> CrgDetListaPreciosEspecial { get; set; }
        public virtual DbSet<CrgDetMovBodega> CrgDetMovBodega { get; set; }
        public virtual DbSet<CrgDetNotaCred> CrgDetNotaCred { get; set; }
        public virtual DbSet<CrgDetNotaCredAnulada> CrgDetNotaCredAnulada { get; set; }
        public virtual DbSet<CrgDirSocioNeg> CrgDirSocioNeg { get; set; }
        public virtual DbSet<CrgGrupoArticulo> CrgGrupoArticulo { get; set; }
        public virtual DbSet<CrgGrupoArticulo1> CrgGrupoArticulo1 { get; set; }
        public virtual DbSet<CrgListaPrecios> CrgListaPrecios { get; set; }
        public virtual DbSet<CrgSocioNeg> CrgSocioNeg { get; set; }
        public virtual DbSet<CrgUbicacion> CrgUbicacion { get; set; }
        public virtual DbSet<ProductosBronto> ProductosBronto { get; set; }
        public virtual DbSet<SboOitw> SboOitw { get; set; }
        public virtual DbSet<Sr3Eina> Sr3Eina { get; set; }
        public virtual DbSet<Sr3Lagp> Sr3Lagp { get; set; }
        public virtual DbSet<Sr3Lfa1> Sr3Lfa1 { get; set; }
        public virtual DbSet<Sr3Lqua> Sr3Lqua { get; set; }
        public virtual DbSet<Sr3Marm> Sr3Marm { get; set; }
        public virtual DbSet<TblAccionPedido> TblAccionPedido { get; set; }
        public virtual DbSet<TblAnalisisPedido> TblAnalisisPedido { get; set; }
        public virtual DbSet<TblAnulacionDoc> TblAnulacionDoc { get; set; }
        public virtual DbSet<TblAplicacion> TblAplicacion { get; set; }
        public virtual DbSet<TblAreaDistCentro> TblAreaDistCentro { get; set; }
        public virtual DbSet<TblArticulo> TblArticulo { get; set; }
        public virtual DbSet<TblArticulo1> TblArticulo1 { get; set; }
        public virtual DbSet<TblArticuloAct> TblArticuloAct { get; set; }
        public virtual DbSet<TblArticuloAutoConf> TblArticuloAutoConf { get; set; }
        public virtual DbSet<TblArticuloConsignado> TblArticuloConsignado { get; set; }
        public virtual DbSet<TblArticuloDef> TblArticuloDef { get; set; }
        public virtual DbSet<TblArticuloEcom> TblArticuloEcom { get; set; }
        public virtual DbSet<TblArticuloEcommerce> TblArticuloEcommerce { get; set; }
        public virtual DbSet<TblArticuloGrupo> TblArticuloGrupo { get; set; }
        public virtual DbSet<TblArticuloGrupo1> TblArticuloGrupo1 { get; set; }
        public virtual DbSet<TblArticuloImpuesto> TblArticuloImpuesto { get; set; }
        public virtual DbSet<TblArticuloLocal> TblArticuloLocal { get; set; }
        public virtual DbSet<TblArticuloMedida> TblArticuloMedida { get; set; }
        public virtual DbSet<TblArticuloPromo> TblArticuloPromo { get; set; }
        public virtual DbSet<TblArticuloServ> TblArticuloServ { get; set; }
        public virtual DbSet<TblArticuloSocioNeg> TblArticuloSocioNeg { get; set; }
        public virtual DbSet<TblArticuloTregalo> TblArticuloTregalo { get; set; }
        public virtual DbSet<TblAsueto> TblAsueto { get; set; }
        public virtual DbSet<TblAuditorActivo> TblAuditorActivo { get; set; }
        public virtual DbSet<TblAutorizadorTarjeta> TblAutorizadorTarjeta { get; set; }
        public virtual DbSet<TblBanco> TblBanco { get; set; }
        public virtual DbSet<TblBarras> TblBarras { get; set; }
        public virtual DbSet<TblBarras1> TblBarras1 { get; set; }
        public virtual DbSet<TblBloqGrupoArticulo> TblBloqGrupoArticulo { get; set; }
        public virtual DbSet<TblBodega> TblBodega { get; set; }
        public virtual DbSet<TblBonoArticulo> TblBonoArticulo { get; set; }
        public virtual DbSet<TblCaja> TblCaja { get; set; }
        public virtual DbSet<TblCajaAct> TblCajaAct { get; set; }
        public virtual DbSet<TblCajaTc> TblCajaTc { get; set; }
        public virtual DbSet<TblCambioSoft> TblCambioSoft { get; set; }
        public virtual DbSet<TblCierrePedido> TblCierrePedido { get; set; }
        public virtual DbSet<TblCierreReclamo> TblCierreReclamo { get; set; }
        public virtual DbSet<TblCliente> TblCliente { get; set; }
        public virtual DbSet<TblClienteComodin> TblClienteComodin { get; set; }
        public virtual DbSet<TblClienteIntSbo> TblClienteIntSbo { get; set; }
        public virtual DbSet<TblClienteTarjeta> TblClienteTarjeta { get; set; }
        public virtual DbSet<TblClienteVend> TblClienteVend { get; set; }
        public virtual DbSet<TblCodigoPostal> TblCodigoPostal { get; set; }
        public virtual DbSet<TblCombo> TblCombo { get; set; }
        public virtual DbSet<TblCondicionPago> TblCondicionPago { get; set; }
        public virtual DbSet<TblConversionDeptoEcom> TblConversionDeptoEcom { get; set; }
        public virtual DbSet<TblCreditoEcom> TblCreditoEcom { get; set; }
        public virtual DbSet<TblCreditoLineaCliente> TblCreditoLineaCliente { get; set; }
        public virtual DbSet<TblDepartamento> TblDepartamento { get; set; }
        public virtual DbSet<TblDespiece> TblDespiece { get; set; }
        public virtual DbSet<TblDetAnulacionDoc> TblDetAnulacionDoc { get; set; }
        public virtual DbSet<TblDetAportacion> TblDetAportacion { get; set; }
        public virtual DbSet<TblDetAutPago> TblDetAutPago { get; set; }
        public virtual DbSet<TblDetAutVenta> TblDetAutVenta { get; set; }
        public virtual DbSet<TblDetBonoArticulo> TblDetBonoArticulo { get; set; }
        public virtual DbSet<TblDetCierreOperacion> TblDetCierreOperacion { get; set; }
        public virtual DbSet<TblDetCobro> TblDetCobro { get; set; }
        public virtual DbSet<TblDetComboSap> TblDetComboSap { get; set; }
        public virtual DbSet<TblDetConteoInventario> TblDetConteoInventario { get; set; }
        public virtual DbSet<TblDetDescuento> TblDetDescuento { get; set; }
        public virtual DbSet<TblDetDescuentoGrupo> TblDetDescuentoGrupo { get; set; }
        public virtual DbSet<TblDetDevolucion> TblDetDevolucion { get; set; }
        public virtual DbSet<TblDetDevolucionManual> TblDetDevolucionManual { get; set; }
        public virtual DbSet<TblDetEntrega> TblDetEntrega { get; set; }
        public virtual DbSet<TblDetFactura> TblDetFactura { get; set; }
        public virtual DbSet<TblDetFactura2> TblDetFactura2 { get; set; }
        public virtual DbSet<TblDetFacturaAnulada> TblDetFacturaAnulada { get; set; }
        public virtual DbSet<TblDetFacturaCs> TblDetFacturaCs { get; set; }
        public virtual DbSet<TblDetFacturaEnvio> TblDetFacturaEnvio { get; set; }
        public virtual DbSet<TblDetFacturaRech> TblDetFacturaRech { get; set; }
        public virtual DbSet<TblDetGrupoMarca> TblDetGrupoMarca { get; set; }
        public virtual DbSet<TblDetListaPrecios> TblDetListaPrecios { get; set; }
        public virtual DbSet<TblDetListaPrecios1> TblDetListaPrecios1 { get; set; }
        public virtual DbSet<TblDetListaPreciosEspecial> TblDetListaPreciosEspecial { get; set; }
        public virtual DbSet<TblDetLlamadaReemplazo> TblDetLlamadaReemplazo { get; set; }
        public virtual DbSet<TblDetLlamadaServ> TblDetLlamadaServ { get; set; }
        public virtual DbSet<TblDetMovBodega> TblDetMovBodega { get; set; }
        public virtual DbSet<TblDetNotaCred> TblDetNotaCred { get; set; }
        public virtual DbSet<TblDetNotaCredAnulada> TblDetNotaCredAnulada { get; set; }
        public virtual DbSet<TblDetObsInventario> TblDetObsInventario { get; set; }
        public virtual DbSet<TblDetOla> TblDetOla { get; set; }
        public virtual DbSet<TblDetOlaAudit> TblDetOlaAudit { get; set; }
        public virtual DbSet<TblDetOlaOld> TblDetOlaOld { get; set; }
        public virtual DbSet<TblDetOlaSap> TblDetOlaSap { get; set; }
        public virtual DbSet<TblDetOlaTrasladoDom> TblDetOlaTrasladoDom { get; set; }
        public virtual DbSet<TblDetOperManual> TblDetOperManual { get; set; }
        public virtual DbSet<TblDetOperacionCaja> TblDetOperacionCaja { get; set; }
        public virtual DbSet<TblDetOrdenCompra> TblDetOrdenCompra { get; set; }
        public virtual DbSet<TblDetOservicio> TblDetOservicio { get; set; }
        public virtual DbSet<TblDetOservicioAutVenta> TblDetOservicioAutVenta { get; set; }
        public virtual DbSet<TblDetOservicioDesc> TblDetOservicioDesc { get; set; }
        public virtual DbSet<TblDetOservicioOperManual> TblDetOservicioOperManual { get; set; }
        public virtual DbSet<TblDetPago> TblDetPago { get; set; }
        public virtual DbSet<TblDetPagoInfo> TblDetPagoInfo { get; set; }
        public virtual DbSet<TblDetPagoTarAnulado> TblDetPagoTarAnulado { get; set; }
        public virtual DbSet<TblDetParqueoDesc> TblDetParqueoDesc { get; set; }
        public virtual DbSet<TblDetPedido> TblDetPedido { get; set; }
        public virtual DbSet<TblDetPedido2> TblDetPedido2 { get; set; }
        public virtual DbSet<TblDetPedidoCupon> TblDetPedidoCupon { get; set; }
        public virtual DbSet<TblDetPedidoDesc> TblDetPedidoDesc { get; set; }
        public virtual DbSet<TblDetPedidoDir> TblDetPedidoDir { get; set; }
        public virtual DbSet<TblDetPedidoDirAct> TblDetPedidoDirAct { get; set; }
        public virtual DbSet<TblDetPedidoRegalo> TblDetPedidoRegalo { get; set; }
        public virtual DbSet<TblDetPedidoReqTda> TblDetPedidoReqTda { get; set; }
        public virtual DbSet<TblDetPedidoTregalo> TblDetPedidoTregalo { get; set; }
        public virtual DbSet<TblDetPedidoVtex> TblDetPedidoVtex { get; set; }
        public virtual DbSet<TblDetPeriodo> TblDetPeriodo { get; set; }
        public virtual DbSet<TblDetRetiroEfectivo> TblDetRetiroEfectivo { get; set; }
        public virtual DbSet<TblDetUbicInventario> TblDetUbicInventario { get; set; }
        public virtual DbSet<TblDetUsrInventario> TblDetUsrInventario { get; set; }
        public virtual DbSet<TblDetVenta> TblDetVenta { get; set; }
        public virtual DbSet<TblDetVentaArtDaniado> TblDetVentaArtDaniado { get; set; }
        public virtual DbSet<TblDetVentaCombo> TblDetVentaCombo { get; set; }
        public virtual DbSet<TblDetVentaComboGrp> TblDetVentaComboGrp { get; set; }
        public virtual DbSet<TblDetVentaCuponPromo> TblDetVentaCuponPromo { get; set; }
        public virtual DbSet<TblDetVentaCuponSocio> TblDetVentaCuponSocio { get; set; }
        public virtual DbSet<TblDetVentaDesc> TblDetVentaDesc { get; set; }
        public virtual DbSet<TblDetVentaEncuesta> TblDetVentaEncuesta { get; set; }
        public virtual DbSet<TblDetVentaTarRegalo> TblDetVentaTarRegalo { get; set; }
        public virtual DbSet<TblDevolucion> TblDevolucion { get; set; }
        public virtual DbSet<TblDirSocioNeg> TblDirSocioNeg { get; set; }
        public virtual DbSet<TblDocRegenerado> TblDocRegenerado { get; set; }
        public virtual DbSet<TblDocSap> TblDocSap { get; set; }
        public virtual DbSet<TblDocWmsPos> TblDocWmsPos { get; set; }
        public virtual DbSet<TblDocumento> TblDocumento { get; set; }
        public virtual DbSet<TblDocumentoCl> TblDocumentoCl { get; set; }
        public virtual DbSet<TblDocumentoClSap> TblDocumentoClSap { get; set; }
        public virtual DbSet<TblDocumentoClSapanular> TblDocumentoClSapanular { get; set; }
        public virtual DbSet<TblDocumentoClSat> TblDocumentoClSat { get; set; }
        public virtual DbSet<TblDocumentoClSatfel> TblDocumentoClSatfel { get; set; }
        public virtual DbSet<TblDocumentoClSatfelcontingencia> TblDocumentoClSatfelcontingencia { get; set; }
        public virtual DbSet<TblDocumentoFe> TblDocumentoFe { get; set; }
        public virtual DbSet<TblDocumentoFeMail> TblDocumentoFeMail { get; set; }
        public virtual DbSet<TblDocumentoFeManual> TblDocumentoFeManual { get; set; }
        public virtual DbSet<TblDocumentoFel> TblDocumentoFel { get; set; }
        public virtual DbSet<TblDocumentoIntSbo> TblDocumentoIntSbo { get; set; }
        public virtual DbSet<TblDocumentoMailZenDesk> TblDocumentoMailZenDesk { get; set; }
        public virtual DbSet<TblEmpaque> TblEmpaque { get; set; }
        public virtual DbSet<TblEmpresa> TblEmpresa { get; set; }
        public virtual DbSet<TblEntrega> TblEntrega { get; set; }
        public virtual DbSet<TblEntregaContaSap> TblEntregaContaSap { get; set; }
        public virtual DbSet<TblEnvioIntercambio> TblEnvioIntercambio { get; set; }
        public virtual DbSet<TblEnvioReserva> TblEnvioReserva { get; set; }
        public virtual DbSet<TblEnviosReversados> TblEnviosReversados { get; set; }
        public virtual DbSet<TblEstadoVtex> TblEstadoVtex { get; set; }
        public virtual DbSet<TblExistencia> TblExistencia { get; set; }
        public virtual DbSet<TblExistenciaIni> TblExistenciaIni { get; set; }
        public virtual DbSet<TblExistenciaTda> TblExistenciaTda { get; set; }
        public virtual DbSet<TblFdsordenCompra> TblFdsordenCompra { get; set; }
        public virtual DbSet<TblFormaPago> TblFormaPago { get; set; }
        public virtual DbSet<TblFraseFel> TblFraseFel { get; set; }
        public virtual DbSet<TblGrupoArtDespCentral> TblGrupoArtDespCentral { get; set; }
        public virtual DbSet<TblGrupoArticulo> TblGrupoArticulo { get; set; }
        public virtual DbSet<TblGrupoArticulo1> TblGrupoArticulo1 { get; set; }
        public virtual DbSet<TblGrupoMarca> TblGrupoMarca { get; set; }
        public virtual DbSet<TblGuiaEnvio> TblGuiaEnvio { get; set; }
        public virtual DbSet<TblIdtarjetaComision> TblIdtarjetaComision { get; set; }
        public virtual DbSet<TblImgArticulo> TblImgArticulo { get; set; }
        public virtual DbSet<TblInterfazBloq> TblInterfazBloq { get; set; }
        public virtual DbSet<TblInventario> TblInventario { get; set; }
        public virtual DbSet<TblListaPrecios> TblListaPrecios { get; set; }
        public virtual DbSet<TblLlamadaServ> TblLlamadaServ { get; set; }
        public virtual DbSet<TblLogDevolucion> TblLogDevolucion { get; set; }
        public virtual DbSet<TblLogDevolucionManual> TblLogDevolucionManual { get; set; }
        public virtual DbSet<TblLogDocumentoCl> TblLogDocumentoCl { get; set; }
        public virtual DbSet<TblLogTarjeta> TblLogTarjeta { get; set; }
        public virtual DbSet<TblLogTarjetaSocio> TblLogTarjetaSocio { get; set; }
        public virtual DbSet<TblLogTrasladoSap> TblLogTrasladoSap { get; set; }
        public virtual DbSet<TblLogTrasladoSap1> TblLogTrasladoSap1 { get; set; }
        public virtual DbSet<TblLogTrasladoSat> TblLogTrasladoSat { get; set; }
        public virtual DbSet<TblLogTrxTraslado> TblLogTrxTraslado { get; set; }
        public virtual DbSet<TblMapaLogistico> TblMapaLogistico { get; set; }
        public virtual DbSet<TblMarca> TblMarca { get; set; }
        public virtual DbSet<TblMedida> TblMedida { get; set; }
        public virtual DbSet<TblMedidaPrioridad> TblMedidaPrioridad { get; set; }
        public virtual DbSet<TblMenu> TblMenu { get; set; }
        public virtual DbSet<TblMovBodega> TblMovBodega { get; set; }
        public virtual DbSet<TblMunicipio> TblMunicipio { get; set; }
        public virtual DbSet<TblNivelServicio> TblNivelServicio { get; set; }
        public virtual DbSet<TblOferta> TblOferta { get; set; }
        public virtual DbSet<TblOfertaTda> TblOfertaTda { get; set; }
        public virtual DbSet<TblOla> TblOla { get; set; }
        public virtual DbSet<TblOlaConfirmacion> TblOlaConfirmacion { get; set; }
        public virtual DbSet<TblOlaTransporte> TblOlaTransporte { get; set; }
        public virtual DbSet<TblOperacionCaja> TblOperacionCaja { get; set; }
        public virtual DbSet<TblOprTrasladable> TblOprTrasladable { get; set; }
        public virtual DbSet<TblOprTrasladada> TblOprTrasladada { get; set; }
        public virtual DbSet<TblOrdenCompra> TblOrdenCompra { get; set; }
        public virtual DbSet<TblPais> TblPais { get; set; }
        public virtual DbSet<TblParametro> TblParametro { get; set; }
        public virtual DbSet<TblPedido> TblPedido { get; set; }
        public virtual DbSet<TblPedidoCd> TblPedidoCd { get; set; }
        public virtual DbSet<TblPedidoComp> TblPedidoComp { get; set; }
        public virtual DbSet<TblPedidoConf> TblPedidoConf { get; set; }
        public virtual DbSet<TblPedidoEmpaque> TblPedidoEmpaque { get; set; }
        public virtual DbSet<TblPedidoEmpaqueEnt> TblPedidoEmpaqueEnt { get; set; }
        public virtual DbSet<TblPedidoEntTienda> TblPedidoEntTienda { get; set; }
        public virtual DbSet<TblPedidoEntregaTda> TblPedidoEntregaTda { get; set; }
        public virtual DbSet<TblPedidoGrabacion> TblPedidoGrabacion { get; set; }
        public virtual DbSet<TblPedidoHojaAudit> TblPedidoHojaAudit { get; set; }
        public virtual DbSet<TblPedidoOla> TblPedidoOla { get; set; }
        public virtual DbSet<TblPedidoOnHold> TblPedidoOnHold { get; set; }
        public virtual DbSet<TblPedidoPacking> TblPedidoPacking { get; set; }
        public virtual DbSet<TblPedidoProvLocal> TblPedidoProvLocal { get; set; }
        public virtual DbSet<TblPedidoStatus> TblPedidoStatus { get; set; }
        public virtual DbSet<TblPedidoStatusVtex> TblPedidoStatusVtex { get; set; }
        public virtual DbSet<TblPedidoVtex> TblPedidoVtex { get; set; }
        public virtual DbSet<TblPerfil> TblPerfil { get; set; }
        public virtual DbSet<TblPeriodo> TblPeriodo { get; set; }
        public virtual DbSet<TblPermiso> TblPermiso { get; set; }
        public virtual DbSet<TblPersonal> TblPersonal { get; set; }
        public virtual DbSet<TblProveedorLocal> TblProveedorLocal { get; set; }
        public virtual DbSet<TblRazonLlamada> TblRazonLlamada { get; set; }
        public virtual DbSet<TblReclamo> TblReclamo { get; set; }
        public virtual DbSet<TblRegaloRemplazo> TblRegaloRemplazo { get; set; }
        public virtual DbSet<TblRequerimiento> TblRequerimiento { get; set; }
        public virtual DbSet<TblResolucionDoc> TblResolucionDoc { get; set; }
        public virtual DbSet<TblRetiroEfectivo> TblRetiroEfectivo { get; set; }
        public virtual DbSet<TblRutaDespDefault> TblRutaDespDefault { get; set; }
        public virtual DbSet<TblRutaDespacho> TblRutaDespacho { get; set; }
        public virtual DbSet<TblSerieDocSap> TblSerieDocSap { get; set; }
        public virtual DbSet<TblSerieDocs> TblSerieDocs { get; set; }
        public virtual DbSet<TblSocioNeg> TblSocioNeg { get; set; }
        public virtual DbSet<TblTablaSinc> TblTablaSinc { get; set; }
        public virtual DbSet<TblTarimaTransporte> TblTarimaTransporte { get; set; }
        public virtual DbSet<TblTiempoTemporal> TblTiempoTemporal { get; set; }
        public virtual DbSet<TblTienda> TblTienda { get; set; }
        public virtual DbSet<TblTiendaAutTarjeta> TblTiendaAutTarjeta { get; set; }
        public virtual DbSet<TblTiendaSat> TblTiendaSat { get; set; }
        public virtual DbSet<TblTipoAccion> TblTipoAccion { get; set; }
        public virtual DbSet<TblTipoCd> TblTipoCd { get; set; }
        public virtual DbSet<TblTipoCertificado> TblTipoCertificado { get; set; }
        public virtual DbSet<TblTipoCredito> TblTipoCredito { get; set; }
        public virtual DbSet<TblTipoDescuento> TblTipoDescuento { get; set; }
        public virtual DbSet<TblTipoDocumento> TblTipoDocumento { get; set; }
        public virtual DbSet<TblTipoEnvoltorio> TblTipoEnvoltorio { get; set; }
        public virtual DbSet<TblTipoMailZdesk> TblTipoMailZdesk { get; set; }
        public virtual DbSet<TblTipoMovBodega> TblTipoMovBodega { get; set; }
        public virtual DbSet<TblTipoRuta> TblTipoRuta { get; set; }
        public virtual DbSet<TblTipoRutaOld> TblTipoRutaOld { get; set; }
        public virtual DbSet<TblTipoTarRegalo> TblTipoTarRegalo { get; set; }
        public virtual DbSet<TblTipoTienda> TblTipoTienda { get; set; }
        public virtual DbSet<TblTipoUbicacion> TblTipoUbicacion { get; set; }
        public virtual DbSet<TblTransaccional> TblTransaccional { get; set; }
        public virtual DbSet<TblTransporte> TblTransporte { get; set; }
        public virtual DbSet<TblTraslado> TblTraslado { get; set; }
        public virtual DbSet<TblTrxSocio> TblTrxSocio { get; set; }
        public virtual DbSet<TblTrxTrasladable> TblTrxTrasladable { get; set; }
        public virtual DbSet<TblTrxTrasladada> TblTrxTrasladada { get; set; }
        public virtual DbSet<TblUbicacion> TblUbicacion { get; set; }
        public virtual DbSet<TblUbicacionGrupo> TblUbicacionGrupo { get; set; }
        public virtual DbSet<TblUbicacionWms> TblUbicacionWms { get; set; }
        public virtual DbSet<TblUsuario> TblUsuario { get; set; }
        public virtual DbSet<TblVentaTiempoAire> TblVentaTiempoAire { get; set; }
        public virtual DbSet<TblVisita> TblVisita { get; set; }
        public virtual DbSet<TblZona> TblZona { get; set; }
        public virtual DbSet<TempDetPedido> TempDetPedido { get; set; }
        public virtual DbSet<TempDetRuta> TempDetRuta { get; set; }
        public virtual DbSet<TempDetUbicInventario> TempDetUbicInventario { get; set; }
        public virtual DbSet<TempDetUsrInventario> TempDetUsrInventario { get; set; }
        public virtual DbSet<TempOferta> TempOferta { get; set; }
        public virtual DbSet<TmpArticuloEcommerce> TmpArticuloEcommerce { get; set; }
        public virtual DbSet<TmpSincronizaSkuMagentoWms3> TmpSincronizaSkuMagentoWms3 { get; set; }
        public virtual DbSet<TmsDocInterfaz> TmsDocInterfaz { get; set; }
        public virtual DbSet<ViwArchDetFactura> ViwArchDetFactura { get; set; }
        public virtual DbSet<ViwArchDetFacturaAnulada> ViwArchDetFacturaAnulada { get; set; }
        public virtual DbSet<ViwCardex> ViwCardex { get; set; }
        public virtual DbSet<ViwComboDisponible> ViwComboDisponible { get; set; }
        public virtual DbSet<ViwDetFactura> ViwDetFactura { get; set; }
        public virtual DbSet<ViwDetFacturaAnulada> ViwDetFacturaAnulada { get; set; }
        public virtual DbSet<ViwDetOlaDesp> ViwDetOlaDesp { get; set; }
        public virtual DbSet<ViwDetPacking> ViwDetPacking { get; set; }
        public virtual DbSet<ViwDocumentoFiscal> ViwDocumentoFiscal { get; set; }
        public virtual DbSet<ViwPedidoEmpaque> ViwPedidoEmpaque { get; set; }
        public virtual DbSet<ViwPedidoEntrega> ViwPedidoEntrega { get; set; }
        public virtual DbSet<ViwPedidoOcNasa> ViwPedidoOcNasa { get; set; }
        public virtual DbSet<ViwTipoPago> ViwTipoPago { get; set; }
        public virtual DbSet<VwClientesRfmcemacocom> VwClientesRfmcemacocom { get; set; }
        public virtual DbSet<VwPickingTiendasDetallePedido> VwPickingTiendasDetallePedido { get; set; }
        public virtual DbSet<VwUClienteprivilegio> VwUClienteprivilegio { get; set; }
        public virtual DbSet<Z20190927TblDetOla> Z20190927TblDetOla { get; set; }
        public virtual DbSet<Z20190927TblOla> Z20190927TblOla { get; set; }
        public virtual DbSet<Z20190927TblRequerimiento> Z20190927TblRequerimiento { get; set; }
        public virtual DbSet<ZArticulosGrandesReporte> ZArticulosGrandesReporte { get; set; }
        public virtual DbSet<ZDashboardCollection> ZDashboardCollection { get; set; }
        public virtual DbSet<ZDashboardboCantidadpedidosBodasenlinea> ZDashboardboCantidadpedidosBodasenlinea { get; set; }
        public virtual DbSet<ZDashboardboFormapago> ZDashboardboFormapago { get; set; }
        public virtual DbSet<ZDashboardboFormapagoCm> ZDashboardboFormapagoCm { get; set; }
        public virtual DbSet<ZDashboardboInventarioOrigen> ZDashboardboInventarioOrigen { get; set; }
        public virtual DbSet<ZDashboardboInventarioOrigenVersion2> ZDashboardboInventarioOrigenVersion2 { get; set; }
        public virtual DbSet<ZDashboardboUsuariosunicosCompra> ZDashboardboUsuariosunicosCompra { get; set; }
        public virtual DbSet<ZDashboardecBodaNoboda> ZDashboardecBodaNoboda { get; set; }
        public virtual DbSet<ZDashboardecBodaNoboda2> ZDashboardecBodaNoboda2 { get; set; }
        public virtual DbSet<ZDashboardecBodaNobodaCm> ZDashboardecBodaNobodaCm { get; set; }
        public virtual DbSet<ZDashboardecBodascreadas> ZDashboardecBodascreadas { get; set; }
        public virtual DbSet<ZDashboardecBodascreadasCm> ZDashboardecBodascreadasCm { get; set; }
        public virtual DbSet<ZDashboardecCantidadPedidosbodas> ZDashboardecCantidadPedidosbodas { get; set; }
        public virtual DbSet<ZDashboardecCantidadPedidosbodasCm> ZDashboardecCantidadPedidosbodasCm { get; set; }
        public virtual DbSet<ZDashboardecCatalogoMs3> ZDashboardecCatalogoMs3 { get; set; }
        public virtual DbSet<ZDashboardecCentrosporpedido> ZDashboardecCentrosporpedido { get; set; }
        public virtual DbSet<ZDashboardecCentrosporpedidoBodaNoboda> ZDashboardecCentrosporpedidoBodaNoboda { get; set; }
        public virtual DbSet<ZDashboardecCentrosporpedidoCm> ZDashboardecCentrosporpedidoCm { get; set; }
        public virtual DbSet<ZDashboardecCostoenvio> ZDashboardecCostoenvio { get; set; }
        public virtual DbSet<ZDashboardecFillrate> ZDashboardecFillrate { get; set; }
        public virtual DbSet<ZDashboardecFillrateBodaIntercambio> ZDashboardecFillrateBodaIntercambio { get; set; }
        public virtual DbSet<ZDashboardecFillrateBodaNoboda> ZDashboardecFillrateBodaNoboda { get; set; }
        public virtual DbSet<ZDashboardecFillrateCentro> ZDashboardecFillrateCentro { get; set; }
        public virtual DbSet<ZDashboardecFillrateCentroBodaNoboda> ZDashboardecFillrateCentroBodaNoboda { get; set; }
        public virtual DbSet<ZDashboardecFillrateCentroCm> ZDashboardecFillrateCentroCm { get; set; }
        public virtual DbSet<ZDashboardecFillrateCm> ZDashboardecFillrateCm { get; set; }
        public virtual DbSet<ZDashboardecHorasentrega> ZDashboardecHorasentrega { get; set; }
        public virtual DbSet<ZDashboardecHorasentregaCm> ZDashboardecHorasentregaCm { get; set; }
        public virtual DbSet<ZDashboardecHorasentregaInventario> ZDashboardecHorasentregaInventario { get; set; }
        public virtual DbSet<ZDashboardecHorashabilesrecoleccion> ZDashboardecHorashabilesrecoleccion { get; set; }
        public virtual DbSet<ZDashboardecLineasPorPedido> ZDashboardecLineasPorPedido { get; set; }
        public virtual DbSet<ZDashboardecLineasPorPedidoCm> ZDashboardecLineasPorPedidoCm { get; set; }
        public virtual DbSet<ZDashboardecPagogyt24horas> ZDashboardecPagogyt24horas { get; set; }
        public virtual DbSet<ZDashboardecPagosbi> ZDashboardecPagosbi { get; set; }
        public virtual DbSet<ZDashboardecPagosgyt> ZDashboardecPagosgyt { get; set; }
        public virtual DbSet<ZDashboardecPedidosGyt> ZDashboardecPedidosGyt { get; set; }
        public virtual DbSet<ZDashboardecPedidosGytCm> ZDashboardecPedidosGytCm { get; set; }
        public virtual DbSet<ZDashboardecPedidosGytXtelefono> ZDashboardecPedidosGytXtelefono { get; set; }
        public virtual DbSet<ZDashboardecPedidosTarjetaCd> ZDashboardecPedidosTarjetaCd { get; set; }
        public virtual DbSet<ZDashboardecPedidosTarjetaCdCm> ZDashboardecPedidosTarjetaCdCm { get; set; }
        public virtual DbSet<ZDashboardecPedidosTarjetaCdXtelefono> ZDashboardecPedidosTarjetaCdXtelefono { get; set; }
        public virtual DbSet<ZDashboardecPedidosfacturados> ZDashboardecPedidosfacturados { get; set; }
        public virtual DbSet<ZDashboardecPedidosfacturadosCm> ZDashboardecPedidosfacturadosCm { get; set; }
        public virtual DbSet<ZDashboardecPrivi> ZDashboardecPrivi { get; set; }
        public virtual DbSet<ZDashboardecPriviCm> ZDashboardecPriviCm { get; set; }
        public virtual DbSet<ZDashboardecPromediocliente> ZDashboardecPromediocliente { get; set; }
        public virtual DbSet<ZDashboardecPromedioclienteCm> ZDashboardecPromedioclienteCm { get; set; }
        public virtual DbSet<ZDashboardecTopMunicipiosCm> ZDashboardecTopMunicipiosCm { get; set; }
        public virtual DbSet<ZDashboardecTopMunicipiosLmtd> ZDashboardecTopMunicipiosLmtd { get; set; }
        public virtual DbSet<ZDashboardecTopMunicipiosLw> ZDashboardecTopMunicipiosLw { get; set; }
        public virtual DbSet<ZDashboardecTopMunicipiosLymtd> ZDashboardecTopMunicipiosLymtd { get; set; }
        public virtual DbSet<ZDashboardecTopMunicipiosMtd> ZDashboardecTopMunicipiosMtd { get; set; }
        public virtual DbSet<ZDashboardecTopdeptosBodaCm> ZDashboardecTopdeptosBodaCm { get; set; }
        public virtual DbSet<ZDashboardecTopdeptosBodaLmtd> ZDashboardecTopdeptosBodaLmtd { get; set; }
        public virtual DbSet<ZDashboardecTopdeptosBodaLw> ZDashboardecTopdeptosBodaLw { get; set; }
        public virtual DbSet<ZDashboardecTopdeptosBodaLymtd> ZDashboardecTopdeptosBodaLymtd { get; set; }
        public virtual DbSet<ZDashboardecTopdeptosBodaMtd> ZDashboardecTopdeptosBodaMtd { get; set; }
        public virtual DbSet<ZDashboardecTopdeptosLmtd> ZDashboardecTopdeptosLmtd { get; set; }
        public virtual DbSet<ZDashboardecTopdeptosLw> ZDashboardecTopdeptosLw { get; set; }
        public virtual DbSet<ZDashboardecTopdeptosLwCm> ZDashboardecTopdeptosLwCm { get; set; }
        public virtual DbSet<ZDashboardecTopdeptosLymtd> ZDashboardecTopdeptosLymtd { get; set; }
        public virtual DbSet<ZDashboardecTopdeptosMtd> ZDashboardecTopdeptosMtd { get; set; }
        public virtual DbSet<ZDashboardecTopdeptosNobodaCm> ZDashboardecTopdeptosNobodaCm { get; set; }
        public virtual DbSet<ZDashboardecTopdeptosNobodaLmtd> ZDashboardecTopdeptosNobodaLmtd { get; set; }
        public virtual DbSet<ZDashboardecTopdeptosNobodaLw> ZDashboardecTopdeptosNobodaLw { get; set; }
        public virtual DbSet<ZDashboardecTopdeptosNobodaLymtd> ZDashboardecTopdeptosNobodaLymtd { get; set; }
        public virtual DbSet<ZDashboardecTopdeptosNobodaMtd> ZDashboardecTopdeptosNobodaMtd { get; set; }
        public virtual DbSet<ZDashboardecTrDia> ZDashboardecTrDia { get; set; }
        public virtual DbSet<ZDashboardecTrDiaCm> ZDashboardecTrDiaCm { get; set; }
        public virtual DbSet<ZDashboardecTransacciones> ZDashboardecTransacciones { get; set; }
        public virtual DbSet<ZDashboardecTransaccionesCm> ZDashboardecTransaccionesCm { get; set; }
        public virtual DbSet<ZDashboardecTransaccionesVentasxtelefono> ZDashboardecTransaccionesVentasxtelefono { get; set; }
        public virtual DbSet<ZDashboardecVentabodasTiendaInternet> ZDashboardecVentabodasTiendaInternet { get; set; }
        public virtual DbSet<ZDashboardecVentasBoda> ZDashboardecVentasBoda { get; set; }
        public virtual DbSet<ZDashboardecVentasBodaCm> ZDashboardecVentasBodaCm { get; set; }
        public virtual DbSet<ZDashboardecVentasCallcenter> ZDashboardecVentasCallcenter { get; set; }
        public virtual DbSet<ZDashboardecVentasCallcenterColaborador> ZDashboardecVentasCallcenterColaborador { get; set; }
        public virtual DbSet<ZDashboardecVentasNoboda> ZDashboardecVentasNoboda { get; set; }
        public virtual DbSet<ZDashboardecVentasNobodaCm> ZDashboardecVentasNobodaCm { get; set; }
        public virtual DbSet<ZDashboardecVentasdia> ZDashboardecVentasdia { get; set; }
        public virtual DbSet<ZDashboardecVentasdiaBoda> ZDashboardecVentasdiaBoda { get; set; }
        public virtual DbSet<ZDashboardecVentasdiaBodaCm> ZDashboardecVentasdiaBodaCm { get; set; }
        public virtual DbSet<ZDashboardecVentasdiaCm> ZDashboardecVentasdiaCm { get; set; }
        public virtual DbSet<ZDashboardecVentasdiaNoboda> ZDashboardecVentasdiaNoboda { get; set; }
        public virtual DbSet<ZDashboardecVentasdiaNobodaCm> ZDashboardecVentasdiaNobodaCm { get; set; }
        public virtual DbSet<ZEmailRequerimientoManual> ZEmailRequerimientoManual { get; set; }
        public virtual DbSet<ZMard> ZMard { get; set; }
        public virtual DbSet<ZOlas> ZOlas { get; set; }
        public virtual DbSet<ZPedidoIncompleto> ZPedidoIncompleto { get; set; }
        public virtual DbSet<ZPedidoMontoAlto> ZPedidoMontoAlto { get; set; }
        public virtual DbSet<ZRequerimientos> ZRequerimientos { get; set; }
        public virtual DbSet<ZSkuPromocion> ZSkuPromocion { get; set; }
        public virtual DbSet<ZStockcomprometido> ZStockcomprometido { get; set; }
        public virtual DbSet<ZTblAreaDistCentro20200620> ZTblAreaDistCentro20200620 { get; set; }
        public virtual DbSet<ZTblArticuloFalta> ZTblArticuloFalta { get; set; }
        public virtual DbSet<ZTbldetCodigoDescuento> ZTbldetCodigoDescuento { get; set; }
        public virtual DbSet<ZTbldetCodigoDescuento3> ZTbldetCodigoDescuento3 { get; set; }
        public virtual DbSet<ZVentaCelular> ZVentaCelular { get; set; }
        public virtual DbSet<ZVwCarretaRt> ZVwCarretaRt { get; set; }
        public virtual DbSet<ZVwDashboardTiendas1> ZVwDashboardTiendas1 { get; set; }
        public virtual DbSet<ZVwDashboardTiendas2> ZVwDashboardTiendas2 { get; set; }
        public virtual DbSet<ZVwDashboardecEmpresaTransporte> ZVwDashboardecEmpresaTransporte { get; set; }
        public virtual DbSet<ZVwDashboardecEmpresaTransporteCm> ZVwDashboardecEmpresaTransporteCm { get; set; }
        public virtual DbSet<ZVwHorasEntrega> ZVwHorasEntrega { get; set; }
        public virtual DbSet<ZVwPickingFechaOla> ZVwPickingFechaOla { get; set; }
        public virtual DbSet<ZVwPickingPorEntregaDup> ZVwPickingPorEntregaDup { get; set; }
        public virtual DbSet<ZVwPickingPorEntregaFinal> ZVwPickingPorEntregaFinal { get; set; }
        public virtual DbSet<ZVwPickingPorEntregaNodup> ZVwPickingPorEntregaNodup { get; set; }
        public virtual DbSet<ZVwRevisionDirecciones> ZVwRevisionDirecciones { get; set; }
        public virtual DbSet<ZVwSkuEnProceso> ZVwSkuEnProceso { get; set; }
        public virtual DbSet<ZVwSkuEnProceso1> ZVwSkuEnProceso1 { get; set; }
        public virtual DbSet<Zbackuphistory> Zbackuphistory { get; set; }
        public virtual DbSet<Zcalendarioretail> Zcalendarioretail { get; set; }
        public virtual DbSet<ZcrgArticulodef> ZcrgArticulodef { get; set; }
        public virtual DbSet<ZnjerarArea> ZnjerarArea { get; set; }
        public virtual DbSet<Zoc> Zoc { get; set; }
        public virtual DbSet<Zresultadotec> Zresultadotec { get; set; }
        public virtual DbSet<Zskumal> Zskumal { get; set; }
        public virtual DbSet<Zskumal2> Zskumal2 { get; set; }
        public virtual DbSet<ZtblAreaDistCentroDomingo> ZtblAreaDistCentroDomingo { get; set; }
        public virtual DbSet<ZtblAreaDistCentroDomingopm> ZtblAreaDistCentroDomingopm { get; set; }
        public virtual DbSet<ZtblAreaDistCentroSemana> ZtblAreaDistCentroSemana { get; set; }
        public virtual DbSet<ZtblEntregaGuia> ZtblEntregaGuia { get; set; }
        public virtual DbSet<ZtblEntregaProveedor> ZtblEntregaProveedor { get; set; }
        public virtual DbSet<ZtblEntregaProveedorFotos> ZtblEntregaProveedorFotos { get; set; }
        public virtual DbSet<ZtblProveedorLocal> ZtblProveedorLocal { get; set; }
        public virtual DbSet<ZtbldetEntregaGuia> ZtbldetEntregaGuia { get; set; }
        public virtual DbSet<ZtbldetHistorialPedido> ZtbldetHistorialPedido { get; set; }
        public virtual DbSet<ZtbldetSms> ZtbldetSms { get; set; }
        public virtual DbSet<ZtbldetSms20200404> ZtbldetSms20200404 { get; set; }
        public virtual DbSet<Ztemporal> Ztemporal { get; set; }
        public virtual DbSet<ZtmpSms> ZtmpSms { get; set; }
        public virtual DbSet<ZtmpTblArticuloLocal> ZtmpTblArticuloLocal { get; set; }
        public virtual DbSet<ZviwPedidoIncompleto> ZviwPedidoIncompleto { get; set; }
        public virtual DbSet<ZviwRequerimientosCentroDistB001> ZviwRequerimientosCentroDistB001 { get; set; }
        public virtual DbSet<ZviweBodaNoboda> ZviweBodaNoboda { get; set; }
        public virtual DbSet<ZvwPedidoIncluyeMuebles> ZvwPedidoIncluyeMuebles { get; set; }
        public virtual DbSet<ZvwPedidoIncluyePromocion> ZvwPedidoIncluyePromocion { get; set; }
        public virtual DbSet<ZvwPrimeraCompra> ZvwPrimeraCompra { get; set; }
         
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ArchDetFactura>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ArchDet_Factura");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTipoFinal).HasColumnName("Cod_TipoFinal");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdAuditor)
                    .HasColumnName("ID_Auditor")
                    .HasMaxLength(40);

                entity.Property(e => e.IdUbicAuditoria)
                    .IsRequired()
                    .HasColumnName("ID_UbicAuditoria")
                    .HasMaxLength(25);

                entity.Property(e => e.NumDocFinal)
                    .HasColumnName("Num_DocFinal")
                    .HasMaxLength(50);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Skufact)
                    .HasColumnName("SKUFact")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<ArchDetFacturaAnulada>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ArchDet_FacturaAnulada");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTipoFinal).HasColumnName("Cod_TipoFinal");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdAuditor)
                    .HasColumnName("ID_Auditor")
                    .HasMaxLength(40);

                entity.Property(e => e.IdUbicReingreso)
                    .IsRequired()
                    .HasColumnName("ID_UbicReingreso")
                    .HasMaxLength(25);

                entity.Property(e => e.NumDocFinal)
                    .HasColumnName("Num_DocFinal")
                    .HasMaxLength(50);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Skufact)
                    .HasColumnName("SKUFact")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<ArchDetMovBodega>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ArchDet_MovBodega");

                entity.Property(e => e.CodMedida)
                    .IsRequired()
                    .HasColumnName("Cod_Medida")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.DocSap)
                    .HasColumnName("DocSAP")
                    .HasMaxLength(15);

                entity.Property(e => e.FechaOp).HasColumnType("datetime");

                entity.Property(e => e.FechaSap)
                    .HasColumnName("FechaSAP")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdUbicDest)
                    .HasColumnName("ID_UbicDest")
                    .HasMaxLength(25);

                entity.Property(e => e.IdUbicOrig)
                    .HasColumnName("ID_UbicOrig")
                    .HasMaxLength(25);

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ArchDetNotaCred>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ArchDet_NotaCred");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTipoFinal).HasColumnName("Cod_TipoFinal");

                entity.Property(e => e.FactOrigen).HasMaxLength(25);

                entity.Property(e => e.NumDocFinal)
                    .HasColumnName("Num_DocFinal")
                    .HasMaxLength(50);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.PrecioBase).HasColumnType("money");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ArchDetNotaCredAnulada>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ArchDet_NotaCredAnulada");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTipoFinal).HasColumnName("Cod_TipoFinal");

                entity.Property(e => e.NumDocFinal)
                    .HasColumnName("Num_DocFinal")
                    .HasMaxLength(50);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ArchDetOla>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ArchDet_Ola");

                entity.Property(e => e.CodMedida)
                    .IsRequired()
                    .HasColumnName("Cod_Medida")
                    .HasMaxLength(10);

                entity.Property(e => e.CodMedidaRec)
                    .HasColumnName("Cod_MedidaRec")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipoDocUbic).HasColumnName("Cod_TipoDocUbic");

                entity.Property(e => e.FechaRec).HasColumnType("datetime");

                entity.Property(e => e.IdRecolector)
                    .HasColumnName("ID_Recolector")
                    .HasMaxLength(40);

                entity.Property(e => e.IdUbicAudit)
                    .HasColumnName("ID_UbicAudit")
                    .HasMaxLength(25);

                entity.Property(e => e.IdUbicReal)
                    .HasColumnName("ID_UbicReal")
                    .HasMaxLength(25);

                entity.Property(e => e.IdUbicSug)
                    .IsRequired()
                    .HasColumnName("ID_UbicSug")
                    .HasMaxLength(25);

                entity.Property(e => e.NumDocUbic)
                    .HasColumnName("Num_DocUbic")
                    .HasMaxLength(25);

                entity.Property(e => e.NumOla)
                    .IsRequired()
                    .HasColumnName("Num_Ola")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Skufact)
                    .HasColumnName("SKUFact")
                    .HasMaxLength(25);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ArchDetPedido>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ArchDet_Pedido");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Precio).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.PrecioBase).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.PrecioOrig).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(20);

                entity.Property(e => e.Skufact)
                    .HasColumnName("SKUFact")
                    .HasMaxLength(20);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Calendarioretail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("calendarioretail");

                entity.Property(e => e.FechaCalendario).HasColumnType("datetime");
            });

            modelBuilder.Entity<CompExistencia>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Comp_Existencia");

                entity.Property(e => e.CodMedida)
                    .IsRequired()
                    .HasColumnName("Cod_Medida")
                    .HasMaxLength(10);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdUbicacion)
                    .IsRequired()
                    .HasColumnName("ID_Ubicacion")
                    .HasMaxLength(20);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<CrgArticulo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Crg_Articulo");

                entity.Property(e => e.Categoria)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodEmpresa)
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.CodGrupo)
                    .HasColumnName("Cod_Grupo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodGrupoMarca).HasColumnName("Cod_GrupoMarca");

                entity.Property(e => e.CodMarca).HasColumnName("Cod_Marca");

                entity.Property(e => e.Creacion).HasColumnType("datetime");

                entity.Property(e => e.Foto)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Modelo).HasMaxLength(100);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<CrgArticulo1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Crg_Articulo", "pos");

                entity.Property(e => e.CodGrupo)
                    .HasColumnName("Cod_Grupo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodProveedor)
                    .HasColumnName("Cod_Proveedor")
                    .HasMaxLength(15);

                entity.Property(e => e.Creacion).HasColumnType("datetime");

                entity.Property(e => e.Foto)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Garantia)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Mensaje)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ModoVenta)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CrgArticuloConsignado>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Crg_ArticuloConsignado", "pos");

                entity.Property(e => e.Proveedor)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CrgArticuloDef>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Crg_ArticuloDef", "pos");

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<CrgArticuloGrupo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Crg_ArticuloGrupo");

                entity.Property(e => e.CodEmpresa)
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.CodGrupo)
                    .HasColumnName("Cod_Grupo")
                    .HasMaxLength(20);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<CrgBarras>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Crg_Barras");

                entity.Property(e => e.Barras)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.Principal)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(20);

                entity.Property(e => e.TrasladadoSap)
                    .HasColumnName("TrasladadoSAP")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<CrgBarras1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Crg_Barras", "pos");

                entity.Property(e => e.Barras)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.Principal)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<CrgDetFactura>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CrgDet_Factura");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTipoFinal).HasColumnName("Cod_TipoFinal");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdAuditor)
                    .HasColumnName("ID_Auditor")
                    .HasMaxLength(40);

                entity.Property(e => e.IdUbicAuditoria)
                    .IsRequired()
                    .HasColumnName("ID_UbicAuditoria")
                    .HasMaxLength(25);

                entity.Property(e => e.NumDocFinal)
                    .HasColumnName("Num_DocFinal")
                    .HasMaxLength(50);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Skufact)
                    .HasColumnName("SKUFact")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<CrgDetFacturaAnulada>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CrgDet_FacturaAnulada");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTipoFinal).HasColumnName("Cod_TipoFinal");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdAuditor)
                    .HasColumnName("ID_Auditor")
                    .HasMaxLength(40);

                entity.Property(e => e.IdUbicReingreso)
                    .IsRequired()
                    .HasColumnName("ID_UbicReingreso")
                    .HasMaxLength(25);

                entity.Property(e => e.NumDocFinal)
                    .HasColumnName("Num_DocFinal")
                    .HasMaxLength(50);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Skufact)
                    .HasColumnName("SKUFact")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<CrgDetListaPrecios>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CrgDet_ListaPrecios");

                entity.Property(e => e.CodLista).HasColumnName("Cod_Lista");

                entity.Property(e => e.CodMoneda)
                    .HasColumnName("Cod_Moneda")
                    .HasMaxLength(3);

                entity.Property(e => e.Factor).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<CrgDetListaPrecios1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CrgDet_ListaPrecios", "pos");

                entity.Property(e => e.CodLista).HasColumnName("Cod_Lista");

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<CrgDetListaPreciosDev>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CrgDet_ListaPreciosDev", "pos");

                entity.Property(e => e.CodLista).HasColumnName("Cod_Lista");

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<CrgDetListaPreciosEspecial>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CrgDet_ListaPreciosEspecial");

                entity.Property(e => e.Idtributario)
                    .IsRequired()
                    .HasColumnName("IDTributario")
                    .HasMaxLength(100);

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<CrgDetMovBodega>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CrgDet_MovBodega");

                entity.Property(e => e.CodMedida)
                    .IsRequired()
                    .HasColumnName("Cod_Medida")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.DocSap)
                    .HasColumnName("DocSAP")
                    .HasMaxLength(15);

                entity.Property(e => e.FechaOp).HasColumnType("datetime");

                entity.Property(e => e.FechaSap)
                    .HasColumnName("FechaSAP")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdUbicDest)
                    .HasColumnName("ID_UbicDest")
                    .HasMaxLength(25);

                entity.Property(e => e.IdUbicOrig)
                    .HasColumnName("ID_UbicOrig")
                    .HasMaxLength(25);

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<CrgDetNotaCred>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CrgDet_NotaCred");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTipoFinal).HasColumnName("Cod_TipoFinal");

                entity.Property(e => e.NumDocFinal)
                    .HasColumnName("Num_DocFinal")
                    .HasMaxLength(50);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<CrgDetNotaCredAnulada>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CrgDet_NotaCredAnulada");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTipoFinal).HasColumnName("Cod_TipoFinal");

                entity.Property(e => e.NumDocFinal)
                    .HasColumnName("Num_DocFinal")
                    .HasMaxLength(50);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<CrgDirSocioNeg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Crg_DirSocioNeg");

                entity.Property(e => e.Ciudad)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CodCliente)
                    .IsRequired()
                    .HasColumnName("Cod_Cliente")
                    .HasMaxLength(25);

                entity.Property(e => e.CodEmpresa)
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.CodEstado)
                    .HasColumnName("Cod_Estado")
                    .HasMaxLength(10);

                entity.Property(e => e.CodMunicipio)
                    .HasColumnName("Cod_Municipio")
                    .HasMaxLength(10);

                entity.Property(e => e.CodPais)
                    .HasColumnName("Cod_Pais")
                    .HasMaxLength(10);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CrgGrupoArticulo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Crg_GrupoArticulo");

                entity.Property(e => e.CodEmpresa)
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.CodGrupo)
                    .IsRequired()
                    .HasColumnName("Cod_Grupo")
                    .HasMaxLength(20);

                entity.Property(e => e.CodPadre)
                    .HasColumnName("Cod_Padre")
                    .HasMaxLength(20);

                entity.Property(e => e.Nombre).HasMaxLength(100);
            });

            modelBuilder.Entity<CrgGrupoArticulo1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Crg_GrupoArticulo", "pos");

                entity.Property(e => e.CodGrupo)
                    .IsRequired()
                    .HasColumnName("Cod_Grupo")
                    .HasMaxLength(20);

                entity.Property(e => e.CodPadre)
                    .HasColumnName("Cod_Padre")
                    .HasMaxLength(20);

                entity.Property(e => e.Nivel).HasColumnName("nivel");

                entity.Property(e => e.Nombre).HasMaxLength(100);
            });

            modelBuilder.Entity<CrgListaPrecios>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Crg_ListaPrecios");

                entity.Property(e => e.CodLista).HasColumnName("Cod_Lista");

                entity.Property(e => e.Factor).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<CrgSocioNeg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Crg_SocioNeg");

                entity.Property(e => e.Ciudad).HasMaxLength(100);

                entity.Property(e => e.CiudadPostal).HasMaxLength(100);

                entity.Property(e => e.CodEmpresa)
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.CodMoneda)
                    .HasColumnName("Cod_Moneda")
                    .HasMaxLength(3);

                entity.Property(e => e.CodSocio)
                    .IsRequired()
                    .HasColumnName("Cod_Socio")
                    .HasMaxLength(15);

                entity.Property(e => e.CodTipoCred).HasColumnName("Cod_TipoCred");

                entity.Property(e => e.CodTransporte)
                    .HasColumnName("Cod_Transporte")
                    .HasMaxLength(25);

                entity.Property(e => e.CodVendedor)
                    .HasColumnName("Cod_Vendedor")
                    .HasMaxLength(15);

                entity.Property(e => e.Contacto).HasMaxLength(90);

                entity.Property(e => e.CreditoTransp).HasMaxLength(25);

                entity.Property(e => e.Direccion).HasMaxLength(100);

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(100);

                entity.Property(e => e.Fax).HasMaxLength(20);

                entity.Property(e => e.HoraVisita).HasMaxLength(10);

                entity.Property(e => e.Nit)
                    .HasColumnName("NIT")
                    .HasMaxLength(20);

                entity.Property(e => e.Nombre).HasMaxLength(100);

                entity.Property(e => e.Postal).HasMaxLength(100);

                entity.Property(e => e.Sociedad).HasMaxLength(100);

                entity.Property(e => e.Telefono1).HasMaxLength(20);

                entity.Property(e => e.Telefono2).HasMaxLength(20);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Zip)
                    .HasColumnName("ZIP")
                    .HasMaxLength(20);

                entity.Property(e => e.Zippostal)
                    .HasColumnName("ZIPPostal")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<CrgUbicacion>(entity =>
            {
                entity.HasKey(e => new { e.IdUbicacion, e.CodTipo })
                    .HasName("PKCrg_Ubicacion");

                entity.ToTable("Crg_Ubicacion");

                entity.Property(e => e.IdUbicacion)
                    .HasColumnName("ID_Ubicacion")
                    .HasMaxLength(25);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodBodega)
                    .IsRequired()
                    .HasColumnName("Cod_Bodega")
                    .HasMaxLength(10);

                entity.Property(e => e.Licencia)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Nivel)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.NivelRack)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Pasillo)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Rack)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ProductosBronto>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Image)
                    .HasColumnName("image")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IsInStock)
                    .HasColumnName("is_in_stock")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ParentProductId)
                    .HasColumnName("parent_product_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCategory)
                    .HasColumnName("product_category")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.ProductDescription)
                    .HasColumnName("Product Description")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProductUrl)
                    .HasColumnName("product_url")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Qty)
                    .HasColumnName("qty")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sku)
                    .HasColumnName("sku")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SboOitw>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SBO_OITW");

                entity.Property(e => e.CodEmpresa)
                    .IsRequired()
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.CodWhsbo)
                    .IsRequired()
                    .HasColumnName("Cod_WHSBO")
                    .HasMaxLength(10);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<Sr3Eina>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SR3_EINA");

                entity.Property(e => e.Idnlf)
                    .IsRequired()
                    .HasColumnName("IDNLF")
                    .HasMaxLength(100);

                entity.Property(e => e.Mandt)
                    .IsRequired()
                    .HasColumnName("MANDT")
                    .HasMaxLength(3);

                entity.Property(e => e.Matnr)
                    .IsRequired()
                    .HasColumnName("MATNR")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<Sr3Lagp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SR3_LAGP");

                entity.Property(e => e.Anzle)
                    .HasColumnName("ANZLE")
                    .HasColumnType("decimal(9, 3)");

                entity.Property(e => e.Anzqu)
                    .HasColumnName("ANZQU")
                    .HasColumnType("decimal(7, 0)");

                entity.Property(e => e.Bdatu)
                    .IsRequired()
                    .HasColumnName("BDATU")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Brand)
                    .IsRequired()
                    .HasColumnName("BRAND")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Btanr)
                    .IsRequired()
                    .HasColumnName("BTANR")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Btaps)
                    .IsRequired()
                    .HasColumnName("BTAPS")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Bzeit)
                    .IsRequired()
                    .HasColumnName("BZEIT")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Gewei)
                    .IsRequired()
                    .HasColumnName("GEWEI")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Idatu)
                    .IsRequired()
                    .HasColumnName("IDATU")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Ivivo)
                    .IsRequired()
                    .HasColumnName("IVIVO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Ivnum)
                    .IsRequired()
                    .HasColumnName("IVNUM")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Ivpos)
                    .IsRequired()
                    .HasColumnName("IVPOS")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Kober)
                    .IsRequired()
                    .HasColumnName("KOBER")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Kzdyn)
                    .IsRequired()
                    .HasColumnName("KZDYN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Kzinv)
                    .IsRequired()
                    .HasColumnName("KZINV")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Kzler)
                    .IsRequired()
                    .HasColumnName("KZLER")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Kzvol)
                    .IsRequired()
                    .HasColumnName("KZVOL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Laedt)
                    .IsRequired()
                    .HasColumnName("LAEDT")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Lgber)
                    .IsRequired()
                    .HasColumnName("LGBER")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Lgewi)
                    .HasColumnName("LGEWI")
                    .HasColumnType("decimal(11, 3)");

                entity.Property(e => e.Lgnum)
                    .IsRequired()
                    .HasColumnName("LGNUM")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Lgpla)
                    .IsRequired()
                    .HasColumnName("LGPLA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Lgtyp)
                    .IsRequired()
                    .HasColumnName("LGTYP")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Lkapv)
                    .HasColumnName("LKAPV")
                    .HasColumnType("decimal(11, 3)");

                entity.Property(e => e.Lptyp)
                    .IsRequired()
                    .HasColumnName("LPTYP")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Lzone)
                    .HasColumnName("LZONE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Mandt)
                    .IsRequired()
                    .HasColumnName("MANDT")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Maxle)
                    .HasColumnName("MAXLE")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.Maxqu)
                    .HasColumnName("MAXQU")
                    .HasColumnType("decimal(7, 0)");

                entity.Property(e => e.Mgewi)
                    .HasColumnName("MGEWI")
                    .HasColumnType("decimal(11, 3)");

                entity.Property(e => e.Plauf)
                    .IsRequired()
                    .HasColumnName("PLAUF")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Rdatu)
                    .IsRequired()
                    .HasColumnName("RDATU")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Reihf)
                    .IsRequired()
                    .HasColumnName("REIHF")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Rkapv)
                    .HasColumnName("RKAPV")
                    .HasColumnType("decimal(11, 3)");

                entity.Property(e => e.Rzeit)
                    .IsRequired()
                    .HasColumnName("RZEIT")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Skzsa)
                    .IsRequired()
                    .HasColumnName("SKZSA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Skzse)
                    .IsRequired()
                    .HasColumnName("SKZSE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Skzsi)
                    .IsRequired()
                    .HasColumnName("SKZSI")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Skzua)
                    .IsRequired()
                    .HasColumnName("SKZUA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Skzue)
                    .IsRequired()
                    .HasColumnName("SKZUE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Sorlp)
                    .IsRequired()
                    .HasColumnName("SORLP")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Spgru)
                    .IsRequired()
                    .HasColumnName("SPGRU")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Uname)
                    .IsRequired()
                    .HasColumnName("UNAME")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Verif)
                    .IsRequired()
                    .HasColumnName("VERIF")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Xcord)
                    .HasColumnName("XCORD")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Ycord)
                    .HasColumnName("YCORD")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Zcord)
                    .HasColumnName("ZCORD")
                    .HasColumnType("decimal(10, 3)");
            });

            modelBuilder.Entity<Sr3Lfa1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SR3_LFA1");

                entity.Property(e => e.Actss)
                    .IsRequired()
                    .HasColumnName("ACTSS")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Adrnr)
                    .IsRequired()
                    .HasColumnName("ADRNR")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Alc)
                    .HasColumnName("ALC")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Anred)
                    .IsRequired()
                    .HasColumnName("ANRED")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Bahns)
                    .IsRequired()
                    .HasColumnName("BAHNS")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Bbbnr)
                    .IsRequired()
                    .HasColumnName("BBBNR")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Bbsnr)
                    .IsRequired()
                    .HasColumnName("BBSNR")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Begru)
                    .IsRequired()
                    .HasColumnName("BEGRU")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Brsch)
                    .IsRequired()
                    .HasColumnName("BRSCH")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Bubkz)
                    .IsRequired()
                    .HasColumnName("BUBKZ")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CarrierConf)
                    .HasColumnName("CARRIER_CONF")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Confs)
                    .IsRequired()
                    .HasColumnName("CONFS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Datlt)
                    .IsRequired()
                    .HasColumnName("DATLT")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Dlgrp)
                    .IsRequired()
                    .HasColumnName("DLGRP")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Dtams)
                    .IsRequired()
                    .HasColumnName("DTAMS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Dtaws)
                    .IsRequired()
                    .HasColumnName("DTAWS")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Duefl)
                    .IsRequired()
                    .HasColumnName("DUEFL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Emnfr)
                    .IsRequired()
                    .HasColumnName("EMNFR")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Erdat)
                    .IsRequired()
                    .HasColumnName("ERDAT")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Ernam)
                    .IsRequired()
                    .HasColumnName("ERNAM")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Esrnr)
                    .IsRequired()
                    .HasColumnName("ESRNR")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Fiskn)
                    .IsRequired()
                    .HasColumnName("FISKN")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Fisku)
                    .HasColumnName("FISKU")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Fityp)
                    .IsRequired()
                    .HasColumnName("FITYP")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Gbdat)
                    .IsRequired()
                    .HasColumnName("GBDAT")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Gbort)
                    .IsRequired()
                    .HasColumnName("GBORT")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Ipisp)
                    .IsRequired()
                    .HasColumnName("IPISP")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.J1kfrepre)
                    .IsRequired()
                    .HasColumnName("J_1KFREPRE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.J1kftbus)
                    .IsRequired()
                    .HasColumnName("J_1KFTBUS")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.J1kftind)
                    .IsRequired()
                    .HasColumnName("J_1KFTIND")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.JScCapital)
                    .HasColumnName("J_SC_CAPITAL")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.JScCurrency)
                    .HasColumnName("J_SC_CURRENCY")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Konzs)
                    .IsRequired()
                    .HasColumnName("KONZS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Kraus)
                    .IsRequired()
                    .HasColumnName("KRAUS")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Ktock)
                    .IsRequired()
                    .HasColumnName("KTOCK")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Ktokk)
                    .IsRequired()
                    .HasColumnName("KTOKK")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Kunnr)
                    .IsRequired()
                    .HasColumnName("KUNNR")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Land1)
                    .IsRequired()
                    .HasColumnName("LAND1")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Lfurl)
                    .IsRequired()
                    .HasColumnName("LFURL")
                    .HasMaxLength(132)
                    .IsUnicode(false);

                entity.Property(e => e.Lifnr)
                    .IsRequired()
                    .HasColumnName("LIFNR")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Lnrza)
                    .IsRequired()
                    .HasColumnName("LNRZA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Loevm)
                    .IsRequired()
                    .HasColumnName("LOEVM")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Ltsna)
                    .IsRequired()
                    .HasColumnName("LTSNA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Lzone)
                    .IsRequired()
                    .HasColumnName("LZONE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Mandt)
                    .IsRequired()
                    .HasColumnName("MANDT")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Mcod1)
                    .IsRequired()
                    .HasColumnName("MCOD1")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Mcod2)
                    .IsRequired()
                    .HasColumnName("MCOD2")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Mcod3)
                    .IsRequired()
                    .HasColumnName("MCOD3")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Name1)
                    .IsRequired()
                    .HasColumnName("NAME1")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Name2)
                    .IsRequired()
                    .HasColumnName("NAME2")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Name3)
                    .IsRequired()
                    .HasColumnName("NAME3")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Name4)
                    .IsRequired()
                    .HasColumnName("NAME4")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Nodel)
                    .IsRequired()
                    .HasColumnName("NODEL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Ort01)
                    .IsRequired()
                    .HasColumnName("ORT01")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Ort02)
                    .IsRequired()
                    .HasColumnName("ORT02")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Pfach)
                    .IsRequired()
                    .HasColumnName("PFACH")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Pfort)
                    .IsRequired()
                    .HasColumnName("PFORT")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Plkal)
                    .IsRequired()
                    .HasColumnName("PLKAL")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PmtOffice)
                    .HasColumnName("PMT_OFFICE")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Podkzb)
                    .HasColumnName("PODKZB")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Profs)
                    .IsRequired()
                    .HasColumnName("PROFS")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Psofg)
                    .HasColumnName("PSOFG")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Psohs)
                    .HasColumnName("PSOHS")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Psois)
                    .HasColumnName("PSOIS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Pson1)
                    .HasColumnName("PSON1")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Pson2)
                    .HasColumnName("PSON2")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Pson3)
                    .HasColumnName("PSON3")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Psost)
                    .HasColumnName("PSOST")
                    .HasMaxLength(28)
                    .IsUnicode(false);

                entity.Property(e => e.Psotl)
                    .HasColumnName("PSOTL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Psovn)
                    .HasColumnName("PSOVN")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Pstl2)
                    .IsRequired()
                    .HasColumnName("PSTL2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Pstlz)
                    .IsRequired()
                    .HasColumnName("PSTLZ")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Qssys)
                    .IsRequired()
                    .HasColumnName("QSSYS")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Qssysdat)
                    .HasColumnName("QSSYSDAT")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Regio)
                    .IsRequired()
                    .HasColumnName("REGIO")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Regss)
                    .IsRequired()
                    .HasColumnName("REGSS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Revdb)
                    .IsRequired()
                    .HasColumnName("REVDB")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Scacd)
                    .IsRequired()
                    .HasColumnName("SCACD")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SchedulingType)
                    .HasColumnName("SCHEDULING_TYPE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Sexkz)
                    .IsRequired()
                    .HasColumnName("SEXKZ")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Sfrgr)
                    .IsRequired()
                    .HasColumnName("SFRGR")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Sortl)
                    .IsRequired()
                    .HasColumnName("SORTL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Sperm)
                    .IsRequired()
                    .HasColumnName("SPERM")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Sperq)
                    .IsRequired()
                    .HasColumnName("SPERQ")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Sperr)
                    .IsRequired()
                    .HasColumnName("SPERR")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Sperz)
                    .IsRequired()
                    .HasColumnName("SPERZ")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Spras)
                    .IsRequired()
                    .HasColumnName("SPRAS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StagingTime)
                    .HasColumnName("STAGING_TIME")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Stcd1)
                    .IsRequired()
                    .HasColumnName("STCD1")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Stcd2)
                    .IsRequired()
                    .HasColumnName("STCD2")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Stcd3)
                    .IsRequired()
                    .HasColumnName("STCD3")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Stcd4)
                    .IsRequired()
                    .HasColumnName("STCD4")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Stcdt)
                    .IsRequired()
                    .HasColumnName("STCDT")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Stceg)
                    .IsRequired()
                    .HasColumnName("STCEG")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Stenr)
                    .HasColumnName("STENR")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Stgdl)
                    .IsRequired()
                    .HasColumnName("STGDL")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Stkza)
                    .IsRequired()
                    .HasColumnName("STKZA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Stkzn)
                    .IsRequired()
                    .HasColumnName("STKZN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Stkzu)
                    .IsRequired()
                    .HasColumnName("STKZU")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Stras)
                    .IsRequired()
                    .HasColumnName("STRAS")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.SubmiRelevant)
                    .HasColumnName("SUBMI_RELEVANT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Taxbs)
                    .IsRequired()
                    .HasColumnName("TAXBS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Telbx)
                    .IsRequired()
                    .HasColumnName("TELBX")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Telf1)
                    .IsRequired()
                    .HasColumnName("TELF1")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Telf2)
                    .IsRequired()
                    .HasColumnName("TELF2")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Telfx)
                    .IsRequired()
                    .HasColumnName("TELFX")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.Teltx)
                    .IsRequired()
                    .HasColumnName("TELTX")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Telx1)
                    .IsRequired()
                    .HasColumnName("TELX1")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TransportChain)
                    .HasColumnName("TRANSPORT_CHAIN")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Txjcd)
                    .IsRequired()
                    .HasColumnName("TXJCD")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Updat)
                    .IsRequired()
                    .HasColumnName("UPDAT")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Uptim)
                    .IsRequired()
                    .HasColumnName("UPTIM")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Vbund)
                    .IsRequired()
                    .HasColumnName("VBUND")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Werkr)
                    .IsRequired()
                    .HasColumnName("WERKR")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Werks)
                    .IsRequired()
                    .HasColumnName("WERKS")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Xcpdk)
                    .IsRequired()
                    .HasColumnName("XCPDK")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Xlfza)
                    .IsRequired()
                    .HasColumnName("XLFZA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Xzemp)
                    .IsRequired()
                    .HasColumnName("XZEMP")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sr3Lqua>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SR3_LQUA");

                entity.HasIndex(e => new { e.Matnr, e.Bestq, e.Lgtyp, e.Lgpla, e.Ausme, e.Mandt, e.Gesme })
                    .HasName("Idx_SR3_LQUA_CL1");

                entity.Property(e => e.Adatu)
                    .IsRequired()
                    .HasColumnName("ADATU")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Ausme)
                    .HasColumnName("AUSME")
                    .HasColumnType("decimal(13, 3)");

                entity.Property(e => e.Azeit)
                    .IsRequired()
                    .HasColumnName("AZEIT")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Bdatu)
                    .IsRequired()
                    .HasColumnName("BDATU")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Benum)
                    .IsRequired()
                    .HasColumnName("BENUM")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Bestq)
                    .IsRequired()
                    .HasColumnName("BESTQ")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Betyp)
                    .IsRequired()
                    .HasColumnName("BETYP")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Btanr)
                    .IsRequired()
                    .HasColumnName("BTANR")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Btaps)
                    .IsRequired()
                    .HasColumnName("BTAPS")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Bzeit)
                    .IsRequired()
                    .HasColumnName("BZEIT")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Charg)
                    .IsRequired()
                    .HasColumnName("CHARG")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Edatu)
                    .IsRequired()
                    .HasColumnName("EDATU")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Einme)
                    .HasColumnName("EINME")
                    .HasColumnType("decimal(13, 3)");

                entity.Property(e => e.Ezeit)
                    .IsRequired()
                    .HasColumnName("EZEIT")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Gesme)
                    .HasColumnName("GESME")
                    .HasColumnType("decimal(13, 3)");

                entity.Property(e => e.Gewei)
                    .IsRequired()
                    .HasColumnName("GEWEI")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Idatu)
                    .HasColumnName("IDATU")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Ivnum)
                    .IsRequired()
                    .HasColumnName("IVNUM")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Ivpos)
                    .IsRequired()
                    .HasColumnName("IVPOS")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Kober)
                    .IsRequired()
                    .HasColumnName("KOBER")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Kzhuq)
                    .HasColumnName("KZHUQ")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Lenum)
                    .IsRequired()
                    .HasColumnName("LENUM")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Letyp)
                    .IsRequired()
                    .HasColumnName("LETYP")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Lgnum)
                    .IsRequired()
                    .HasColumnName("LGNUM")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Lgort)
                    .IsRequired()
                    .HasColumnName("LGORT")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Lgpla)
                    .IsRequired()
                    .HasColumnName("LGPLA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Lgtyp)
                    .IsRequired()
                    .HasColumnName("LGTYP")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Lqnum)
                    .IsRequired()
                    .HasColumnName("LQNUM")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Mandt)
                    .IsRequired()
                    .HasColumnName("MANDT")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Matnr)
                    .IsRequired()
                    .HasColumnName("MATNR")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Meins)
                    .IsRequired()
                    .HasColumnName("MEINS")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Mgewi)
                    .HasColumnName("MGEWI")
                    .HasColumnType("decimal(11, 3)");

                entity.Property(e => e.Plpos)
                    .IsRequired()
                    .HasColumnName("PLPOS")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Posnr)
                    .HasColumnName("POSNR")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Qkapv)
                    .HasColumnName("QKAPV")
                    .HasColumnType("decimal(11, 3)");

                entity.Property(e => e.Qplos)
                    .IsRequired()
                    .HasColumnName("QPLOS")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Skzsa)
                    .IsRequired()
                    .HasColumnName("SKZSA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Skzse)
                    .IsRequired()
                    .HasColumnName("SKZSE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Skzsi)
                    .IsRequired()
                    .HasColumnName("SKZSI")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Skzua)
                    .IsRequired()
                    .HasColumnName("SKZUA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Skzue)
                    .IsRequired()
                    .HasColumnName("SKZUE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Sobkz)
                    .IsRequired()
                    .HasColumnName("SOBKZ")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Sonum)
                    .IsRequired()
                    .HasColumnName("SONUM")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Spgru)
                    .IsRequired()
                    .HasColumnName("SPGRU")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Tbnum)
                    .IsRequired()
                    .HasColumnName("TBNUM")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Trame)
                    .HasColumnName("TRAME")
                    .HasColumnType("decimal(13, 3)");

                entity.Property(e => e.Vbeln)
                    .HasColumnName("VBELN")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Verme)
                    .HasColumnName("VERME")
                    .HasColumnType("decimal(13, 3)");

                entity.Property(e => e.Vfdat)
                    .IsRequired()
                    .HasColumnName("VFDAT")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Virgo)
                    .IsRequired()
                    .HasColumnName("VIRGO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Wdatu)
                    .IsRequired()
                    .HasColumnName("WDATU")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Wenum)
                    .IsRequired()
                    .HasColumnName("WENUM")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Wepos)
                    .IsRequired()
                    .HasColumnName("WEPOS")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Werks)
                    .IsRequired()
                    .HasColumnName("WERKS")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Zdatu)
                    .IsRequired()
                    .HasColumnName("ZDATU")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Zeugn)
                    .IsRequired()
                    .HasColumnName("ZEUGN")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sr3Marm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SR3_MARM");

                entity.Property(e => e.Atinn)
                    .IsRequired()
                    .HasColumnName("ATINN")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BflmeMarm)
                    .HasColumnName("BFLME_MARM")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Breit)
                    .HasColumnName("BREIT")
                    .HasColumnType("decimal(13, 3)");

                entity.Property(e => e.Brgew)
                    .HasColumnName("BRGEW")
                    .HasColumnType("decimal(13, 3)");

                entity.Property(e => e.Capause)
                    .HasColumnName("CAPAUSE")
                    .HasColumnType("decimal(15, 3)");

                entity.Property(e => e.Ean11)
                    .IsRequired()
                    .HasColumnName("EAN11")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Eannr)
                    .IsRequired()
                    .HasColumnName("EANNR")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Gewei)
                    .IsRequired()
                    .HasColumnName("GEWEI")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.GtinVariant)
                    .HasColumnName("GTIN_VARIANT")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Hoehe)
                    .HasColumnName("HOEHE")
                    .HasColumnType("decimal(13, 3)");

                entity.Property(e => e.Kzwso)
                    .IsRequired()
                    .HasColumnName("KZWSO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Laeng)
                    .HasColumnName("LAENG")
                    .HasColumnType("decimal(13, 3)");

                entity.Property(e => e.Mandt)
                    .IsRequired()
                    .HasColumnName("MANDT")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Matnr)
                    .IsRequired()
                    .HasColumnName("MATNR")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.MaxStack).HasColumnName("MAX_STACK");

                entity.Property(e => e.Meabm)
                    .IsRequired()
                    .HasColumnName("MEABM")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Meinh)
                    .IsRequired()
                    .HasColumnName("MEINH")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Mesrt)
                    .IsRequired()
                    .HasColumnName("MESRT")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Mesub)
                    .IsRequired()
                    .HasColumnName("MESUB")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Msehi)
                    .IsRequired()
                    .HasColumnName("MSEHI")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NestFtr)
                    .HasColumnName("NEST_FTR")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Numtp)
                    .IsRequired()
                    .HasColumnName("NUMTP")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Ty2tq)
                    .HasColumnName("TY2TQ")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Umren)
                    .HasColumnName("UMREN")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.Umrez)
                    .HasColumnName("UMREZ")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.Voleh)
                    .IsRequired()
                    .HasColumnName("VOLEH")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Volum)
                    .HasColumnName("VOLUM")
                    .HasColumnType("decimal(13, 3)");

                entity.Property(e => e.Xbeww)
                    .IsRequired()
                    .HasColumnName("XBEWW")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Xfhdw)
                    .IsRequired()
                    .HasColumnName("XFHDW")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAccionPedido>(entity =>
            {
                entity.HasKey(e => new { e.CodTipo, e.NumDocumento, e.Idx })
                    .HasName("PK_AccionPedido");

                entity.ToTable("Tbl_AccionPedido");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.NumDocumento)
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.CodTipoAcc).HasColumnName("Cod_TipoAcc");

                entity.Property(e => e.Comentario)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<TblAnalisisPedido>(entity =>
            {
                entity.HasKey(e => new { e.CodTipo, e.NumDocumento, e.CodCentroDist, e.Sku })
                    .HasName("PK_AnalisisPedido");

                entity.ToTable("Tbl_AnalisisPedido");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.NumDocumento)
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.CodCentroDist)
                    .HasColumnName("Cod_CentroDist")
                    .HasMaxLength(10);

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TblAnulacionDoc>(entity =>
            {
                entity.HasKey(e => new { e.IdCaja, e.Transaccion });

                entity.ToTable("Tbl_AnulacionDoc", "pos");

                entity.Property(e => e.IdCaja)
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(10);

                entity.Property(e => e.CodRazon).HasColumnName("Cod_Razon");

                entity.Property(e => e.Descripcion).HasColumnType("text");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<TblAplicacion>(entity =>
            {
                entity.HasKey(e => e.CodAplicacion)
                    .HasName("PK__Tbl_Aplicacion__5165187F");

                entity.ToTable("Tbl_Aplicacion");

                entity.Property(e => e.CodAplicacion)
                    .HasColumnName("Cod_Aplicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TipoAplicacion)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblAreaDistCentro>(entity =>
            {
                entity.HasKey(e => new { e.CodAreaDist, e.CodCentroDist })
                    .HasName("PK_AreaDistTienda");

                entity.ToTable("Tbl_AreaDistCentro");

                entity.Property(e => e.CodAreaDist)
                    .HasColumnName("Cod_AreaDist")
                    .HasMaxLength(10);

                entity.Property(e => e.CodCentroDist)
                    .HasColumnName("Cod_CentroDist")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<TblArticulo>(entity =>
            {
                entity.HasKey(e => e.Sku)
                    .IsClustered(false);

                entity.ToTable("Tbl_Articulo");

                entity.HasIndex(e => new { e.Sku, e.CodEmpresa })
                    .HasName("Idx_Tbl_Articulo_CL2");

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Categoria)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodEmpresa)
                    .IsRequired()
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.CodGrupo)
                    .HasColumnName("Cod_Grupo")
                    .HasMaxLength(20);

                entity.Property(e => e.CodGrupoMarca).HasColumnName("Cod_GrupoMarca");

                entity.Property(e => e.CodMarca).HasColumnName("Cod_Marca");

                entity.Property(e => e.Creacion).HasColumnType("datetime");

                entity.Property(e => e.Foto)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Modelo).HasMaxLength(100);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblArticulo1>(entity =>
            {
                entity.HasKey(e => e.Sku)
                    .IsClustered(false);

                entity.ToTable("Tbl_Articulo", "pos");

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodGrupo)
                    .HasColumnName("Cod_Grupo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodProveedor)
                    .HasColumnName("Cod_Proveedor")
                    .HasMaxLength(15);

                entity.Property(e => e.Creacion).HasColumnType("datetime");

                entity.Property(e => e.Foto)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Garantia)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Mensaje)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ModoVenta)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblArticuloAct>(entity =>
            {
                entity.HasKey(e => e.Sku);

                entity.ToTable("Tbl_ArticuloAct", "pos");

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaAct).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblArticuloAutoConf>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_ArticuloAutoConf");

                entity.Property(e => e.CodCentroDist)
                    .IsRequired()
                    .HasColumnName("Cod_CentroDist")
                    .HasMaxLength(25);

                entity.Property(e => e.IdUbicacion)
                    .IsRequired()
                    .HasColumnName("ID_Ubicacion")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblArticuloConsignado>(entity =>
            {
                entity.HasKey(e => e.Sku);

                entity.ToTable("Tbl_ArticuloConsignado", "pos");

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(18);

                entity.Property(e => e.Proveedor)
                    .IsRequired()
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<TblArticuloDef>(entity =>
            {
                entity.HasKey(e => e.Sku);

                entity.ToTable("Tbl_ArticuloDef", "pos");

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(20);

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblArticuloEcom>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_articuloEcom");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblArticuloEcommerce>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_ArticuloECommerce");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblArticuloGrupo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_ArticuloGrupo");

                entity.HasIndex(e => e.Sku)
                    .HasName("sku")
                    .IsClustered();

                entity.HasIndex(e => new { e.CodEmpresa, e.CodGrupo })
                    .HasName("cod_grupo_cod_empresa");

                entity.Property(e => e.CodEmpresa)
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.CodGrupo)
                    .HasColumnName("Cod_Grupo")
                    .HasMaxLength(20);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblArticuloGrupo1>(entity =>
            {
                entity.HasKey(e => new { e.Sku, e.CodGrupo });

                entity.ToTable("Tbl_ArticuloGrupo", "pos");

                entity.Property(e => e.Sku)
                    .HasColumnName("sku")
                    .HasMaxLength(20);

                entity.Property(e => e.CodGrupo)
                    .HasColumnName("cod_grupo")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TblArticuloImpuesto>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_ArticuloImpuesto");

                entity.HasIndex(e => new { e.ValImpuesto, e.TipoProd, e.Sku })
                    .HasName("<sku_Include_ValImpuesto,TipoProd>");

                entity.Property(e => e.Impuesto)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.TipoProd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ValImpuesto).HasColumnType("money");
            });

            modelBuilder.Entity<TblArticuloLocal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_ArticuloLocal");

                entity.HasIndex(e => e.Sku)
                    .HasName("Idx_ArticuloLocal");

                entity.Property(e => e.CodProveedor)
                    .HasColumnName("Cod_Proveedor")
                    .HasMaxLength(25);

                entity.Property(e => e.Modelo).HasMaxLength(50);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblArticuloMedida>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_ArticuloMedida");

                entity.Property(e => e.CodEmpresa)
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.CodMedida)
                    .IsRequired()
                    .HasColumnName("Cod_Medida")
                    .HasMaxLength(10);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblArticuloPromo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_ArticuloPromo");

                entity.Property(e => e.Al).HasColumnType("datetime");

                entity.Property(e => e.CodPromo)
                    .IsRequired()
                    .HasColumnName("Cod_Promo")
                    .HasMaxLength(25);

                entity.Property(e => e.Del).HasColumnType("datetime");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblArticuloServ>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_ArticuloServ");

                entity.Property(e => e.PermiteDev)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblArticuloSocioNeg>(entity =>
            {
                entity.HasKey(e => new { e.CodSocio, e.Skusocio, e.Sku });

                entity.ToTable("Tbl_ArticuloSocioNeg", "pos");

                entity.Property(e => e.CodSocio)
                    .HasColumnName("Cod_Socio")
                    .HasMaxLength(25);

                entity.Property(e => e.Skusocio)
                    .HasColumnName("SKUSocio")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Descripcion).HasMaxLength(100);

                entity.Property(e => e.OpDirecto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Pdescuento)
                    .HasColumnName("PDescuento")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Valor).HasColumnType("money");
            });

            modelBuilder.Entity<TblArticuloTregalo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_ArticuloTRegalo");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.VentaEc)
                    .HasColumnName("VentaEC")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblAsueto>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Asueto");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblAuditorActivo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_AuditorActivo");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("Id_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.NumDocumento)
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblAutorizadorTarjeta>(entity =>
            {
                entity.HasKey(e => e.CodAutorizador);

                entity.ToTable("Tbl_AutorizadorTarjeta", "pos");

                entity.Property(e => e.CodAutorizador)
                    .HasColumnName("Cod_Autorizador")
                    .ValueGeneratedNever();

                entity.Property(e => e.CodSap)
                    .IsRequired()
                    .HasColumnName("CodSAP")
                    .HasMaxLength(4);

                entity.Property(e => e.CodSapcuota)
                    .HasColumnName("CodSAPCuota")
                    .HasMaxLength(5);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.TextoCompra).HasColumnType("text");

                entity.Property(e => e.TextoConFirma).HasColumnType("text");

                entity.Property(e => e.TextoSinFirma).HasColumnType("text");

                entity.Property(e => e.Valormax)
                    .HasColumnName("valormax")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<TblBanco>(entity =>
            {
                entity.HasKey(e => e.CodBanco);

                entity.ToTable("Tbl_Banco", "pos");

                entity.Property(e => e.CodBanco)
                    .HasColumnName("Cod_Banco")
                    .ValueGeneratedNever();

                entity.Property(e => e.NomCorto)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblBarras>(entity =>
            {
                entity.HasKey(e => new { e.Sku, e.Barras });

                entity.ToTable("Tbl_Barras");

                entity.HasIndex(e => e.Barras)
                    .HasName("IX_Tbl_Barras");

                entity.HasIndex(e => e.Sku)
                    .HasName("IX_Tbl_Barras_1");

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(20);

                entity.Property(e => e.Barras).HasMaxLength(16);

                entity.Property(e => e.Principal)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TrasladadoSap)
                    .HasColumnName("TrasladadoSAP")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblBarras1>(entity =>
            {
                entity.HasKey(e => e.Barras)
                    .IsClustered(false);

                entity.ToTable("Tbl_Barras", "pos");

                entity.Property(e => e.Barras).HasMaxLength(16);

                entity.Property(e => e.Principal)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TblBloqGrupoArticulo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_BloqGrupoArticulo");

                entity.Property(e => e.CodEmpresa)
                    .IsRequired()
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.CodGrupo)
                    .IsRequired()
                    .HasColumnName("Cod_Grupo")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TblBodega>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Bodega");

                entity.Property(e => e.CodBodega)
                    .IsRequired()
                    .HasColumnName("Cod_Bodega")
                    .HasMaxLength(10);

                entity.Property(e => e.CodWhsbo)
                    .HasColumnName("Cod_WHSBO")
                    .HasMaxLength(10);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.IdvtexDock)
                    .HasColumnName("IDVTex_Dock")
                    .HasMaxLength(25);

                entity.Property(e => e.IdvtexWs)
                    .HasColumnName("IDVTex_WS")
                    .HasMaxLength(25);

                entity.Property(e => e.ImpresoraFact).HasMaxLength(25);

                entity.Property(e => e.ImpresoraGuia).HasMaxLength(25);

                entity.Property(e => e.ImpresoraPicking).HasMaxLength(25);

                entity.Property(e => e.ModoIncompletos)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TipoCd).HasColumnName("TipoCD");
            });

            modelBuilder.Entity<TblBonoArticulo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_BonoArticulo");

                entity.Property(e => e.Al).HasColumnType("datetime");

                entity.Property(e => e.Binner).HasColumnName("BInner");

                entity.Property(e => e.Bmaster).HasColumnName("BMaster");

                entity.Property(e => e.Cinner).HasColumnName("CInner");

                entity.Property(e => e.Cmaster).HasColumnName("CMaster");

                entity.Property(e => e.CodBono)
                    .IsRequired()
                    .HasColumnName("Cod_Bono")
                    .HasMaxLength(25);

                entity.Property(e => e.Del).HasColumnType("datetime");

                entity.Property(e => e.Exclusiones).HasColumnType("text");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblCaja>(entity =>
            {
                entity.HasKey(e => e.IdCaja);

                entity.ToTable("Tbl_Caja", "pos");

                entity.Property(e => e.IdCaja)
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(15);

                entity.Property(e => e.CodPerfil).HasColumnName("Cod_Perfil");

                entity.Property(e => e.CodTienda)
                    .HasColumnName("Cod_Tienda")
                    .HasMaxLength(10);

                entity.Property(e => e.CorrelTrans).HasColumnName("Correl_Trans");

                entity.Property(e => e.DispositivoFel).HasColumnName("DispositivoFEL");

                entity.Property(e => e.IdxFel).HasColumnName("IdxFEL");

                entity.Property(e => e.Modelo).HasMaxLength(50);

                entity.Property(e => e.Scanner)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.Serie).HasMaxLength(50);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Version).HasMaxLength(25);
            });

            modelBuilder.Entity<TblCajaAct>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_CajaAct", "pos");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.FechaInicio).HasColumnType("datetime");

                entity.Property(e => e.IdCaja)
                    .IsRequired()
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(15);

                entity.Property(e => e.IdTarea)
                    .IsRequired()
                    .HasColumnName("ID_Tarea")
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblCajaTc>(entity =>
            {
                entity.HasKey(e => new { e.IdCaja, e.CodAutorizador, e.Terminal });

                entity.ToTable("Tbl_CajaTC", "pos");

                entity.Property(e => e.IdCaja)
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(10);

                entity.Property(e => e.CodAutorizador).HasColumnName("Cod_Autorizador");

                entity.Property(e => e.Terminal).HasMaxLength(50);

                entity.Property(e => e.Afiliacion).HasMaxLength(50);

                entity.Property(e => e.CodServicio)
                    .HasColumnName("Cod_Servicio")
                    .HasMaxLength(20);

                entity.Property(e => e.CodTransaccion).HasColumnName("cod_transaccion");

                entity.Property(e => e.Modo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblCambioSoft>(entity =>
            {
                entity.HasKey(e => new { e.Modulo, e.Version, e.NoArch });

                entity.ToTable("Tbl_CambioSoft");

                entity.Property(e => e.Modulo).HasMaxLength(15);

                entity.Property(e => e.Version).HasMaxLength(25);

                entity.Property(e => e.Destino)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Funcion)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Origen)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblCierrePedido>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_CierrePedido");

                entity.Property(e => e.CodRazon).HasColumnName("Cod_Razon");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaEcom).HasColumnType("datetime");

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Razon)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblCierreReclamo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_CierreReclamo");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Resolucion)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblCliente>(entity =>
            {
                entity.HasKey(e => e.Idtributario);

                entity.ToTable("Tbl_Cliente", "pos");

                entity.Property(e => e.Idtributario)
                    .HasColumnName("IDTributario")
                    .HasMaxLength(25);

                entity.Property(e => e.CodListaPrecios).HasColumnName("Cod_ListaPrecios");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblClienteComodin>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_ClienteComodin");

                entity.Property(e => e.CodCliente)
                    .HasColumnName("Cod_Cliente")
                    .HasMaxLength(100);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(100);

                entity.Property(e => e.ModoIngreso).HasMaxLength(25);
            });

            modelBuilder.Entity<TblClienteIntSbo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_ClienteIntSBO");

                entity.Property(e => e.CodCliente)
                    .HasColumnName("Cod_Cliente")
                    .HasMaxLength(25);

                entity.Property(e => e.CodEmpCliente)
                    .HasColumnName("Cod_EmpCliente")
                    .HasMaxLength(10);

                entity.Property(e => e.CodEmpresa)
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.CodProveedor)
                    .HasColumnName("Cod_Proveedor")
                    .HasMaxLength(25);

                entity.Property(e => e.SerieFactSbo).HasColumnName("SerieFactSBO");

                entity.Property(e => e.WareHouse).HasMaxLength(10);
            });

            modelBuilder.Entity<TblClienteTarjeta>(entity =>
            {
                entity.HasKey(e => e.Idtributario);

                entity.ToTable("Tbl_ClienteTarjeta", "pos");

                entity.Property(e => e.Idtributario)
                    .HasColumnName("IDTributario")
                    .HasMaxLength(25);

                entity.Property(e => e.CodTipoTarjeta).HasColumnName("Cod_TipoTarjeta");

                entity.Property(e => e.IdAsociado)
                    .IsRequired()
                    .HasColumnName("ID_Asociado")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblClienteVend>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_ClienteVend");

                entity.Property(e => e.CodCliente)
                    .IsRequired()
                    .HasColumnName("Cod_Cliente")
                    .HasMaxLength(15);

                entity.Property(e => e.CodEmpresa)
                    .IsRequired()
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.IdPersonal)
                    .IsRequired()
                    .HasColumnName("ID_Personal")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<TblCodigoPostal>(entity =>
            {
                entity.HasKey(e => e.CodigoPostal)
                    .HasName("PK_CodigoPostal");

                entity.ToTable("Tbl_CodigoPostal");

                entity.Property(e => e.CodigoPostal).HasMaxLength(25);

                entity.Property(e => e.CodDepartamento).HasColumnName("Cod_Departamento");

                entity.Property(e => e.CodMunicipio).HasColumnName("Cod_Municipio");

                entity.Property(e => e.CodPais)
                    .IsRequired()
                    .HasColumnName("Cod_Pais")
                    .HasMaxLength(10);

                entity.Property(e => e.Zona)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblCombo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Combo");

                entity.Property(e => e.CodCombo)
                    .IsRequired()
                    .HasColumnName("Cod_Combo")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblCondicionPago>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_CondicionPago", "pos");

                entity.Property(e => e.CodCondicion).HasColumnName("Cod_Condicion");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblConversionDeptoEcom>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_ConversionDeptoECOM");

                entity.Property(e => e.CodDepartamento).HasColumnName("Cod_Departamento");

                entity.Property(e => e.CodPais)
                    .IsRequired()
                    .HasColumnName("Cod_Pais")
                    .HasMaxLength(5);

                entity.Property(e => e.IdPais)
                    .IsRequired()
                    .HasColumnName("ID_Pais")
                    .HasMaxLength(5);

                entity.Property(e => e.IdRegion).HasColumnName("ID_Region");
            });

            modelBuilder.Entity<TblCreditoEcom>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_CreditoECOM");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.DocEcom)
                    .HasColumnName("DocECOM")
                    .HasMaxLength(40);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaEcom)
                    .HasColumnName("FechaECOM")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaTregalo)
                    .HasColumnName("FechaTRegalo")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdUsuarioEcom)
                    .HasColumnName("ID_UsuarioECOM")
                    .HasMaxLength(40);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Valor).HasColumnType("money");
            });

            modelBuilder.Entity<TblCreditoLineaCliente>(entity =>
            {
                entity.HasKey(e => new { e.CodEmpresa, e.CodSocio })
                    .HasName("PK_CreditoLineaCliente");

                entity.ToTable("Tbl_CreditoLineaCliente");

                entity.Property(e => e.CodEmpresa)
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.CodSocio)
                    .HasColumnName("Cod_Socio")
                    .HasMaxLength(50);

                entity.Property(e => e.GiftCardId)
                    .IsRequired()
                    .HasColumnName("GiftCardID")
                    .HasMaxLength(100);

                entity.Property(e => e.RecemptionCode)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblDepartamento>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Departamento");

                entity.Property(e => e.CodDepartamento).HasColumnName("Cod_Departamento");

                entity.Property(e => e.CodPais)
                    .IsRequired()
                    .HasColumnName("Cod_Pais")
                    .HasMaxLength(5);

                entity.Property(e => e.NomCorto)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblDespiece>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Despiece");

                entity.Property(e => e.CodEmpresa)
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaCierre).HasColumnType("datetime");

                entity.Property(e => e.FechaRecepcion).HasColumnType("datetime");

                entity.Property(e => e.IdUbicacion)
                    .HasColumnName("ID_Ubicacion")
                    .HasMaxLength(25);

                entity.Property(e => e.IdUsrCierre)
                    .HasColumnName("ID_UsrCierre")
                    .HasMaxLength(40);

                entity.Property(e => e.NumDocFinal)
                    .HasColumnName("Num_DocFinal")
                    .HasMaxLength(25);

                entity.Property(e => e.NumDocPedido)
                    .HasColumnName("Num_DocPedido")
                    .HasMaxLength(25);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Serie).HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<TblDetAnulacionDoc>(entity =>
            {
                entity.HasKey(e => new { e.SerieDv, e.NumeroDv, e.TipoDv });

                entity.ToTable("TblDet_AnulacionDoc", "pos");

                entity.Property(e => e.SerieDv)
                    .HasColumnName("SerieDV")
                    .HasMaxLength(25);

                entity.Property(e => e.NumeroDv)
                    .HasColumnName("NumeroDV")
                    .HasMaxLength(25);

                entity.Property(e => e.TipoDv)
                    .HasColumnName("TipoDV")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodRazon).HasColumnName("Cod_Razon");

                entity.Property(e => e.Descripcion).HasColumnType("text");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdCaja)
                    .IsRequired()
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(10);

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<TblDetAportacion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_Aportacion", "pos");

                entity.Property(e => e.CodAportacion).HasColumnName("Cod_Aportacion");

                entity.Property(e => e.CodMoneda)
                    .HasColumnName("Cod_Moneda")
                    .HasMaxLength(5);

                entity.Property(e => e.IdCaja)
                    .IsRequired()
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(10);

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.Property(e => e.MontoOrg).HasColumnType("money");

                entity.Property(e => e.TipoCambio).HasColumnType("money");
            });

            modelBuilder.Entity<TblDetAutPago>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_AutPago", "pos");

                entity.Property(e => e.Banda)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdCaja)
                    .IsRequired()
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(10);

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(5);
            });

            modelBuilder.Entity<TblDetAutVenta>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_AutVenta", "pos");

                entity.Property(e => e.Banda)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdCaja)
                    .IsRequired()
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(10);

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblDetBonoArticulo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_BonoArticulo");

                entity.Property(e => e.CodBono)
                    .IsRequired()
                    .HasColumnName("Cod_Bono")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblDetCierreOperacion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_CierreOperacion", "pos");

                entity.Property(e => e.CodAsociado).HasColumnName("Cod_Asociado");

                entity.Property(e => e.CodForma).HasColumnName("Cod_Forma");

                entity.Property(e => e.CodMoneda)
                    .IsRequired()
                    .HasColumnName("Cod_Moneda")
                    .HasMaxLength(5);

                entity.Property(e => e.IdUsuarioAct)
                    .HasColumnName("ID_UsuarioAct")
                    .HasMaxLength(40);

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.Property(e => e.MontoAct).HasColumnType("money");

                entity.Property(e => e.MontoOrg).HasColumnType("money");

                entity.Property(e => e.NumOperacion)
                    .IsRequired()
                    .HasColumnName("Num_Operacion")
                    .HasMaxLength(25);

                entity.Property(e => e.TipoCambio).HasColumnType("money");
            });

            modelBuilder.Entity<TblDetCobro>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_Cobro", "pos");

                entity.Property(e => e.Afiliacion).HasMaxLength(25);

                entity.Property(e => e.CodBanco).HasColumnName("Cod_Banco");

                entity.Property(e => e.CodMoneda)
                    .HasColumnName("Cod_Moneda")
                    .HasMaxLength(5);

                entity.Property(e => e.Cuenta).HasMaxLength(50);

                entity.Property(e => e.Documento).HasMaxLength(100);

                entity.Property(e => e.Documento2).HasMaxLength(250);

                entity.Property(e => e.FechaVencimiento)
                    .HasColumnName("fechaVencimiento")
                    .HasMaxLength(10);

                entity.Property(e => e.IdCaja)
                    .IsRequired()
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(10);

                entity.Property(e => e.Identificacion).HasMaxLength(100);

                entity.Property(e => e.Propietario).HasMaxLength(50);
            });

            modelBuilder.Entity<TblDetComboSap>(entity =>
            {
                entity.HasKey(e => new { e.SkuGrupo, e.Sku });

                entity.ToTable("TblDet_ComboSAP", "pos");

                entity.Property(e => e.SkuGrupo)
                    .HasColumnName("SKU_Grupo")
                    .HasMaxLength(20);

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(20);

                entity.Property(e => e.Precio).HasColumnType("money");
            });

            modelBuilder.Entity<TblDetConteoInventario>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_ConteoInventario");

                entity.Property(e => e.Costo).HasColumnType("money");

                entity.Property(e => e.FechaConteo).HasColumnType("datetime");

                entity.Property(e => e.FechaReConteo).HasColumnType("datetime");

                entity.Property(e => e.IdUbicacion)
                    .HasColumnName("Id_Ubicacion")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdUsuarioConf)
                    .HasColumnName("ID_UsuarioConf")
                    .HasMaxLength(40);

                entity.Property(e => e.IdUsuarioCont)
                    .HasColumnName("ID_UsuarioCont")
                    .HasMaxLength(40);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblDetDescuento>(entity =>
            {
                entity.HasKey(e => new { e.CodTipo, e.Lista, e.Sku });

                entity.ToTable("TblDet_Descuento", "pos");

                entity.Property(e => e.CodTipo)
                    .HasColumnName("Cod_Tipo")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(20);

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.Usuario).HasMaxLength(50);
            });

            modelBuilder.Entity<TblDetDescuentoGrupo>(entity =>
            {
                entity.HasKey(e => new { e.CodTipo, e.Lista, e.CodGrupo });

                entity.ToTable("TblDet_DescuentoGrupo", "pos");

                entity.Property(e => e.CodTipo)
                    .HasColumnName("Cod_Tipo")
                    .HasMaxLength(25);

                entity.Property(e => e.CodGrupo)
                    .HasColumnName("Cod_Grupo")
                    .HasMaxLength(20);

                entity.Property(e => e.Usuario).HasMaxLength(50);
            });

            modelBuilder.Entity<TblDetDevolucion>(entity =>
            {
                entity.HasKey(e => new { e.IdCaja, e.Transaccion, e.Idx })
                    .HasName("PK__TblDet_Devolucio__1E5A75C5");

                entity.ToTable("TblDet_Devolucion", "pos");

                entity.Property(e => e.IdCaja)
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(10);

                entity.Property(e => e.CodEstado).HasColumnName("Cod_Estado");

                entity.Property(e => e.CodRazon).HasColumnName("Cod_Razon");

                entity.Property(e => e.DescPago).HasColumnType("money");

                entity.Property(e => e.DescRazon).HasMaxLength(100);

                entity.Property(e => e.FechaAuditoria).HasColumnType("datetime");

                entity.Property(e => e.FechaOrig).HasMaxLength(10);

                entity.Property(e => e.FfechaOrig)
                    .HasColumnName("FFechaOrig")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCajaOrig)
                    .HasColumnName("ID_CajaOrig")
                    .HasMaxLength(10);

                entity.Property(e => e.IdEvento)
                    .HasColumnName("ID_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.IdUsuarioAuditoria)
                    .HasColumnName("ID_UsuarioAuditoria")
                    .HasMaxLength(40);

                entity.Property(e => e.NumeroDv)
                    .HasColumnName("NumeroDV")
                    .HasMaxLength(25);

                entity.Property(e => e.NumeroOrig).HasMaxLength(25);

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.PrecioBase).HasColumnType("money");

                entity.Property(e => e.PrecioDesc).HasColumnType("money");

                entity.Property(e => e.PrecioFiscal).HasColumnType("money");

                entity.Property(e => e.ResolucionOrig).HasMaxLength(100);

                entity.Property(e => e.Scanner)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SerieDv)
                    .HasColumnName("SerieDV")
                    .HasMaxLength(25);

                entity.Property(e => e.SerieOrig).HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoDv)
                    .IsRequired()
                    .HasColumnName("TipoDV")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Uuidorig)
                    .HasColumnName("UUIDOrig")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblDetDevolucionManual>(entity =>
            {
                entity.HasKey(e => new { e.IdCaja, e.Transaccion, e.SerieDv, e.NumeroDv })
                    .HasName("PK__TblDet_D__3E5916797B264821");

                entity.ToTable("TblDet_DevolucionManual", "pos");

                entity.Property(e => e.IdCaja)
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(10);

                entity.Property(e => e.SerieDv)
                    .HasColumnName("SerieDV")
                    .HasMaxLength(10);

                entity.Property(e => e.NumeroDv).HasColumnName("NumeroDV");

                entity.Property(e => e.CodMotivo).HasColumnName("Cod_Motivo");

                entity.Property(e => e.Iva)
                    .HasColumnName("IVA")
                    .HasColumnType("money");

                entity.Property(e => e.NumeroDvorig).HasColumnName("NumeroDVOrig");

                entity.Property(e => e.Observacion).HasMaxLength(200);

                entity.Property(e => e.Serie).HasMaxLength(10);

                entity.Property(e => e.SerieDvorig)
                    .HasColumnName("SerieDVOrig")
                    .HasMaxLength(10);

                entity.Property(e => e.SubTotal).HasColumnType("money");

                entity.Property(e => e.TipoDocDv).HasColumnName("TipoDocDV");

                entity.Property(e => e.TipoDocDvorig).HasColumnName("TipoDocDVOrig");
            });

            modelBuilder.Entity<TblDetEntrega>(entity =>
            {
                entity.HasKey(e => new { e.NumEntrega, e.CodEmpresa, e.CodTipo, e.NumDocumento });

                entity.ToTable("TblDet_Entrega");

                entity.Property(e => e.NumEntrega)
                    .HasColumnName("Num_Entrega")
                    .HasMaxLength(20);

                entity.Property(e => e.CodEmpresa)
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.NumDocumento)
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblDetFactura>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_Factura");

                entity.HasIndex(e => new { e.CodTipoFinal, e.NumDocFinal })
                    .HasName("tblDet_Factura,Cod_TipoFinal,Num_DocFinal");

                entity.HasIndex(e => new { e.CodTipo, e.NumDocumento, e.LineaOrig, e.Sku, e.Skufact })
                    .HasName("idx_tipo_docto_linea_sku_skufact");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTipoFinal).HasColumnName("Cod_TipoFinal");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdAuditor)
                    .HasColumnName("ID_Auditor")
                    .HasMaxLength(40);

                entity.Property(e => e.IdUbicAuditoria)
                    .IsRequired()
                    .HasColumnName("ID_UbicAuditoria")
                    .HasMaxLength(25);

                entity.Property(e => e.NumDocFinal)
                    .HasColumnName("Num_DocFinal")
                    .HasMaxLength(50);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Skufact)
                    .HasColumnName("SKUFact")
                    .HasMaxLength(25);

                entity.Property(e => e.Tarima).HasMaxLength(50);
            });

            modelBuilder.Entity<TblDetFactura2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_Factura2");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTipoFinal).HasColumnName("Cod_TipoFinal");

                entity.Property(e => e.DocSap)
                    .HasColumnName("DocSAP")
                    .HasMaxLength(40);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaConfSap)
                    .HasColumnName("FechaConfSAP")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaSap)
                    .HasColumnName("FechaSAP")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaTarimaSap)
                    .HasColumnName("FechaTarimaSAP")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdAuditor)
                    .HasColumnName("ID_Auditor")
                    .HasMaxLength(40);

                entity.Property(e => e.IdUbicAuditoria)
                    .IsRequired()
                    .HasColumnName("ID_UbicAuditoria")
                    .HasMaxLength(25);

                entity.Property(e => e.NumDocFinal)
                    .HasColumnName("Num_DocFinal")
                    .HasMaxLength(50);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Skufact)
                    .HasColumnName("SKUFact")
                    .HasMaxLength(25);

                entity.Property(e => e.Tarima).HasMaxLength(50);
            });

            modelBuilder.Entity<TblDetFacturaAnulada>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_FacturaAnulada");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTipoFinal).HasColumnName("Cod_TipoFinal");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdAuditor)
                    .HasColumnName("ID_Auditor")
                    .HasMaxLength(40);

                entity.Property(e => e.IdUbicReingreso)
                    .IsRequired()
                    .HasColumnName("ID_UbicReingreso")
                    .HasMaxLength(25);

                entity.Property(e => e.NumDocFinal)
                    .HasColumnName("Num_DocFinal")
                    .HasMaxLength(50);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Skufact)
                    .HasColumnName("SKUFact")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblDetFacturaCs>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_FacturaCS");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTipoFinal).HasColumnName("Cod_TipoFinal");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdUbicReparacion)
                    .IsRequired()
                    .HasColumnName("ID_UbicReparacion")
                    .HasMaxLength(25);

                entity.Property(e => e.NumDocFinal)
                    .HasColumnName("Num_DocFinal")
                    .HasMaxLength(50);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.PrecioBase).HasColumnType("money");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Skufact)
                    .HasColumnName("SKUFact")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblDetFacturaEnvio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_FacturaEnvio");

                entity.HasIndex(e => new { e.CodTipo, e.NumDocumento, e.LineaOrig })
                    .HasName("idx_tipo_docto_linea");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaEnt).HasColumnType("datetime");

                entity.Property(e => e.FechaImp).HasColumnType("datetime");

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("ID_Envio")
                    .HasMaxLength(25);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Recibio).HasMaxLength(250);
            });

            modelBuilder.Entity<TblDetFacturaRech>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_FacturaRech");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdAuditor)
                    .HasColumnName("ID_Auditor")
                    .HasMaxLength(40);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Skufact)
                    .HasColumnName("SKUFact")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblDetGrupoMarca>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_GrupoMarca");

                entity.Property(e => e.CodGrupo).HasColumnName("Cod_Grupo");

                entity.Property(e => e.CodMarca).HasColumnName("Cod_Marca");
            });

            modelBuilder.Entity<TblDetListaPrecios>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_ListaPrecios");

                entity.HasIndex(e => new { e.Sku, e.CodLista })
                    .HasName("cod_lista_sku");

                entity.Property(e => e.CodLista).HasColumnName("Cod_Lista");

                entity.Property(e => e.CodMoneda)
                    .HasColumnName("Cod_Moneda")
                    .HasMaxLength(3);

                entity.Property(e => e.Factor).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TblDetListaPrecios1>(entity =>
            {
                entity.HasKey(e => new { e.Sku, e.CodLista });

                entity.ToTable("TblDet_ListaPrecios", "pos");

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(20);

                entity.Property(e => e.CodLista).HasColumnName("Cod_Lista");

                entity.Property(e => e.Precio).HasColumnType("money");
            });

            modelBuilder.Entity<TblDetListaPreciosEspecial>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_ListaPreciosEspecial");

                entity.Property(e => e.Idtributario)
                    .IsRequired()
                    .HasColumnName("IDTributario")
                    .HasMaxLength(100);

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TblDetLlamadaReemplazo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_LlamadaReemplazo");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTipoFinal).HasColumnName("Cod_TipoFinal");

                entity.Property(e => e.Descuento).HasColumnType("money");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaRecepcion).HasColumnType("datetime");

                entity.Property(e => e.IdUbicGarantia)
                    .IsRequired()
                    .HasColumnName("ID_UbicGarantia")
                    .HasMaxLength(25);

                entity.Property(e => e.NumDocFinal)
                    .HasColumnName("Num_DocFinal")
                    .HasMaxLength(25);

                entity.Property(e => e.NumDocPedido)
                    .HasColumnName("Num_DocPedido")
                    .HasMaxLength(25);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblDetLlamadaServ>(entity =>
            {
                entity.HasKey(e => new { e.CodTipo, e.NumDocumento, e.Linea })
                    .HasName("PKDet_LlamadaServ");

                entity.ToTable("TblDet_LlamadaServ");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.NumDocumento)
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Accion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Precio).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.PrecioBase).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.PrecioOrig).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(20);

                entity.Property(e => e.Skufact)
                    .HasColumnName("SKUFact")
                    .HasMaxLength(20);

                entity.Property(e => e.Skureemplazo)
                    .HasColumnName("SKUReemplazo")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblDetMovBodega>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_MovBodega");

                entity.HasIndex(e => new { e.LineaOrig, e.Sku, e.Cantidad, e.CodMedida, e.CodTipo, e.NumDocumento })
                    .HasName("Idx_TblDet_MovBodega");

                entity.Property(e => e.CodMedida)
                    .IsRequired()
                    .HasColumnName("Cod_Medida")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.DocSap)
                    .HasColumnName("DocSAP")
                    .HasMaxLength(15);

                entity.Property(e => e.FechaOp).HasColumnType("datetime");

                entity.Property(e => e.FechaSap)
                    .HasColumnName("FechaSAP")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdUbicDest)
                    .HasColumnName("ID_UbicDest")
                    .HasMaxLength(25);

                entity.Property(e => e.IdUbicOrig)
                    .HasColumnName("ID_UbicOrig")
                    .HasMaxLength(25);

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TblDetNotaCred>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_NotaCred");

                entity.HasIndex(e => new { e.CodTipoFinal, e.NumDocFinal })
                    .HasName("<Cod_TipoFinal,Num_DocFinal>");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTipoFinal).HasColumnName("Cod_TipoFinal");

                entity.Property(e => e.FactOrigen).HasMaxLength(25);

                entity.Property(e => e.NumDocFinal)
                    .HasColumnName("Num_DocFinal")
                    .HasMaxLength(50);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.PrecioBase).HasColumnType("money");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TblDetNotaCredAnulada>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_NotaCredAnulada");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTipoFinal).HasColumnName("Cod_TipoFinal");

                entity.Property(e => e.NumDocFinal)
                    .HasColumnName("Num_DocFinal")
                    .HasMaxLength(50);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TblDetObsInventario>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_ObsInventario");

                entity.Property(e => e.IdUbicacion)
                    .HasColumnName("ID_Ubicacion")
                    .HasMaxLength(25);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblDetOla>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_Ola");

                entity.HasIndex(e => new { e.NumDocumento, e.Cantidad })
                    .HasName("<Num_Documento,Cantidad>");

                entity.HasIndex(e => new { e.NumOla, e.LineaDoc, e.Sku, e.Skufact })
                    .HasName("idx_num_linea_sku_skufact");

                entity.HasIndex(e => new { e.FechaRec, e.EntregaSap, e.Sku, e.NumDocumento, e.FechaTransporteSap })
                    .HasName("idx_20191219_FTSAP");

                entity.Property(e => e.CodMedida)
                    .IsRequired()
                    .HasColumnName("Cod_Medida")
                    .HasMaxLength(10);

                entity.Property(e => e.CodMedidaRec)
                    .HasColumnName("Cod_MedidaRec")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTipoDocUbic).HasColumnName("Cod_TipoDocUbic");

                entity.Property(e => e.EntregaSap)
                    .HasColumnName("EntregaSAP")
                    .HasMaxLength(1000);

                entity.Property(e => e.FechaConfSap)
                    .HasColumnName("FechaConfSAP")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRec).HasColumnType("datetime");

                entity.Property(e => e.FechaTarimaSap)
                    .HasColumnName("FechaTarimaSAP")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaTransporteSap)
                    .HasColumnName("FechaTransporteSAP")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaTransporteSap2)
                    .HasColumnName("FechaTransporteSAP2")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdAuditor)
                    .HasColumnName("ID_Auditor")
                    .HasMaxLength(40);

                entity.Property(e => e.IdRecolector)
                    .HasColumnName("ID_Recolector")
                    .HasMaxLength(40);

                entity.Property(e => e.IdUbicAudit)
                    .HasColumnName("ID_UbicAudit")
                    .HasMaxLength(25);

                entity.Property(e => e.IdUbicReal)
                    .HasColumnName("ID_UbicReal")
                    .HasMaxLength(25);

                entity.Property(e => e.IdUbicSug)
                    .IsRequired()
                    .HasColumnName("ID_UbicSug")
                    .HasMaxLength(25);

                entity.Property(e => e.LineaEntregaSap).HasColumnName("LineaEntregaSAP");

                entity.Property(e => e.LineaTransporteSap).HasColumnName("LineaTransporteSAP");

                entity.Property(e => e.LineaTransporteSap2).HasColumnName("LineaTransporteSAP2");

                entity.Property(e => e.MsgError).HasColumnType("text");

                entity.Property(e => e.NumDocUbic)
                    .HasColumnName("Num_DocUbic")
                    .HasMaxLength(25);

                entity.Property(e => e.NumDocumento)
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.NumOla)
                    .IsRequired()
                    .HasColumnName("Num_Ola")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Skufact)
                    .HasColumnName("SKUFact")
                    .HasMaxLength(25);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tarima).HasMaxLength(40);

                entity.Property(e => e.TransporteSap)
                    .HasColumnName("TransporteSAP")
                    .HasMaxLength(40);

                entity.Property(e => e.TransporteSap2)
                    .HasColumnName("TransporteSAP2")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblDetOlaAudit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_OlaAudit");

                entity.Property(e => e.FechaAuditoria).HasColumnType("datetime");

                entity.Property(e => e.FechaTarimaSap)
                    .HasColumnName("FechaTarimaSAP")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdAuditor)
                    .IsRequired()
                    .HasColumnName("ID_Auditor")
                    .HasMaxLength(40);

                entity.Property(e => e.MsgError).HasMaxLength(1000);

                entity.Property(e => e.NumOla)
                    .IsRequired()
                    .HasColumnName("Num_Ola")
                    .HasMaxLength(25);

                entity.Property(e => e.Tarima)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblDetOlaOld>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_OlaOld");

                entity.HasIndex(e => e.NumOla)
                    .HasName("IX_TblDet_Ola_1");

                entity.HasIndex(e => new { e.NumOla, e.CantidadRec, e.IdUbicAudit, e.NumDocUbic })
                    .HasName("IX_TblDet_Ola_2");

                entity.HasIndex(e => new { e.NumOla, e.CantidadRec, e.NumDocUbic, e.IdUbicSug, e.Sku })
                    .HasName("IX_TblDet_Ola");

                entity.Property(e => e.CodMedida)
                    .IsRequired()
                    .HasColumnName("Cod_Medida")
                    .HasMaxLength(10);

                entity.Property(e => e.CodMedidaRec)
                    .HasColumnName("Cod_MedidaRec")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipoDocUbic).HasColumnName("Cod_TipoDocUbic");

                entity.Property(e => e.FechaRec).HasColumnType("datetime");

                entity.Property(e => e.IdRecolector)
                    .HasColumnName("ID_Recolector")
                    .HasMaxLength(40);

                entity.Property(e => e.IdUbicAudit)
                    .HasColumnName("ID_UbicAudit")
                    .HasMaxLength(25);

                entity.Property(e => e.IdUbicReal)
                    .HasColumnName("ID_UbicReal")
                    .HasMaxLength(25);

                entity.Property(e => e.IdUbicSug)
                    .IsRequired()
                    .HasColumnName("ID_UbicSug")
                    .HasMaxLength(25);

                entity.Property(e => e.NumDocUbic)
                    .HasColumnName("Num_DocUbic")
                    .HasMaxLength(25);

                entity.Property(e => e.NumOla)
                    .IsRequired()
                    .HasColumnName("Num_Ola")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Skufact)
                    .HasColumnName("SKUFact")
                    .HasMaxLength(25);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblDetOlaSap>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_OlaSAP");

                entity.HasIndex(e => new { e.CodTipo, e.NumDocumento })
                    .HasName("IdxDet_OlaSapPed");

                entity.HasIndex(e => new { e.DocSap, e.NumOla })
                    .HasName("Idx_TblDet_OlaSAP_CL2");

                entity.HasIndex(e => new { e.Sku, e.LineaSap, e.DocSap })
                    .HasName("Z_DETOLA_6");

                entity.Property(e => e.CantidadSap).HasColumnName("CantidadSAP");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.DocSap)
                    .IsRequired()
                    .HasColumnName("DocSAP")
                    .HasMaxLength(25);

                entity.Property(e => e.LineaSap).HasColumnName("LineaSAP");

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.NumOla)
                    .IsRequired()
                    .HasColumnName("Num_Ola")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblDetOlaTrasladoDom>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_OlaTrasladoDom");

                entity.Property(e => e.Destino)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.DocSap)
                    .HasColumnName("DocSAP")
                    .HasMaxLength(25);

                entity.Property(e => e.Error).HasMaxLength(1000);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.NumOla)
                    .IsRequired()
                    .HasColumnName("Num_Ola")
                    .HasMaxLength(25);

                entity.Property(e => e.Origen)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<TblDetOperManual>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_OperManual", "pos");

                entity.Property(e => e.IdAutorizador)
                    .IsRequired()
                    .HasColumnName("ID_Autorizador")
                    .HasMaxLength(40);

                entity.Property(e => e.IdCaja)
                    .IsRequired()
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(10);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblDetOperacionCaja>(entity =>
            {
                entity.HasKey(e => new { e.NumOperacion, e.CodMoneda });

                entity.ToTable("TblDet_OperacionCaja", "pos");

                entity.Property(e => e.NumOperacion)
                    .HasColumnName("Num_Operacion")
                    .HasMaxLength(25);

                entity.Property(e => e.CodMoneda)
                    .HasColumnName("Cod_Moneda")
                    .HasMaxLength(5);

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.Property(e => e.MontoLocal).HasColumnType("money");

                entity.Property(e => e.TipoCambio).HasColumnType("money");
            });

            modelBuilder.Entity<TblDetOrdenCompra>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_OrdenCompra");

                entity.HasIndex(e => new { e.CodTipo, e.NumDocumento, e.NumDocOrig, e.LineaOrig, e.Linea, e.Sku })
                    .HasName("Idx_TblDet_OrdenCompra_CL1");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTipoOrig).HasColumnName("Cod_TipoOrig");

                entity.Property(e => e.Modelo).HasMaxLength(100);

                entity.Property(e => e.NumDocOrig)
                    .HasColumnName("Num_DocOrig")
                    .HasMaxLength(25);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TblDetOservicio>(entity =>
            {
                entity.HasKey(e => new { e.IdCaja, e.Transaccion, e.IdxOrg, e.Idx })
                    .HasName("PK_TblDet_Oservicio");

                entity.ToTable("TblDet_OServicio", "pos");

                entity.Property(e => e.IdCaja)
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(10);

                entity.Property(e => e.ModoPuntos)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.PrecioDesc).HasColumnType("money");

                entity.Property(e => e.PrecioN).HasColumnType("money");

                entity.Property(e => e.PrecioPagoPuntos).HasColumnType("money");

                entity.Property(e => e.Scanner)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblDetOservicioAutVenta>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_OServicioAutVenta", "pos");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdCaja)
                    .IsRequired()
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(10);

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblDetOservicioDesc>(entity =>
            {
                entity.HasKey(e => new { e.IdCaja, e.Transaccion, e.Idx, e.IdxD })
                    .HasName("PK_TblDet_OservicioDesc");

                entity.ToTable("TblDet_OServicioDesc", "pos");

                entity.Property(e => e.IdCaja)
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipoD)
                    .HasColumnName("Cod_TipoD")
                    .HasMaxLength(25);

                entity.Property(e => e.Descuento).HasMaxLength(50);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Valor).HasColumnType("money");
            });

            modelBuilder.Entity<TblDetOservicioOperManual>(entity =>
            {
                entity.HasKey(e => new { e.IdCaja, e.Transaccion, e.Idx });

                entity.ToTable("TblDet_OServicioOperManual", "pos");

                entity.Property(e => e.IdCaja)
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(10);

                entity.Property(e => e.IdAutorizador)
                    .IsRequired()
                    .HasColumnName("ID_Autorizador")
                    .HasMaxLength(40);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblDetPago>(entity =>
            {
                entity.HasKey(e => new { e.IdCaja, e.Transaccion, e.Idx });

                entity.ToTable("TblDet_Pago", "pos");

                entity.Property(e => e.IdCaja)
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(10);

                entity.Property(e => e.Afiliacion).HasMaxLength(25);

                entity.Property(e => e.Autorizacion).HasMaxLength(50);

                entity.Property(e => e.Cambio).HasColumnType("money");

                entity.Property(e => e.CodBanco).HasColumnName("Cod_Banco");

                entity.Property(e => e.CodMoneda)
                    .HasColumnName("Cod_Moneda")
                    .HasMaxLength(5);

                entity.Property(e => e.Cuenta).HasMaxLength(50);

                entity.Property(e => e.Documento).HasMaxLength(250);

                entity.Property(e => e.Documento2).HasMaxLength(250);

                entity.Property(e => e.FechaVencimiento)
                    .HasColumnName("fechaVencimiento")
                    .HasMaxLength(10);

                entity.Property(e => e.Identificacion).HasMaxLength(100);

                entity.Property(e => e.ModoPago)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.Property(e => e.MontoOrg).HasColumnType("money");

                entity.Property(e => e.Propietario).HasMaxLength(50);

                entity.Property(e => e.Referencia).HasMaxLength(50);

                entity.Property(e => e.TipoCambio).HasColumnType("money");
            });

            modelBuilder.Entity<TblDetPagoInfo>(entity =>
            {
                entity.HasKey(e => new { e.IdCaja, e.Transaccion });

                entity.ToTable("TblDet_PagoInfo", "pos");

                entity.Property(e => e.IdCaja)
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AreaLabor)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Identificacion)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Idtributario)
                    .IsRequired()
                    .HasColumnName("IDTributario")
                    .HasMaxLength(15);

                entity.Property(e => e.MontoLimite).HasColumnType("money");

                entity.Property(e => e.NoVale)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TblDetPagoTarAnulado>(entity =>
            {
                entity.HasKey(e => new { e.IdCaja, e.Transaccion, e.Idx });

                entity.ToTable("TblDet_PagoTarAnulado", "pos");

                entity.Property(e => e.IdCaja)
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(10);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblDetParqueoDesc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_ParqueoDesc", "pos");

                entity.Property(e => e.CodDescuento)
                    .HasColumnName("Cod_Descuento")
                    .HasMaxLength(10);

                entity.Property(e => e.CodRazon).HasColumnName("Cod_Razon");

                entity.Property(e => e.CodSocio)
                    .IsRequired()
                    .HasColumnName("Cod_Socio")
                    .HasMaxLength(25);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdCaja)
                    .IsRequired()
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(10);

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(50);

                entity.Property(e => e.IdUsuarioAut)
                    .HasColumnName("ID_UsuarioAut")
                    .HasMaxLength(50);

                entity.Property(e => e.Modo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MontoDesc).HasColumnType("money");

                entity.Property(e => e.MontoTotal).HasColumnType("money");

                entity.Property(e => e.Ticket)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblDetPedido>(entity =>
            {
                entity.HasKey(e => new { e.CodTipo, e.NumDocumento, e.Linea })
                    .HasName("PKDet_Pedido");

                entity.ToTable("TblDet_Pedido");

                entity.HasIndex(e => e.Listo)
                    .HasName("<Listo>");

                entity.HasIndex(e => e.NumDocumento)
                    .HasName("<Num_Documento_detpedido>");

                entity.HasIndex(e => e.Sku)
                    .HasName("Idx_ArticuloPedido");

                entity.HasIndex(e => new { e.CodTipo, e.NumDocumento, e.Linea, e.Sku, e.Skufact })
                    .HasName("idx_tipo_docto_sku_skufact_linea");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.NumDocumento)
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.AccionIncompleto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.PrecioBase).HasColumnType("money");

                entity.Property(e => e.PrecioDesc).HasColumnType("money");

                entity.Property(e => e.PrecioFiscal).HasColumnType("money");

                entity.Property(e => e.PrecioOrig).HasColumnType("money");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(20);

                entity.Property(e => e.Skufact)
                    .HasColumnName("SKUFact")
                    .HasMaxLength(20);

                entity.Property(e => e.Skureemplazado)
                    .HasColumnName("SKUReemplazado")
                    .HasMaxLength(25);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblDetPedido2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_Pedido2");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Precio).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.PrecioBase).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.PrecioOrig).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(20);

                entity.Property(e => e.Skufact)
                    .HasColumnName("SKUFact")
                    .HasMaxLength(20);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblDetPedidoCupon>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_PedidoCupon");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Tcupon).HasColumnName("TCupon");

                entity.Property(e => e.Valor).HasColumnType("money");
            });

            modelBuilder.Entity<TblDetPedidoDesc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_PedidoDesc");

                entity.Property(e => e.CodCupon)
                    .IsRequired()
                    .HasColumnName("Cod_Cupon")
                    .HasMaxLength(25);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Valor).HasColumnType("money");
            });

            modelBuilder.Entity<TblDetPedidoDir>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_PedidoDir");

                entity.HasIndex(e => new { e.CodTipo, e.NumDocumento })
                    .HasName("Idx_PedidoDor");

                entity.HasIndex(e => new { e.NumDocumento, e.Tipo })
                    .HasName("<Num_Documento,Tipo>");

                entity.HasIndex(e => new { e.Tipo, e.CodTipo, e.NumDocumento })
                    .HasName("20200709,tipo,codtipo,numdocto");

                entity.Property(e => e.Ciudad)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CodEstado)
                    .HasColumnName("Cod_Estado")
                    .HasMaxLength(10);

                entity.Property(e => e.CodMunicipio)
                    .HasColumnName("Cod_Municipio")
                    .HasMaxLength(10);

                entity.Property(e => e.CodPais)
                    .HasColumnName("Cod_Pais")
                    .HasMaxLength(10);

                entity.Property(e => e.CodPostal).HasMaxLength(25);

                entity.Property(e => e.CodTienda)
                    .HasColumnName("Cod_Tienda")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.Compania).HasMaxLength(250);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(250);

                entity.Property(e => e.EnviarFe)
                    .IsRequired()
                    .HasColumnName("EnviarFE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Nit)
                    .HasColumnName("NIT")
                    .HasMaxLength(250);

                entity.Property(e => e.Nombre).HasMaxLength(250);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Telefono).HasMaxLength(150);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Transporte)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Zona).HasMaxLength(10);
            });

            modelBuilder.Entity<TblDetPedidoDirAct>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_PedidoDirAct");

                entity.Property(e => e.Ciudad)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CodEstado)
                    .HasColumnName("Cod_Estado")
                    .HasMaxLength(10);

                entity.Property(e => e.CodMunicipio)
                    .HasColumnName("Cod_Municipio")
                    .HasMaxLength(10);

                entity.Property(e => e.CodPais)
                    .HasColumnName("Cod_Pais")
                    .HasMaxLength(10);

                entity.Property(e => e.CodPostal).HasMaxLength(25);

                entity.Property(e => e.CodTienda)
                    .HasColumnName("Cod_Tienda")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.Compania).HasMaxLength(250);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(250);

                entity.Property(e => e.EnviarFe)
                    .IsRequired()
                    .HasColumnName("EnviarFE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FechaCambio).HasColumnType("datetime");

                entity.Property(e => e.IdUsuarioCambio)
                    .IsRequired()
                    .HasColumnName("ID_UsuarioCambio")
                    .HasMaxLength(40);

                entity.Property(e => e.Nit)
                    .HasColumnName("NIT")
                    .HasMaxLength(250);

                entity.Property(e => e.Nombre).HasMaxLength(250);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Telefono).HasMaxLength(150);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Transporte)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Zona).HasMaxLength(10);
            });

            modelBuilder.Entity<TblDetPedidoRegalo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_PedidoRegalo");

                entity.HasIndex(e => e.IdUbicEnvuelto)
                    .HasName("Idx_PedidoRegaloUbic");

                entity.HasIndex(e => new { e.NumDocumento, e.IdEvento })
                    .HasName("<Num_Documento,ID_Evento>");

                entity.HasIndex(e => new { e.CodTipo, e.NumDocumento, e.IdEvento })
                    .HasName("20200714_codtipo_numdocto_idevento");

                entity.HasIndex(e => new { e.CodTipo, e.NumDocumento, e.Linea })
                    .HasName("<Cod_Tipo,Num_Documento,Linea>");

                entity.HasIndex(e => new { e.NumDocumento, e.CodTipo, e.IdEvento })
                    .HasName("20200714_idevento");

                entity.Property(e => e.CodEnvoltorio)
                    .IsRequired()
                    .HasColumnName("Cod_Envoltorio")
                    .HasMaxLength(25);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.De).HasMaxLength(250);

                entity.Property(e => e.IdEvento)
                    .HasColumnName("ID_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.IdUbicEnvuelto)
                    .HasColumnName("ID_UbicEnvuelto")
                    .HasMaxLength(25);

                entity.Property(e => e.Intercambio)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mensaje).HasMaxLength(4000);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.NumLlamadaNc)
                    .HasColumnName("Num_LLamadaNC")
                    .HasMaxLength(25);

                entity.Property(e => e.Para).HasMaxLength(250);
            });

            modelBuilder.Entity<TblDetPedidoReqTda>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_PedidoReqTda");

                entity.Property(e => e.CodTienda)
                    .IsRequired()
                    .HasColumnName("Cod_Tienda")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblDetPedidoTregalo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_PedidoTRegalo");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Tarjeta)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblDetPedidoVtex>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_PedidoVTex");

                entity.Property(e => e.Carrier)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.DelvChannel)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Dock)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Fcompromiso)
                    .HasColumnName("FCompromiso")
                    .HasColumnType("datetime");

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.PickUpPoint).HasMaxLength(10);

                entity.Property(e => e.Tiempo)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Warehouse)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblDetPeriodo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_Periodo");

                entity.Property(e => e.Al).HasColumnType("datetime");

                entity.Property(e => e.Del).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblDetRetiroEfectivo>(entity =>
            {
                entity.HasKey(e => new { e.NumRetiro, e.CodMoneda });

                entity.ToTable("TblDet_RetiroEfectivo", "pos");

                entity.Property(e => e.NumRetiro)
                    .HasColumnName("Num_Retiro")
                    .HasMaxLength(25);

                entity.Property(e => e.CodMoneda)
                    .HasColumnName("Cod_Moneda")
                    .HasMaxLength(5);

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.Property(e => e.MontoLocal).HasColumnType("money");

                entity.Property(e => e.TipoCambio).HasColumnType("money");
            });

            modelBuilder.Entity<TblDetUbicInventario>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_UbicInventario");

                entity.Property(e => e.IdUbicacion)
                    .IsRequired()
                    .HasColumnName("Id_Ubicacion")
                    .HasMaxLength(25);

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblDetUsrInventario>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_UsrInventario");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblDetVenta>(entity =>
            {
                entity.HasKey(e => new { e.IdCaja, e.Transaccion, e.Idx })
                    .IsClustered(false);

                entity.ToTable("TblDet_Venta", "pos");

                entity.Property(e => e.IdCaja)
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(10);

                entity.Property(e => e.DescPago).HasColumnType("money");

                entity.Property(e => e.Descuento).HasColumnType("money");

                entity.Property(e => e.ModoPuntos)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ModoVenta)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.PrecioDesc).HasColumnType("money");

                entity.Property(e => e.PrecioFiscal).HasColumnType("money");

                entity.Property(e => e.PrecioN).HasColumnType("money");

                entity.Property(e => e.PrecioPagoPuntos).HasColumnType("money");

                entity.Property(e => e.Scanner)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Total).HasColumnType("money");

                entity.Property(e => e.TotalDesc).HasColumnType("money");
            });

            modelBuilder.Entity<TblDetVentaArtDaniado>(entity =>
            {
                entity.HasKey(e => new { e.IdCaja, e.Transaccion, e.Idx })
                    .HasName("PKDet_VentaArtDaniado");

                entity.ToTable("TblDet_VentaArtDaniado", "pos");

                entity.Property(e => e.IdCaja)
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(10);

                entity.Property(e => e.IdArticulo)
                    .IsRequired()
                    .HasColumnName("ID_Articulo")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblDetVentaCombo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_VentaCombo", "pos");

                entity.Property(e => e.IdCaja)
                    .IsRequired()
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(10);

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblDetVentaComboGrp>(entity =>
            {
                entity.HasKey(e => new { e.IdCaja, e.Transaccion, e.Idx, e.IdxCombo });

                entity.ToTable("TblDet_VentaComboGrp", "pos");

                entity.Property(e => e.IdCaja)
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(10);

                entity.Property(e => e.CodGrupo)
                    .IsRequired()
                    .HasColumnName("Cod_Grupo")
                    .HasMaxLength(20);

                entity.Property(e => e.Modo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MontoUtilizado).HasColumnType("money");

                entity.Property(e => e.Precio).HasColumnType("money");
            });

            modelBuilder.Entity<TblDetVentaCuponPromo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_VentaCuponPromo", "pos");

                entity.Property(e => e.CodCupon)
                    .HasColumnName("Cod_Cupon")
                    .HasMaxLength(25);

                entity.Property(e => e.IdCaja)
                    .IsRequired()
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<TblDetVentaCuponSocio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_VentaCuponSocio", "pos");

                entity.Property(e => e.CodCupon)
                    .IsRequired()
                    .HasColumnName("Cod_Cupon")
                    .HasMaxLength(25);

                entity.Property(e => e.IdCaja)
                    .IsRequired()
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblDetVentaDesc>(entity =>
            {
                entity.HasKey(e => new { e.IdCaja, e.Transaccion, e.Idx, e.IdxD });

                entity.ToTable("TblDet_VentaDesc", "pos");

                entity.Property(e => e.IdCaja)
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipoD)
                    .HasColumnName("Cod_TipoD")
                    .HasMaxLength(25);

                entity.Property(e => e.Descuento).HasMaxLength(50);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Valor).HasColumnType("money");
            });

            modelBuilder.Entity<TblDetVentaEncuesta>(entity =>
            {
                entity.HasKey(e => new { e.IdCaja, e.Transaccion, e.CodPregunta });

                entity.ToTable("TblDet_VentaEncuesta", "pos");

                entity.Property(e => e.IdCaja)
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(10);

                entity.Property(e => e.CodPregunta).HasColumnName("Cod_Pregunta");

                entity.Property(e => e.CodEncuesta)
                    .HasColumnName("Cod_Encuesta")
                    .HasMaxLength(25);

                entity.Property(e => e.CodRespuesta).HasColumnName("Cod_Respuesta");

                entity.Property(e => e.DescRespuesta).HasMaxLength(150);
            });

            modelBuilder.Entity<TblDetVentaTarRegalo>(entity =>
            {
                entity.HasKey(e => new { e.IdCaja, e.Transaccion, e.Idx });

                entity.ToTable("TblDet_VentaTarRegalo", "pos");

                entity.Property(e => e.IdCaja)
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.Property(e => e.Tarjeta)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblDevolucion>(entity =>
            {
                entity.HasKey(e => new { e.SerieDv, e.NumeroDv, e.TipoDv });

                entity.ToTable("Tbl_Devolucion", "pos");

                entity.Property(e => e.SerieDv)
                    .HasColumnName("SerieDV")
                    .HasMaxLength(25);

                entity.Property(e => e.NumeroDv)
                    .HasColumnName("NumeroDV")
                    .HasMaxLength(25);

                entity.Property(e => e.TipoDv)
                    .HasColumnName("TipoDV")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodEstado).HasColumnName("Cod_Estado");

                entity.Property(e => e.CodRazon).HasColumnName("Cod_Razon");

                entity.Property(e => e.FechaAuditoria).HasColumnType("datetime");

                entity.Property(e => e.IdCaja)
                    .IsRequired()
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(10);

                entity.Property(e => e.IdCajaOrig)
                    .HasColumnName("ID_CajaOrig")
                    .HasMaxLength(10);

                entity.Property(e => e.IdEventoOrig)
                    .HasColumnName("ID_EventoOrig")
                    .HasMaxLength(20);

                entity.Property(e => e.Saldo).HasColumnType("money");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Telefono).HasMaxLength(15);

                entity.Property(e => e.TiendaOrig).HasMaxLength(10);

                entity.Property(e => e.Total).HasColumnType("money");

                entity.Property(e => e.TotalDescPago).HasColumnType("money");

                entity.Property(e => e.TotalPrecioFiscal).HasColumnType("money");
            });

            modelBuilder.Entity<TblDirSocioNeg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_DirSocioNeg");

                entity.Property(e => e.Ciudad)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CodCliente)
                    .IsRequired()
                    .HasColumnName("Cod_Cliente")
                    .HasMaxLength(25);

                entity.Property(e => e.CodEmpresa)
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(50);

                entity.Property(e => e.CodEstado)
                    .HasColumnName("Cod_Estado")
                    .HasMaxLength(10);

                entity.Property(e => e.CodMunicipio)
                    .HasColumnName("Cod_Municipio")
                    .HasMaxLength(10);

                entity.Property(e => e.CodPais)
                    .HasColumnName("Cod_Pais")
                    .HasMaxLength(10);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblDocRegenerado>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_DocRegenerado");

                entity.Property(e => e.CodEmpresa)
                    .IsRequired()
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(15);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.Nuevo)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Original)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblDocSap>(entity =>
            {
                entity.HasKey(e => new { e.IdCaja, e.Transaccion });

                entity.ToTable("Tbl_DocSAP", "pos");

                entity.Property(e => e.IdCaja)
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(15);

                entity.Property(e => e.CodTipo)
                    .IsRequired()
                    .HasColumnName("Cod_Tipo")
                    .HasMaxLength(15);

                entity.Property(e => e.FacturaSap)
                    .HasColumnName("FacturaSAP")
                    .HasMaxLength(25);

                entity.Property(e => e.FechaAct).HasColumnType("datetime");

                entity.Property(e => e.PagoSap)
                    .HasColumnName("PagoSAP")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblDocWmsPos>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_DocWMS_POS");

                entity.HasIndex(e => new { e.IdCaja, e.Transaccion, e.CodTipo, e.NumDocumento })
                    .HasName("Idx_DocWMSPos");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.IdAsociado)
                    .IsRequired()
                    .HasColumnName("ID_Asociado")
                    .HasMaxLength(25);

                entity.Property(e => e.IdCaja)
                    .IsRequired()
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(10);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Tarjeta)
                    .IsRequired()
                    .HasMaxLength(13);
            });

            modelBuilder.Entity<TblDocumento>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Documento");

                entity.HasIndex(e => e.NumDocOrig)
                    .HasName("idx_20191219_Num_DocOrig");

                entity.HasIndex(e => new { e.CodTipo, e.NumDocumento })
                    .HasName("Cod_Tipo,Num_Documento");

                entity.HasIndex(e => new { e.CodTipoOrig, e.NumDocOrig })
                    .HasName("20200709,cod_tipoorig,num_docorig");

                entity.HasIndex(e => new { e.CodSocio, e.CodTipoOrig, e.NumDocOrig, e.Lineas, e.Descuento, e.Total, e.Status, e.FechaImp, e.DocSap, e.IdUsrImp, e.FechaAnul, e.DocSapanul, e.IdUsrAnul, e.CodDestinatario, e.CodEmpresa, e.NumDocumento, e.CodTipo, e.Fecha })
                    .HasName("20200714_codtipo_fecha");

                entity.Property(e => e.CodDestinatario)
                    .HasColumnName("Cod_Destinatario")
                    .HasMaxLength(25);

                entity.Property(e => e.CodEmpresa)
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.CodSocio)
                    .HasColumnName("Cod_Socio")
                    .HasMaxLength(25);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTipoOrig).HasColumnName("Cod_TipoOrig");

                entity.Property(e => e.Descuento).HasColumnType("money");

                entity.Property(e => e.DocSap)
                    .HasColumnName("DocSAP")
                    .HasMaxLength(25);

                entity.Property(e => e.DocSapanul)
                    .HasColumnName("DocSAPAnul")
                    .HasMaxLength(25);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaAnul).HasColumnType("datetime");

                entity.Property(e => e.FechaImp).HasColumnType("datetime");

                entity.Property(e => e.IdUsrAnul)
                    .HasColumnName("ID_UsrAnul")
                    .HasMaxLength(25);

                entity.Property(e => e.IdUsrImp)
                    .HasColumnName("ID_UsrImp")
                    .HasMaxLength(40);

                entity.Property(e => e.NumDocOrig)
                    .IsRequired()
                    .HasColumnName("Num_DocOrig")
                    .HasMaxLength(25);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Total).HasColumnType("money");
            });

            modelBuilder.Entity<TblDocumentoCl>(entity =>
            {
                entity.HasKey(e => new { e.IdCaja, e.Transaccion });

                entity.ToTable("Tbl_Documento_Cl", "pos");

                entity.Property(e => e.IdCaja)
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(15);

                entity.Property(e => e.Ahorro).HasColumnType("money");

                entity.Property(e => e.CodTienda)
                    .IsRequired()
                    .HasColumnName("Cod_Tienda")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTipoTarjeta).HasColumnName("Cod_TipoTarjeta");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaFin).HasColumnType("datetime");

                entity.Property(e => e.FechaIni).HasColumnType("datetime");

                entity.Property(e => e.IdAsociado)
                    .IsRequired()
                    .HasColumnName("ID_Asociado")
                    .HasMaxLength(25);

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("Id_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.Idtributario)
                    .IsRequired()
                    .HasColumnName("IDTributario")
                    .HasMaxLength(15);

                entity.Property(e => e.Impuestos).HasColumnType("money");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NumOperacion)
                    .IsRequired()
                    .HasColumnName("Num_Operacion")
                    .HasMaxLength(15);

                entity.Property(e => e.Numero).HasMaxLength(25);

                entity.Property(e => e.Operador).HasMaxLength(25);

                entity.Property(e => e.Resolucion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Saldo).HasColumnType("money");

                entity.Property(e => e.Serie).HasMaxLength(25);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SubTotal).HasColumnType("money");

                entity.Property(e => e.Tarjeta)
                    .IsRequired()
                    .HasMaxLength(13);

                entity.Property(e => e.Total).HasColumnType("money");

                entity.Property(e => e.TotalFiscal).HasColumnType("money");

                entity.Property(e => e.Vendedor).HasMaxLength(50);
            });

            modelBuilder.Entity<TblDocumentoClSap>(entity =>
            {
                entity.HasKey(e => new { e.IdCaja, e.Transaccion });

                entity.ToTable("Tbl_DocumentoCl_SAP", "pos");

                entity.Property(e => e.IdCaja)
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(15);

                entity.Property(e => e.CodTienda)
                    .IsRequired()
                    .HasColumnName("Cod_Tienda")
                    .HasMaxLength(10);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblDocumentoClSapanular>(entity =>
            {
                entity.HasKey(e => new { e.IdCaja, e.Transaccion });

                entity.ToTable("Tbl_DocumentoCl_SAPAnular", "pos");

                entity.Property(e => e.IdCaja)
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(15);

                entity.Property(e => e.CodTienda)
                    .IsRequired()
                    .HasColumnName("Cod_Tienda")
                    .HasMaxLength(10);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblDocumentoClSat>(entity =>
            {
                entity.HasKey(e => new { e.CodTipo, e.Serie, e.Numero });

                entity.ToTable("Tbl_DocumentoCl_SAT", "pos");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.Serie).HasMaxLength(50);

                entity.Property(e => e.Cae).HasMaxLength(200);

                entity.Property(e => e.CodTienda)
                    .IsRequired()
                    .HasColumnName("Cod_Tienda")
                    .HasMaxLength(10);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdCaja)
                    .IsRequired()
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(15);

                entity.Property(e => e.NumDocumento)
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(100);

                entity.Property(e => e.PedidoSap)
                    .HasColumnName("PedidoSAP")
                    .HasMaxLength(25);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblDocumentoClSatfel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_DocumentoCl_SATFEL", "pos");

                entity.Property(e => e.CodTienda)
                    .IsRequired()
                    .HasColumnName("Cod_Tienda")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.FechaE).HasColumnType("datetime");

                entity.Property(e => e.FechaEanul)
                    .HasColumnName("FechaEAnul")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCaja)
                    .IsRequired()
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(15);

                entity.Property(e => e.IdxFel).HasColumnName("IdxFEL");

                entity.Property(e => e.Numero).HasMaxLength(100);

                entity.Property(e => e.NumeroAnul).HasMaxLength(100);

                entity.Property(e => e.Serie).HasMaxLength(100);

                entity.Property(e => e.SerieAnul).HasMaxLength(100);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Uuid)
                    .HasColumnName("UUID")
                    .HasMaxLength(150);

                entity.Property(e => e.Uuidanul)
                    .HasColumnName("UUIDAnul")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<TblDocumentoClSatfelcontingencia>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_DocumentoCl_SATFELContingencia", "pos");

                entity.HasIndex(e => new { e.IdCaja, e.Transaccion })
                    .HasName("idx_idcaja_transaccion");

                entity.Property(e => e.CodTienda)
                    .IsRequired()
                    .HasColumnName("Cod_Tienda")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdCaja)
                    .IsRequired()
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(15);

                entity.Property(e => e.NumContingencia)
                    .IsRequired()
                    .HasColumnName("Num_Contingencia")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblDocumentoFe>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_DocumentoFE");

                entity.Property(e => e.Cae)
                    .HasColumnName("CAE")
                    .HasMaxLength(100);

                entity.Property(e => e.Caeanul)
                    .HasColumnName("CAEAnul")
                    .HasMaxLength(100);

                entity.Property(e => e.CodEmpresa)
                    .IsRequired()
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.FechaE).HasColumnType("datetime");

                entity.Property(e => e.FechaEanul)
                    .HasColumnName("FechaEAnul")
                    .HasColumnType("datetime");

                entity.Property(e => e.FirmaE).HasMaxLength(100);

                entity.Property(e => e.FirmaEanul)
                    .HasColumnName("FirmaEAnul")
                    .HasMaxLength(100);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Resolucion).HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblDocumentoFeMail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_DocumentoFeMail");

                entity.HasIndex(e => new { e.CodTipo, e.NumDocumento })
                    .HasName("20200709 codtipo numdocto");

                entity.Property(e => e.CodEmpresa)
                    .IsRequired()
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.EMail)
                    .IsRequired()
                    .HasColumnName("eMail")
                    .HasMaxLength(100);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblDocumentoFeManual>(entity =>
            {
                entity.HasKey(e => new { e.CodTipo, e.Serie, e.Numero });

                entity.ToTable("Tbl_DocumentoFE_Manual", "pos");

                entity.Property(e => e.CodTipo)
                    .HasColumnName("Cod_Tipo")
                    .HasMaxLength(10);

                entity.Property(e => e.Serie).HasMaxLength(25);

                entity.Property(e => e.Numero).HasMaxLength(25);

                entity.Property(e => e.CodCliente)
                    .IsRequired()
                    .HasColumnName("Cod_Cliente")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodMoneda)
                    .HasColumnName("Cod_Moneda")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTienda)
                    .HasColumnName("Cod_Tienda")
                    .HasMaxLength(10);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdCaja)
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(20);

                entity.Property(e => e.Idtributario)
                    .IsRequired()
                    .HasColumnName("IDTributario")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SubTotal).HasColumnType("money");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCambio).HasColumnType("money");

                entity.Property(e => e.Total).HasColumnType("money");
            });

            modelBuilder.Entity<TblDocumentoFel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_DocumentoFEL");

                entity.HasIndex(e => new { e.CodTipo, e.NumDocumento })
                    .HasName("<Cod_Tipo,Num_Documento>");

                entity.HasIndex(e => new { e.NumDocumento, e.FechaE, e.Status, e.CodEmpresa, e.CodTipo, e.Uuid })
                    .HasName("20200714_codtipo_uuid_codempresa");

                entity.Property(e => e.CodEmpresa)
                    .IsRequired()
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.FechaE).HasColumnType("datetime");

                entity.Property(e => e.FechaEanul)
                    .HasColumnName("FechaEAnul")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdxFel).HasColumnName("IdxFEL");

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Numero).HasMaxLength(100);

                entity.Property(e => e.NumeroAnul).HasMaxLength(100);

                entity.Property(e => e.Serie).HasMaxLength(100);

                entity.Property(e => e.SerieAnul).HasMaxLength(100);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Uuid)
                    .HasColumnName("UUID")
                    .HasMaxLength(250);

                entity.Property(e => e.Uuidanul)
                    .HasColumnName("UUIDAnul")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<TblDocumentoIntSbo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_DocumentoIntSBO");

                entity.Property(e => e.CodEmpCliente)
                    .HasColumnName("Cod_EmpCliente")
                    .HasMaxLength(10);

                entity.Property(e => e.CodEmpresa)
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.DocSap)
                    .HasColumnName("DocSAP")
                    .HasMaxLength(25);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.NumDocumento)
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblDocumentoMailZenDesk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_DocumentoMailZenDesk");

                entity.HasIndex(e => new { e.CodTipo, e.NumDocumento, e.TipoMensaje })
                    .HasName("<TipoMensaje>");

                entity.Property(e => e.CodEmpresa)
                    .IsRequired()
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.EMail)
                    .IsRequired()
                    .HasColumnName("eMail")
                    .HasMaxLength(100);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblEmpaque>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Empaque");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblEmpresa>(entity =>
            {
                entity.HasKey(e => e.CodEmpresa);

                entity.ToTable("Tbl_Empresa");

                entity.Property(e => e.CodEmpresa)
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.CodAutoconsumo)
                    .HasColumnName("Cod_Autoconsumo")
                    .HasMaxLength(25);

                entity.Property(e => e.CodCredGuia)
                    .HasColumnName("Cod_CredGuia")
                    .HasMaxLength(25);

                entity.Property(e => e.CodCredGuiaDet)
                    .HasColumnName("Cod_CredGuiaDet")
                    .HasMaxLength(25);

                entity.Property(e => e.CodDestGuia)
                    .IsRequired()
                    .HasColumnName("Cod_DestGuia")
                    .HasMaxLength(25);

                entity.Property(e => e.Db)
                    .IsRequired()
                    .HasColumnName("DB")
                    .HasMaxLength(50);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Nit)
                    .HasColumnName("NIT")
                    .HasMaxLength(15);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PrefijoFact).HasMaxLength(5);

                entity.Property(e => e.PwdSap)
                    .HasColumnName("PwdSAP")
                    .HasMaxLength(50);

                entity.Property(e => e.SerieFact).HasMaxLength(5);

                entity.Property(e => e.Servidor)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefono).HasMaxLength(50);

                entity.Property(e => e.UsrSap)
                    .HasColumnName("UsrSAP")
                    .HasMaxLength(50);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblEntrega>(entity =>
            {
                entity.HasKey(e => e.NumEntrega);

                entity.ToTable("Tbl_Entrega");

                entity.Property(e => e.NumEntrega)
                    .HasColumnName("Num_Entrega")
                    .HasMaxLength(20);

                entity.Property(e => e.CodSocio)
                    .IsRequired()
                    .HasColumnName("Cod_Socio")
                    .HasMaxLength(25);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NumeroId)
                    .IsRequired()
                    .HasColumnName("NumeroID")
                    .HasMaxLength(40);

                entity.Property(e => e.SerieId)
                    .IsRequired()
                    .HasColumnName("SerieID")
                    .HasMaxLength(10);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblEntregaContaSap>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_EntregaContaSAP");

                entity.HasIndex(e => e.DocSap)
                    .HasName("Idx_Tbl_EntregaContaSAP_CL1")
                    .IsClustered();

                entity.Property(e => e.DocSap)
                    .IsRequired()
                    .HasColumnName("DocSAP")
                    .HasMaxLength(25);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblEnvioIntercambio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_EnvioIntercambio");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("ID_Envio")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblEnvioReserva>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_EnvioReserva");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("ID_Envio")
                    .HasMaxLength(25);

                entity.Property(e => e.IdReserva)
                    .IsRequired()
                    .HasColumnName("ID_Reserva")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblEnviosReversados>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_EnviosReversados");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("ID_Envio")
                    .HasMaxLength(25);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblEstadoVtex>(entity =>
            {
                entity.HasKey(e => e.CodEstado)
                    .HasName("PK_EstadoVTex");

                entity.ToTable("Tbl_EstadoVTex");

                entity.Property(e => e.CodEstado)
                    .HasColumnName("Cod_Estado")
                    .ValueGeneratedNever();

                entity.Property(e => e.Asunto).HasColumnType("text");

                entity.Property(e => e.CopiaOculta).HasMaxLength(100);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Destinatario).HasMaxLength(100);

                entity.Property(e => e.Mensaje).HasColumnType("text");

                entity.Property(e => e.MensajeDet).HasColumnType("text");

                entity.Property(e => e.Modo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.QueryBusq).HasColumnType("text");

                entity.Property(e => e.QueryData).HasColumnType("text");

                entity.Property(e => e.QueryDet).HasColumnType("text");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoTransaccional)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblExistencia>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Existencia");

                entity.HasIndex(e => e.Sku)
                    .HasName("IX_Tbl_Existencia");

                entity.HasIndex(e => new { e.Sku, e.IdUbicacion, e.CodMedida, e.UnidMed })
                    .HasName("IX_Tbl_Existencia_1");

                entity.Property(e => e.CodMedida)
                    .IsRequired()
                    .HasColumnName("Cod_Medida")
                    .HasMaxLength(10);

                entity.Property(e => e.IdUbicacion)
                    .IsRequired()
                    .HasColumnName("ID_Ubicacion")
                    .HasMaxLength(20);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblExistenciaIni>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_ExistenciaIni");

                entity.Property(e => e.CodMedida)
                    .IsRequired()
                    .HasColumnName("Cod_Medida")
                    .HasMaxLength(10);

                entity.Property(e => e.IdUbicacion)
                    .IsRequired()
                    .HasColumnName("ID_Ubicacion")
                    .HasMaxLength(20);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblExistenciaTda>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_ExistenciaTda");

                entity.HasIndex(e => e.Sku)
                    .HasName("sku_existenciatda");

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasColumnName("Cod_Ubicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblFdsordenCompra>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_FDSOrdenCompra");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.DocSapingreso)
                    .HasColumnName("DocSAPIngreso")
                    .HasMaxLength(25);

                entity.Property(e => e.DocSapsalida)
                    .HasColumnName("DocSAPSalida")
                    .HasMaxLength(25);

                entity.Property(e => e.DocSaptraslado)
                    .HasColumnName("DocSAPTraslado")
                    .HasMaxLength(25);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblFormaPago>(entity =>
            {
                entity.HasKey(e => e.CodForma);

                entity.ToTable("Tbl_FormaPago", "pos");

                entity.Property(e => e.CodForma)
                    .HasColumnName("Cod_Forma")
                    .ValueGeneratedNever();

                entity.Property(e => e.AcumulaPuntos)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AfectaTotal)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodSap)
                    .HasColumnName("CodSAP")
                    .HasMaxLength(10);

                entity.Property(e => e.NomCorto)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<TblFraseFel>(entity =>
            {
                entity.HasKey(e => new { e.CodTienda, e.CodMoneda, e.TipoFrase });

                entity.ToTable("Tbl_FraseFEL", "pos");

                entity.Property(e => e.CodTienda)
                    .HasColumnName("Cod_Tienda")
                    .HasMaxLength(10);

                entity.Property(e => e.CodMoneda)
                    .HasColumnName("Cod_Moneda")
                    .HasMaxLength(10);

                entity.Property(e => e.NomEscenario)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.NomFrase)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<TblGrupoArtDespCentral>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_GrupoArtDespCentral");

                entity.Property(e => e.CodEmpresa)
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.CodGrupo)
                    .HasColumnName("Cod_Grupo")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblGrupoArticulo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_GrupoArticulo");

                entity.Property(e => e.CodEmpresa)
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.CodGrupo)
                    .IsRequired()
                    .HasColumnName("Cod_Grupo")
                    .HasMaxLength(20);

                entity.Property(e => e.CodPadre)
                    .HasColumnName("Cod_Padre")
                    .HasMaxLength(20);

                entity.Property(e => e.Nombre).HasMaxLength(100);
            });

            modelBuilder.Entity<TblGrupoArticulo1>(entity =>
            {
                entity.HasKey(e => e.CodGrupo);

                entity.ToTable("Tbl_GrupoArticulo", "pos");

                entity.Property(e => e.CodGrupo)
                    .HasColumnName("Cod_Grupo")
                    .HasMaxLength(20);

                entity.Property(e => e.CodPadre)
                    .HasColumnName("Cod_Padre")
                    .HasMaxLength(20);

                entity.Property(e => e.Nombre).HasMaxLength(100);
            });

            modelBuilder.Entity<TblGrupoMarca>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_GrupoMarca");

                entity.Property(e => e.CodGrupo).HasColumnName("Cod_Grupo");

                entity.Property(e => e.Nombre).HasMaxLength(15);
            });

            modelBuilder.Entity<TblGuiaEnvio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_GuiaEnvio");

                entity.Property(e => e.CodDestino)
                    .HasColumnName("Cod_Destino")
                    .HasMaxLength(10);

                entity.Property(e => e.CodOrigen)
                    .HasColumnName("Cod_Origen")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTipoG).HasColumnName("Cod_TipoG");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("Id_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.NumGuia)
                    .IsRequired()
                    .HasColumnName("Num_Guia")
                    .HasMaxLength(25);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblIdtarjetaComision>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_IDTarjetaComision", "pos");

                entity.Property(e => e.IdtarjetaDesde)
                    .IsRequired()
                    .HasColumnName("IDTarjetaDesde")
                    .HasMaxLength(20);

                entity.Property(e => e.IdtarjetaHasta)
                    .IsRequired()
                    .HasColumnName("IDTarjetaHasta")
                    .HasMaxLength(20);

                entity.Property(e => e.MontoMax).HasColumnType("money");

                entity.Property(e => e.MontoMin).HasColumnType("money");
            });

            modelBuilder.Entity<TblImgArticulo>(entity =>
            {
                entity.HasKey(e => new { e.CodEmpresa, e.Sku })
                    .HasName("PKImg_Articulo");

                entity.ToTable("TblImg_Articulo");

                entity.Property(e => e.CodEmpresa)
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("URL")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<TblInterfazBloq>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_InterfazBloq");

                entity.Property(e => e.FechaB).HasColumnType("datetime");

                entity.Property(e => e.FechaL).HasColumnType("datetime");

                entity.Property(e => e.IdUsuarioB)
                    .IsRequired()
                    .HasColumnName("ID_UsuarioB")
                    .HasMaxLength(40);

                entity.Property(e => e.IdUsuarioL)
                    .HasColumnName("ID_UsuarioL")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<TblInventario>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Inventario");

                entity.Property(e => e.CodTipoDocIng).HasColumnName("Cod_TipoDocIng");

                entity.Property(e => e.CodTipoDocSal).HasColumnName("Cod_TipoDocSal");

                entity.Property(e => e.FechaFin).HasColumnType("datetime");

                entity.Property(e => e.FechaInic).HasColumnType("datetime");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.NumDocIng)
                    .HasColumnName("Num_DocIng")
                    .HasMaxLength(25);

                entity.Property(e => e.NumDocSal)
                    .HasColumnName("Num_DocSal")
                    .HasMaxLength(25);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblListaPrecios>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_ListaPrecios");

                entity.Property(e => e.CodLista).HasColumnName("Cod_Lista");

                entity.Property(e => e.Factor).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<TblLlamadaServ>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_LlamadaServ");

                entity.Property(e => e.CodEmpresa)
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.CodRazon).HasColumnName("Cod_Razon");

                entity.Property(e => e.CodSocio)
                    .IsRequired()
                    .HasColumnName("Cod_Socio")
                    .HasMaxLength(15);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTipoOrig).HasColumnName("Cod_TipoOrig");

                entity.Property(e => e.CodTipoPed).HasColumnName("Cod_TipoPed");

                entity.Property(e => e.Comentario)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.DocSap)
                    .HasColumnName("DocSAP")
                    .HasMaxLength(25);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaCierre).HasColumnType("datetime");

                entity.Property(e => e.FechaReg).HasColumnType("datetime");

                entity.Property(e => e.GuiaEnvio).HasMaxLength(25);

                entity.Property(e => e.IdUsrCierre)
                    .HasColumnName("ID_UsrCierre")
                    .HasMaxLength(40);

                entity.Property(e => e.IdUsrRecepcion)
                    .HasColumnName("ID_UsrRecepcion")
                    .HasMaxLength(10);

                entity.Property(e => e.NumDocOrig)
                    .HasColumnName("Num_DocOrig")
                    .HasMaxLength(25);

                entity.Property(e => e.NumDocPed)
                    .HasColumnName("Num_DocPed")
                    .HasMaxLength(25);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.NumeroFact).HasMaxLength(25);

                entity.Property(e => e.Recolectar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Resolucion)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Responsable)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SerieFact).HasMaxLength(10);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Total).HasColumnType("money");
            });

            modelBuilder.Entity<TblLogDevolucion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblLog_Devolucion");

                entity.Property(e => e.Accion)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodRazon).HasColumnName("Cod_Razon");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.NumeroDv)
                    .IsRequired()
                    .HasColumnName("NumeroDV")
                    .HasMaxLength(25);

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.SerieDv)
                    .HasColumnName("SerieDV")
                    .HasMaxLength(25);

                entity.Property(e => e.TipoDv)
                    .IsRequired()
                    .HasColumnName("TipoDV")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblLogDevolucionManual>(entity =>
            {
                entity.HasKey(e => new { e.TipoDv, e.SerieDv, e.NumeroDv });

                entity.ToTable("TblLog_DevolucionManual", "pos");

                entity.Property(e => e.TipoDv)
                    .HasColumnName("TipoDV")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SerieDv)
                    .HasColumnName("SerieDV")
                    .HasMaxLength(10);

                entity.Property(e => e.NumeroDv).HasColumnName("NumeroDV");

                entity.Property(e => e.Autorizador).HasMaxLength(40);

                entity.Property(e => e.FechaAut).HasColumnType("datetime");

                entity.Property(e => e.IdCaja)
                    .IsRequired()
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(15);

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.Property(e => e.Observaciones).HasMaxLength(100);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Supervisor)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<TblLogDocumentoCl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblLog_Documento_Cl", "pos");

                entity.Property(e => e.Documento)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.IdCaja)
                    .IsRequired()
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<TblLogTarjeta>(entity =>
            {
                entity.HasKey(e => new { e.IdCaja, e.Transaccion, e.FechaTransaccion })
                    .HasName("PK_Tbl_LogTarjeta");

                entity.ToTable("tbl_LogTarjeta", "pos");

                entity.Property(e => e.IdCaja)
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(15);

                entity.Property(e => e.Transaccion).HasColumnName("transaccion");

                entity.Property(e => e.FechaTransaccion)
                    .HasColumnName("fechaTransaccion")
                    .HasColumnType("datetime");

                entity.Property(e => e.CodAutorizador).HasColumnName("Cod_Autorizador");

                entity.Property(e => e.CodTienda)
                    .IsRequired()
                    .HasColumnName("Cod_tienda")
                    .HasMaxLength(10);

                entity.Property(e => e.FechaRespuesta)
                    .HasColumnName("fechaRespuesta")
                    .HasColumnType("datetime");

                entity.Property(e => e.TagImpresion).HasMaxLength(1000);

                entity.Property(e => e.Tipo).HasMaxLength(15);

                entity.Property(e => e.TrackRespuesta)
                    .HasColumnName("trackRespuesta")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<TblLogTarjetaSocio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_LogTarjetaSocio", "pos");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdAsociado)
                    .IsRequired()
                    .HasColumnName("ID_Asociado")
                    .HasMaxLength(25);

                entity.Property(e => e.IdCaja)
                    .IsRequired()
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(10);

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblLogTrasladoSap>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblLog_TrasladoSAP");

                entity.HasIndex(e => new { e.CodTipo, e.NumDocumento })
                    .HasName("Idx_LogTrasladoSAP");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.DatoLog)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Trasladable)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblLogTrasladoSap1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblLog_TrasladoSAP", "pos");

                entity.Property(e => e.CodTipoDoc).HasColumnName("Cod_TipoDoc");

                entity.Property(e => e.DatoLog)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdCaja)
                    .IsRequired()
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(15);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Trasladable)
                    .HasColumnName("trasladable")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblLogTrasladoSat>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblLog_TrasladoSAT", "pos");

                entity.Property(e => e.CodTienda)
                    .IsRequired()
                    .HasColumnName("Cod_Tienda")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipoDoc).HasColumnName("Cod_TipoDoc");

                entity.Property(e => e.DatoLog)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdCaja)
                    .IsRequired()
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(15);

                entity.Property(e => e.Numero).HasMaxLength(25);

                entity.Property(e => e.Serie).HasMaxLength(25);
            });

            modelBuilder.Entity<TblLogTrxTraslado>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblLog_TrxTraslado", "pos");

                entity.Property(e => e.Dbdest)
                    .IsRequired()
                    .HasColumnName("DBDest")
                    .HasMaxLength(40);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdCaja)
                    .IsRequired()
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(10);

                entity.Property(e => e.Mensaje)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.ServidorDest)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<TblMapaLogistico>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_MapaLogistico");

                entity.Property(e => e.CodBodega)
                    .IsRequired()
                    .HasColumnName("Cod_Bodega")
                    .HasMaxLength(10);

                entity.Property(e => e.IdUbicacion)
                    .IsRequired()
                    .HasColumnName("ID_Ubicacion")
                    .HasMaxLength(25);

                entity.Property(e => e.Pasillo)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblMarca>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Marca");

                entity.Property(e => e.CodMarca).HasColumnName("Cod_Marca");

                entity.Property(e => e.Nombre).HasMaxLength(100);
            });

            modelBuilder.Entity<TblMedida>(entity =>
            {
                entity.HasKey(e => e.CodMedida)
                    .HasName("PK__Tbl_Medida__76CBA758");

                entity.ToTable("Tbl_Medida");

                entity.Property(e => e.CodMedida)
                    .HasColumnName("Cod_Medida")
                    .HasMaxLength(5);

                entity.Property(e => e.CodPadre)
                    .HasColumnName("Cod_Padre")
                    .HasMaxLength(5);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblMedidaPrioridad>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_MedidaPrioridad");

                entity.Property(e => e.CodMedida)
                    .IsRequired()
                    .HasColumnName("Cod_Medida")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipoUbic).HasColumnName("Cod_TipoUbic");
            });

            modelBuilder.Entity<TblMenu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Menu");

                entity.Property(e => e.CodAplicacion)
                    .HasColumnName("Cod_Aplicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.CodMenu)
                    .IsRequired()
                    .HasColumnName("Cod_Menu")
                    .HasMaxLength(25);

                entity.Property(e => e.CodPadre)
                    .HasColumnName("Cod_Padre")
                    .HasMaxLength(25);

                entity.Property(e => e.Icono).HasMaxLength(100);

                entity.Property(e => e.Modo).HasMaxLength(5);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ToolTip).HasMaxLength(150);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("URL")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<TblMovBodega>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_MovBodega");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTipoMov).HasColumnName("Cod_TipoMov");

                entity.Property(e => e.CodTipoOrg).HasColumnName("Cod_TipoOrg");

                entity.Property(e => e.DocSap)
                    .HasColumnName("DocSAP")
                    .HasMaxLength(25);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaFin).HasColumnType("datetime");

                entity.Property(e => e.FechaIni).HasColumnType("datetime");

                entity.Property(e => e.IdUbicDest)
                    .HasColumnName("ID_UbicDest")
                    .HasMaxLength(25);

                entity.Property(e => e.IdUbicOrig)
                    .HasColumnName("ID_UbicOrig")
                    .HasMaxLength(25);

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.NumDocOrg)
                    .HasColumnName("Num_DocOrg")
                    .HasMaxLength(25);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<TblMunicipio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Municipio");

                entity.Property(e => e.CodDepartamento).HasColumnName("Cod_Departamento");

                entity.Property(e => e.CodDestinoGuatex)
                    .HasColumnName("Cod_DestinoGuatex")
                    .HasMaxLength(10);

                entity.Property(e => e.CodMunicipio).HasColumnName("Cod_Municipio");

                entity.Property(e => e.CodPais)
                    .IsRequired()
                    .HasColumnName("Cod_Pais")
                    .HasMaxLength(5);

                entity.Property(e => e.NomCorto)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.NomDestinoGuatex).HasMaxLength(100);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblNivelServicio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_NivelServicio");

                entity.Property(e => e.CodCliente)
                    .IsRequired()
                    .HasColumnName("Cod_Cliente")
                    .HasMaxLength(25);

                entity.Property(e => e.CodEmpresa)
                    .IsRequired()
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.CodGrupoM).HasColumnName("Cod_GrupoM");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTipoF).HasColumnName("Cod_TipoF");

                entity.Property(e => e.DocSap)
                    .IsRequired()
                    .HasColumnName("DocSAP")
                    .HasMaxLength(25);

                entity.Property(e => e.DocSapf)
                    .HasColumnName("DocSAPF")
                    .HasMaxLength(25);

                entity.Property(e => e.Emision).HasColumnType("datetime");

                entity.Property(e => e.Facturado).HasColumnType("money");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaF).HasColumnType("datetime");

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.NumDocumentoF)
                    .HasColumnName("Num_DocumentoF")
                    .HasMaxLength(25);

                entity.Property(e => e.Pedido).HasColumnType("money");
            });

            modelBuilder.Entity<TblOferta>(entity =>
            {
                entity.HasKey(e => new { e.Sku, e.CodLista, e.Desde, e.Hasta });

                entity.ToTable("Tbl_Oferta", "pos");

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(20);

                entity.Property(e => e.CodLista).HasColumnName("Cod_Lista");

                entity.Property(e => e.Desde).HasColumnType("datetime");

                entity.Property(e => e.Hasta).HasColumnType("datetime");

                entity.Property(e => e.CodCliente)
                    .IsRequired()
                    .HasColumnName("Cod_Cliente")
                    .HasMaxLength(15);

                entity.Property(e => e.Descuento).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NumPromocion)
                    .HasColumnName("Num_Promocion")
                    .HasMaxLength(15);

                entity.Property(e => e.Precio).HasColumnType("money");
            });

            modelBuilder.Entity<TblOfertaTda>(entity =>
            {
                entity.HasKey(e => new { e.Sku, e.CodLista, e.Desde, e.Hasta });

                entity.ToTable("Tbl_Oferta_Tda", "pos");

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(20);

                entity.Property(e => e.CodLista).HasColumnName("Cod_Lista");

                entity.Property(e => e.Desde).HasColumnType("datetime");

                entity.Property(e => e.Hasta).HasColumnType("datetime");

                entity.Property(e => e.CodCliente)
                    .IsRequired()
                    .HasColumnName("Cod_Cliente")
                    .HasMaxLength(15);

                entity.Property(e => e.Descuento).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NumPromocion)
                    .HasColumnName("Num_Promocion")
                    .HasMaxLength(15);

                entity.Property(e => e.Precio).HasColumnType("money");
            });

            modelBuilder.Entity<TblOla>(entity =>
            {
                entity.HasKey(e => e.NumOla)
                    .HasName("PK_Ola");

                entity.ToTable("Tbl_Ola");

                entity.HasIndex(e => e.Fecha)
                    .HasName("IX_Tbl_Ola_1");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Tbl_Ola");

                entity.Property(e => e.NumOla)
                    .HasColumnName("Num_Ola")
                    .HasMaxLength(25);

                entity.Property(e => e.CodCentroDist)
                    .HasColumnName("Cod_CentroDist")
                    .HasMaxLength(10);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.ModoCierre).HasMaxLength(1);

                entity.Property(e => e.ModoContab)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Procesada).HasColumnType("datetime");

                entity.Property(e => e.ReqAuditoria)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblOlaConfirmacion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_OlaConfirmacion");

                entity.Property(e => e.NumOla)
                    .HasColumnName("Num_Ola")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblOlaTransporte>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_OlaTransporte");

                entity.Property(e => e.NumOla)
                    .IsRequired()
                    .HasColumnName("Num_Ola")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblOperacionCaja>(entity =>
            {
                entity.HasKey(e => new { e.NumOperacion, e.IdCaja });

                entity.ToTable("Tbl_OperacionCaja", "pos");

                entity.Property(e => e.NumOperacion)
                    .HasColumnName("Num_Operacion")
                    .HasMaxLength(25);

                entity.Property(e => e.IdCaja)
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(15);

                entity.Property(e => e.CodTienda)
                    .IsRequired()
                    .HasColumnName("Cod_Tienda")
                    .HasMaxLength(10);

                entity.Property(e => e.FechaApertura).HasColumnType("datetime");

                entity.Property(e => e.FechaCierre).HasColumnType("datetime");

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.IdUsuarioCierre)
                    .HasColumnName("ID_UsuarioCierre")
                    .HasMaxLength(40);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblOprTrasladable>(entity =>
            {
                entity.HasKey(e => new { e.IdCaja, e.Operacion, e.Fecha });

                entity.ToTable("Tbl_OprTrasladable", "pos");

                entity.Property(e => e.IdCaja)
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(15);

                entity.Property(e => e.Operacion).HasMaxLength(15);

                entity.Property(e => e.Fecha).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblOprTrasladada>(entity =>
            {
                entity.HasKey(e => new { e.IdCaja, e.Operacion, e.ServidorDest, e.Dbdest });

                entity.ToTable("Tbl_OprTrasladada", "pos");

                entity.Property(e => e.IdCaja)
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(15);

                entity.Property(e => e.Operacion).HasMaxLength(15);

                entity.Property(e => e.ServidorDest).HasMaxLength(40);

                entity.Property(e => e.Dbdest)
                    .HasColumnName("DBDest")
                    .HasMaxLength(40);

                entity.Property(e => e.Fecha).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblOrdenCompra>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_OrdenCompra");

                entity.Property(e => e.CodBodega)
                    .HasColumnName("Cod_Bodega")
                    .HasMaxLength(10);

                entity.Property(e => e.CodEmpresa)
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.CodSocio)
                    .IsRequired()
                    .HasColumnName("Cod_Socio")
                    .HasMaxLength(15);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.DocSap)
                    .HasColumnName("DocSAP")
                    .HasMaxLength(25);

                entity.Property(e => e.Embarque)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaReg).HasColumnType("datetime");

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Total).HasColumnType("money");
            });

            modelBuilder.Entity<TblPais>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Pais");

                entity.Property(e => e.CodPais)
                    .IsRequired()
                    .HasColumnName("Cod_Pais")
                    .HasMaxLength(5);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblParametro>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Parametro");

                entity.Property(e => e.CodParametro).HasColumnName("Cod_Parametro");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Valor).HasMaxLength(1000);
            });

            modelBuilder.Entity<TblPedido>(entity =>
            {
                entity.HasKey(e => new { e.CodTipo, e.NumDocumento })
                    .HasName("PK_Pedido");

                entity.ToTable("Tbl_Pedido");

                entity.HasIndex(e => e.Fecha)
                    .HasName("Idx_PedidoFecha");

                entity.HasIndex(e => e.NumDocumento)
                    .HasName("idx_20191219_Num_Documento");

                entity.HasIndex(e => e.NumOla)
                    .HasName("IX_Tbl_Pedido");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Tbl_Pedido_1");

                entity.HasIndex(e => new { e.CodEmpresa, e.CodTipo, e.DocSap })
                    .HasName("Idx_Tbl_Pedido_CL4");

                entity.HasIndex(e => new { e.CodSocio, e.Fecha, e.Status })
                    .HasName("<Cod_Socio,fecha,Status>");

                entity.HasIndex(e => new { e.NumDocumento, e.CodCentroDist, e.CodTipo, e.Status })
                    .HasName("<cod_tipo,status>");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.NumDocumento)
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.CodCentroDist)
                    .HasColumnName("Cod_CentroDist")
                    .HasMaxLength(10);

                entity.Property(e => e.CodDestinatario)
                    .IsRequired()
                    .HasColumnName("Cod_Destinatario")
                    .HasMaxLength(50);

                entity.Property(e => e.CodEmpresa)
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.CodSocio)
                    .HasColumnName("Cod_Socio")
                    .HasMaxLength(50);

                entity.Property(e => e.CodTipoCred).HasColumnName("Cod_TipoCred");

                entity.Property(e => e.CodTipoRuta).HasColumnName("Cod_TipoRuta");

                entity.Property(e => e.Comentarios).HasColumnType("text");

                entity.Property(e => e.Descuento).HasColumnType("money");

                entity.Property(e => e.DocSap)
                    .HasColumnName("DocSAP")
                    .HasMaxLength(25);

                entity.Property(e => e.Emision).HasColumnType("datetime");

                entity.Property(e => e.Factura).HasMaxLength(25);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaFact).HasColumnType("datetime");

                entity.Property(e => e.FechaReg).HasColumnType("datetime");

                entity.Property(e => e.FinAuditoria).HasColumnType("datetime");

                entity.Property(e => e.IniAuditoria).HasColumnType("datetime");

                entity.Property(e => e.NumDocumentoHh)
                    .HasColumnName("Num_DocumentoHH")
                    .HasMaxLength(25);

                entity.Property(e => e.NumOla)
                    .HasColumnName("Num_Ola")
                    .HasMaxLength(25);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Total).HasColumnType("money");
            });

            modelBuilder.Entity<TblPedidoCd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_PedidoCD");

                entity.Property(e => e.CodBodega)
                    .IsRequired()
                    .HasColumnName("Cod_Bodega")
                    .HasMaxLength(10);

                entity.Property(e => e.CodEmpresa)
                    .IsRequired()
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblPedidoComp>(entity =>
            {
                entity.HasKey(e => new { e.CodTipo, e.NumDocumento })
                    .HasName("PK_PedidoComp");

                entity.ToTable("Tbl_PedidoComp");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.NumDocumento)
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.CodEmpresa)
                    .IsRequired()
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.Fecha).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblPedidoConf>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_PedidoConf");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblPedidoEmpaque>(entity =>
            {
                entity.HasKey(e => new { e.NumEmpaque, e.CodTipo, e.NumDocumento })
                    .HasName("PK_PedidoEmpaque");

                entity.ToTable("Tbl_PedidoEmpaque");

                entity.HasIndex(e => new { e.CodTipo, e.NumDocumento })
                    .HasName("Cod_Tipo,Num_Documento>");

                entity.Property(e => e.NumEmpaque)
                    .HasColumnName("Num_Empaque")
                    .HasMaxLength(25);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.NumDocumento)
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.CodEmpresa)
                    .IsRequired()
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.DocSap)
                    .HasColumnName("DocSAP")
                    .HasMaxLength(25);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaSap)
                    .HasColumnName("FechaSAP")
                    .HasColumnType("datetime");

                entity.Property(e => e.Guia).HasMaxLength(25);

                entity.Property(e => e.IdEmbalador)
                    .HasColumnName("ID_Embalador")
                    .HasMaxLength(40);

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.Licencia).HasMaxLength(25);

                entity.Property(e => e.Puerta).HasMaxLength(25);

                entity.Property(e => e.Tguia).HasColumnName("TGuia");
            });

            modelBuilder.Entity<TblPedidoEmpaqueEnt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_PedidoEmpaqueEnt");

                entity.HasIndex(e => new { e.FechaPrimeraEntrega, e.NumEmpaque })
                    .HasName("<[Num_Empaque>");

                entity.Property(e => e.FechaEnt).HasColumnType("datetime");

                entity.Property(e => e.FechaPrimeraEntrega).HasColumnType("datetime");

                entity.Property(e => e.NumEmpaque)
                    .IsRequired()
                    .HasColumnName("Num_Empaque")
                    .HasMaxLength(25);

                entity.Property(e => e.Recibio)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<TblPedidoEntTienda>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_PedidoEntTienda");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.NumLlamadaNc)
                    .HasColumnName("Num_LlamadaNC")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblPedidoEntregaTda>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_PedidoEntregaTDA");

                entity.Property(e => e.CodEmpresa)
                    .IsRequired()
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.FechaEnt).HasColumnType("datetime");

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Recibio)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<TblPedidoGrabacion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_PedidoGrabacion");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.ModoIngreso)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblPedidoHojaAudit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_PedidoHojaAudit");

                entity.Property(e => e.CodEmpresa)
                    .IsRequired()
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaImp).HasColumnType("datetime");

                entity.Property(e => e.IdUsrImp)
                    .IsRequired()
                    .HasColumnName("ID_UsrImp")
                    .HasMaxLength(40);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblPedidoOla>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_PedidoOla");

                entity.HasIndex(e => e.NumOla)
                    .HasName("Idx_PedidoOla1");

                entity.HasIndex(e => new { e.CodTipo, e.NumDocumento })
                    .HasName("Idx_PedidoOla2");

                entity.Property(e => e.CodBodega)
                    .IsRequired()
                    .HasColumnName("Cod_Bodega")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.NumOla)
                    .IsRequired()
                    .HasColumnName("Num_Ola")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblPedidoOnHold>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_PedidoOnHold");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.FechaBloqueo).HasColumnType("datetime");

                entity.Property(e => e.FechaLiber).HasColumnType("datetime");

                entity.Property(e => e.IdUsrBloqueo)
                    .IsRequired()
                    .HasColumnName("ID_UsrBloqueo")
                    .HasMaxLength(40);

                entity.Property(e => e.IdUsrLiber)
                    .HasColumnName("ID_UsrLiber")
                    .HasMaxLength(40);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblPedidoPacking>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_PedidoPacking");

                entity.HasIndex(e => new { e.CodTipo, e.NumDocumento })
                    .HasName("<Cod_Tipo,Num_Documento>");

                entity.Property(e => e.CodEmpresa)
                    .IsRequired()
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaImp).HasColumnType("datetime");

                entity.Property(e => e.IdUsrImp)
                    .HasColumnName("ID_UsrImp")
                    .HasMaxLength(40);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblPedidoProvLocal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_PedidoProvLocal");

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(100);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.NumOrdenCompra)
                    .IsRequired()
                    .HasColumnName("Num_OrdenCompra")
                    .HasMaxLength(25);

                entity.Property(e => e.NumPedido)
                    .HasColumnName("Num_Pedido")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblPedidoStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_PedidoStatus");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaEcom)
                    .HasColumnName("FechaECom")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblPedidoStatusVtex>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_PedidoStatusVTex");

                entity.Property(e => e.CodEstado).HasColumnName("Cod_Estado");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaEcom)
                    .HasColumnName("FechaECom")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblPedidoVtex>(entity =>
            {
                entity.HasKey(e => new { e.CodEmpresa, e.CodTipo, e.NumDocumento })
                    .HasName("PK_PedidoVTex");

                entity.ToTable("Tbl_PedidoVTex");

                entity.Property(e => e.CodEmpresa)
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.NumDocumento)
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Carrier).HasMaxLength(25);

                entity.Property(e => e.CodEstado).HasColumnName("Cod_Estado");

                entity.Property(e => e.Dock).HasMaxLength(25);

                entity.Property(e => e.Secuencia).HasMaxLength(25);
            });

            modelBuilder.Entity<TblPerfil>(entity =>
            {
                entity.HasKey(e => e.CodPerfil)
                    .HasName("PK__Tbl_Perfil__5BE2A6F2");

                entity.ToTable("Tbl_Perfil");

                entity.Property(e => e.CodPerfil)
                    .HasColumnName("Cod_Perfil")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre).HasMaxLength(50);
            });

            modelBuilder.Entity<TblPeriodo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Periodo");

                entity.Property(e => e.BaseMinima).HasColumnType("money");

                entity.Property(e => e.BonoVe)
                    .HasColumnName("BonoVE")
                    .HasColumnType("money");

                entity.Property(e => e.CuotaEspecificos).HasColumnType("money");

                entity.Property(e => e.NuevosBase)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NuevosCobertura)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RecordVe).HasColumnName("RecordVE");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblPermiso>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Permiso");

                entity.Property(e => e.Altas)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Bajas)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cambios)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodAplicacion)
                    .IsRequired()
                    .HasColumnName("Cod_Aplicacion")
                    .HasMaxLength(15);

                entity.Property(e => e.CodPerfil).HasColumnName("Cod_Perfil");

                entity.Property(e => e.Ejecutar)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblPersonal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Personal");

                entity.Property(e => e.Celular).HasMaxLength(20);

                entity.Property(e => e.CodEmpresa)
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(100);

                entity.Property(e => e.IdPersonal)
                    .IsRequired()
                    .HasColumnName("ID_Personal")
                    .HasMaxLength(15);

                entity.Property(e => e.IdSupervisor)
                    .HasColumnName("ID_Supervisor")
                    .HasMaxLength(15);

                entity.Property(e => e.Nombre).HasMaxLength(100);

                entity.Property(e => e.Region).HasMaxLength(100);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblProveedorLocal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_ProveedorLocal");

                entity.Property(e => e.CodProveedor)
                    .IsRequired()
                    .HasColumnName("Cod_Proveedor")
                    .HasMaxLength(25);

                entity.Property(e => e.Email).HasColumnName("EMail");

                entity.Property(e => e.HoraCorte1)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.HoraCorte2)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Modo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UltimoCorte)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblRazonLlamada>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_RazonLlamada");

                entity.Property(e => e.CodRazon).HasColumnName("Cod_Razon");

                entity.Property(e => e.CodRazonNc).HasColumnName("Cod_RazonNC");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ReqRecepcion)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblReclamo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Reclamo");

                entity.Property(e => e.CodEmpresa)
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.CodSocio)
                    .IsRequired()
                    .HasColumnName("Cod_Socio")
                    .HasMaxLength(15);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.Comentario)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.DocSap)
                    .HasColumnName("DocSAP")
                    .HasMaxLength(25);

                entity.Property(e => e.FacturaAfecta)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FacturaOrigen)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaAut).HasColumnType("datetime");

                entity.Property(e => e.FechaReg).HasColumnType("datetime");

                entity.Property(e => e.IdAutorizador)
                    .HasColumnName("ID_Autorizador")
                    .HasMaxLength(40);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.Resolucion)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<TblRegaloRemplazo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_RegaloRemplazo");

                entity.Property(e => e.AnulacionEnvio).HasColumnType("datetime");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.NumLlamadaServ)
                    .IsRequired()
                    .HasColumnName("Num_LLamadaServ")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblRequerimiento>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Requerimiento");

                entity.HasIndex(e => e.NumDocumento)
                    .HasName("<Num_Documento>");

                entity.HasIndex(e => e.NumRequerimiento)
                    .HasName("IX_Tbl_Requerimiento");

                entity.HasIndex(e => new { e.CodTipo, e.NumDocumento, e.Linea, e.Sku })
                    .HasName("idx_tipo_docto_linea_sku");

                entity.Property(e => e.CodTienda)
                    .IsRequired()
                    .HasColumnName("Cod_Tienda")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTipoDocUbic).HasColumnName("Cod_TipoDocUbic");

                entity.Property(e => e.DocSap)
                    .HasColumnName("DocSAP")
                    .HasMaxLength(250);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaAudit).HasColumnType("datetime");

                entity.Property(e => e.FechaConf).HasColumnType("datetime");

                entity.Property(e => e.FechaRecep).HasColumnType("datetime");

                entity.Property(e => e.IdUbicRecep)
                    .HasColumnName("ID_UbicRecep")
                    .HasMaxLength(25);

                entity.Property(e => e.IdUsuarioAudit)
                    .HasColumnName("ID_UsuarioAudit")
                    .HasMaxLength(40);

                entity.Property(e => e.IdUsuarioConf)
                    .HasColumnName("ID_UsuarioConf")
                    .HasMaxLength(40);

                entity.Property(e => e.IdUsuarioRecep)
                    .HasColumnName("ID_UsuarioRecep")
                    .HasMaxLength(40);

                entity.Property(e => e.MsgError).HasColumnType("text");

                entity.Property(e => e.NumDocUbic)
                    .HasColumnName("Num_DocUbic")
                    .HasMaxLength(25);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.NumRequerimiento)
                    .IsRequired()
                    .HasColumnName("Num_Requerimiento")
                    .HasMaxLength(25);

                entity.Property(e => e.NumTraslado)
                    .HasColumnName("Num_Traslado")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblResolucionDoc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_ResolucionDoc");

                entity.Property(e => e.CodEmpresa)
                    .IsRequired()
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CorrelActual).HasColumnName("Correl_Actual");

                entity.Property(e => e.CorrelFinal).HasColumnName("Correl_Final");

                entity.Property(e => e.CorrelInicial).HasColumnName("Correl_Inicial");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaAut).HasColumnType("datetime");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("Id_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.ModoFe)
                    .HasColumnName("ModoFE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Resolucion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Serie).HasMaxLength(5);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblRetiroEfectivo>(entity =>
            {
                entity.HasKey(e => new { e.NumRetiro, e.NumOperacion });

                entity.ToTable("Tbl_RetiroEfectivo", "pos");

                entity.Property(e => e.NumRetiro)
                    .HasColumnName("Num_Retiro")
                    .HasMaxLength(25);

                entity.Property(e => e.NumOperacion)
                    .HasColumnName("Num_Operacion")
                    .HasMaxLength(25);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<TblRutaDespDefault>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_RutaDespDefault");

                entity.Property(e => e.CodBodega)
                    .IsRequired()
                    .HasColumnName("Cod_Bodega")
                    .HasMaxLength(10);

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.IdUsuarioResp)
                    .HasColumnName("ID_UsuarioResp")
                    .HasMaxLength(40);

                entity.Property(e => e.Modo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ModoResp)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Pasillo)
                    .IsRequired()
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<TblRutaDespacho>(entity =>
            {
                entity.HasKey(e => new { e.NumOla, e.Idx })
                    .HasName("PK_RutaDespacho");

                entity.ToTable("Tbl_RutaDespacho");

                entity.Property(e => e.NumOla)
                    .HasColumnName("Num_Ola")
                    .HasMaxLength(25);

                entity.Property(e => e.CodBodega)
                    .IsRequired()
                    .HasColumnName("Cod_Bodega")
                    .HasMaxLength(10);

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.IdUsuarioResp)
                    .HasColumnName("ID_UsuarioResp")
                    .HasMaxLength(40);

                entity.Property(e => e.Modo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ModoResp)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Pasillo)
                    .IsRequired()
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<TblSerieDocSap>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_SerieDocSAP");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.SerieSbo).HasColumnName("SerieSBO");
            });

            modelBuilder.Entity<TblSerieDocs>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_SerieDocs");

                entity.Property(e => e.CodEmpresa)
                    .IsRequired()
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.NomTipoDoc)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblSocioNeg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_SocioNeg");

                entity.HasIndex(e => e.CodSocio)
                    .HasName("idx_20191219_cod_socio");

                entity.HasIndex(e => e.Tipo)
                    .HasName("Idx_SocioNegTipo");

                entity.HasIndex(e => new { e.CodSocio, e.Email })
                    .HasName("<EMail>");

                entity.Property(e => e.Ciudad).HasMaxLength(100);

                entity.Property(e => e.CiudadPostal).HasMaxLength(100);

                entity.Property(e => e.CodEmpresa)
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.CodMoneda)
                    .HasColumnName("Cod_Moneda")
                    .HasMaxLength(3);

                entity.Property(e => e.CodSocio)
                    .HasColumnName("Cod_Socio")
                    .HasMaxLength(50);

                entity.Property(e => e.CodTipoCred).HasColumnName("Cod_TipoCred");

                entity.Property(e => e.CodTransporte)
                    .HasColumnName("Cod_Transporte")
                    .HasMaxLength(25);

                entity.Property(e => e.CodVendedor)
                    .HasColumnName("Cod_Vendedor")
                    .HasMaxLength(15);

                entity.Property(e => e.Contacto).HasMaxLength(90);

                entity.Property(e => e.CreditoTransp).HasMaxLength(25);

                entity.Property(e => e.Direccion).HasMaxLength(100);

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(100);

                entity.Property(e => e.Fax).HasMaxLength(20);

                entity.Property(e => e.HoraVisita).HasMaxLength(10);

                entity.Property(e => e.Nit)
                    .HasColumnName("NIT")
                    .HasMaxLength(20);

                entity.Property(e => e.Nombre).HasMaxLength(100);

                entity.Property(e => e.OlaAuto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Postal).HasMaxLength(100);

                entity.Property(e => e.Sociedad).HasMaxLength(100);

                entity.Property(e => e.Telefono1).HasMaxLength(20);

                entity.Property(e => e.Telefono2).HasMaxLength(20);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Zip)
                    .HasColumnName("ZIP")
                    .HasMaxLength(20);

                entity.Property(e => e.Zippostal)
                    .HasColumnName("ZIPPostal")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TblTablaSinc>(entity =>
            {
                entity.HasKey(e => new { e.Tabla, e.Modulo });

                entity.ToTable("Tbl_TablaSinc", "pos");

                entity.Property(e => e.Tabla).HasMaxLength(100);

                entity.Property(e => e.Modulo).HasMaxLength(50);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblTarimaTransporte>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_TarimaTransporte");

                entity.HasIndex(e => e.Tarima)
                    .HasName("Idx_TarimaTransporte");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.Tarima)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Transporte)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblTiempoTemporal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_TiempoTemporal");

                entity.Property(e => e.EndLmtd)
                    .HasColumnName("END-LMTD")
                    .HasMaxLength(34)
                    .IsUnicode(false);

                entity.Property(e => e.EndLytd)
                    .HasColumnName("END-LYTD")
                    .HasMaxLength(34)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Mtd)
                    .HasColumnName("MTD")
                    .HasMaxLength(34)
                    .IsUnicode(false);

                entity.Property(e => e.StartLmtd)
                    .HasColumnName("START-LMTD")
                    .HasMaxLength(62)
                    .IsUnicode(false);

                entity.Property(e => e.StartLw)
                    .HasColumnName("START-LW")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StartLytd)
                    .HasColumnName("START-LYTD")
                    .HasMaxLength(34)
                    .IsUnicode(false);

                entity.Property(e => e.Ytd)
                    .HasColumnName("YTD")
                    .HasMaxLength(34)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTienda>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Tienda");

                entity.Property(e => e.CodCentroDist)
                    .HasColumnName("Cod_CentroDist")
                    .HasMaxLength(10);

                entity.Property(e => e.CodEmpresa)
                    .IsRequired()
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.CodEstado)
                    .HasColumnName("Cod_Estado")
                    .HasMaxLength(10);

                entity.Property(e => e.CodMunicipio)
                    .HasColumnName("Cod_Municipio")
                    .HasMaxLength(10);

                entity.Property(e => e.CodPais)
                    .HasColumnName("Cod_Pais")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTienda)
                    .IsRequired()
                    .HasColumnName("Cod_Tienda")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.DespEcom)
                    .HasColumnName("DespECom")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdvtexPickUpPt)
                    .HasColumnName("IDVTex_PickUpPt")
                    .HasMaxLength(25);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NombreEcom).HasMaxLength(250);

                entity.Property(e => e.Zona).HasMaxLength(10);
            });

            modelBuilder.Entity<TblTiendaAutTarjeta>(entity =>
            {
                entity.HasKey(e => new { e.CodAutorizador, e.CodTienda });

                entity.ToTable("Tbl_TiendaAutTarjeta", "pos");

                entity.Property(e => e.CodAutorizador).HasColumnName("Cod_Autorizador");

                entity.Property(e => e.CodTienda)
                    .HasColumnName("Cod_Tienda")
                    .HasMaxLength(10);

                entity.Property(e => e.Afiliacion)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.AfiliacionMan)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.AfiliacionPos)
                    .IsRequired()
                    .HasColumnName("AfiliacionPOS")
                    .HasMaxLength(25);

                entity.Property(e => e.ComisionPos).HasColumnName("ComisionPOS");

                entity.Property(e => e.Ipservidor)
                    .HasColumnName("IPServidor")
                    .HasMaxLength(100);

                entity.Property(e => e.Modo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PuertoServidor)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<TblTiendaSat>(entity =>
            {
                entity.HasKey(e => new { e.CodTienda, e.Idx });

                entity.ToTable("Tbl_TiendaSAT", "pos");

                entity.Property(e => e.CodTienda)
                    .HasColumnName("Cod_Tienda")
                    .HasMaxLength(10);

                entity.Property(e => e.CodEmpresaFel)
                    .HasColumnName("CodEmpresaFEL")
                    .HasMaxLength(50);

                entity.Property(e => e.CodSucursal)
                    .HasColumnName("Cod_Sucursal")
                    .HasMaxLength(10);

                entity.Property(e => e.Departamento)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Lenguaje)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.MonedaLocal).HasMaxLength(5);

                entity.Property(e => e.Municipio)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Nit)
                    .HasColumnName("NIT")
                    .HasMaxLength(10);

                entity.Property(e => e.NitGface)
                    .HasColumnName("NitGFace")
                    .HasMaxLength(50);

                entity.Property(e => e.NomGface)
                    .HasColumnName("NomGFace")
                    .HasMaxLength(200);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.Pais)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.RazonSocial).HasMaxLength(80);

                entity.Property(e => e.Token1).HasMaxLength(50);

                entity.Property(e => e.Token2).HasMaxLength(50);

                entity.Property(e => e.UrlcertificadoFel)
                    .HasColumnName("URLCertificadoFEL")
                    .HasMaxLength(100);

                entity.Property(e => e.Urlfel)
                    .HasColumnName("URLFEL")
                    .HasMaxLength(100);

                entity.Property(e => e.UrlfelAnulacion)
                    .HasColumnName("URLFEL_Anulacion")
                    .HasMaxLength(100);

                entity.Property(e => e.UsuarioFel)
                    .HasColumnName("UsuarioFEL")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblTipoAccion>(entity =>
            {
                entity.HasKey(e => e.CodTipo)
                    .HasName("PK_TipoAccion");

                entity.ToTable("Tbl_TipoAccion");

                entity.Property(e => e.CodTipo)
                    .HasColumnName("Cod_Tipo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblTipoCd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_TipoCD");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblTipoCertificado>(entity =>
            {
                entity.HasKey(e => e.CodTipo);

                entity.ToTable("Tbl_TipoCertificado", "pos");

                entity.Property(e => e.CodTipo)
                    .HasColumnName("Cod_Tipo")
                    .ValueGeneratedNever();

                entity.Property(e => e.CodCupon)
                    .HasColumnName("Cod_Cupon")
                    .HasMaxLength(20);

                entity.Property(e => e.CodFormaPago).HasColumnName("Cod_FormaPago");

                entity.Property(e => e.CodSap)
                    .HasColumnName("CodSAP")
                    .HasMaxLength(10);

                entity.Property(e => e.MontoFijo).HasColumnType("money");

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TextoFact).HasMaxLength(30);

                entity.Property(e => e.UtilizaRango)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblTipoCredito>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_TipoCredito");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblTipoDescuento>(entity =>
            {
                entity.HasKey(e => new { e.CodTipo, e.Idx });

                entity.ToTable("Tbl_TipoDescuento", "pos");

                entity.Property(e => e.CodTipo)
                    .HasColumnName("Cod_Tipo")
                    .HasMaxLength(25);

                entity.Property(e => e.CodCliente)
                    .HasColumnName("Cod_Cliente")
                    .HasMaxLength(150);

                entity.Property(e => e.CodGrupo)
                    .HasColumnName("Cod_Grupo")
                    .HasMaxLength(20);

                entity.Property(e => e.CodTipoOrg)
                    .HasColumnName("Cod_TipoOrg")
                    .HasMaxLength(25);

                entity.Property(e => e.DescuentosobreDescuento).HasMaxLength(1);

                entity.Property(e => e.Desde).HasColumnType("datetime");

                entity.Property(e => e.Franquear)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hasta).HasColumnType("datetime");

                entity.Property(e => e.Idtarjeta)
                    .HasColumnName("IDTarjeta")
                    .HasMaxLength(50);

                entity.Property(e => e.IdtarjetaHasta)
                    .HasColumnName("IDTarjeta_Hasta")
                    .HasMaxLength(16);

                entity.Property(e => e.Imprimir)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IncluyeLista)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IncluyeOfertas).HasMaxLength(1);

                entity.Property(e => e.Modo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ModoExclusion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.Property(e => e.MontoFijoDesc).HasColumnType("money");

                entity.Property(e => e.MontoLimite).HasColumnType("money");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OfertasobreOferta).HasMaxLength(1);

                entity.Property(e => e.Precedencia).HasMaxLength(1);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoLista)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ValidaReplica)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblTipoDocumento>(entity =>
            {
                entity.HasKey(e => new { e.CodEmpresa, e.CodTipo })
                    .HasName("PK__Tbl_TipoDocument__20C1E124");

                entity.ToTable("Tbl_TipoDocumento");

                entity.Property(e => e.CodEmpresa)
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(50);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CorrelActual).HasColumnName("Correl_Actual");

                entity.Property(e => e.Impresora).HasMaxLength(100);

                entity.Property(e => e.NomCorto).HasMaxLength(15);

                entity.Property(e => e.Nombre).HasMaxLength(100);

                entity.Property(e => e.Serie).HasMaxLength(5);
            });

            modelBuilder.Entity<TblTipoEnvoltorio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_TipoEnvoltorio");

                entity.Property(e => e.CodTipo)
                    .IsRequired()
                    .HasColumnName("Cod_Tipo")
                    .HasMaxLength(25);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblTipoMailZdesk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_TipoMailZDesk");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CopiaOculta)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Destinatario)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblTipoMovBodega>(entity =>
            {
                entity.HasKey(e => e.CodTipo)
                    .HasName("PK__Tbl_TipoMovBodeg__619B8048");

                entity.ToTable("Tbl_TipoMovBodega");

                entity.Property(e => e.CodTipo)
                    .HasColumnName("Cod_Tipo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Interfaz)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.Operacion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblTipoRuta>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_TipoRuta");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ImprimeRecibo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OlaAuto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tamarillo).HasColumnName("TAmarillo");

                entity.Property(e => e.Trojo).HasColumnName("TRojo");
            });

            modelBuilder.Entity<TblTipoRutaOld>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_TipoRutaOld");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ImprimeRecibo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OlaAuto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tamarillo).HasColumnName("TAmarillo");

                entity.Property(e => e.Trojo).HasColumnName("TRojo");
            });

            modelBuilder.Entity<TblTipoTarRegalo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_TipoTarRegalo", "pos");

                entity.Property(e => e.CanjeParcial)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.Idtarjeta)
                    .IsRequired()
                    .HasColumnName("IDTarjeta")
                    .HasMaxLength(8);

                entity.Property(e => e.Imagen).HasColumnType("image");

                entity.Property(e => e.MontoFijo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(20);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ValorTarjeta).HasColumnType("money");
            });

            modelBuilder.Entity<TblTipoTienda>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_TipoTienda");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblTipoUbicacion>(entity =>
            {
                entity.HasKey(e => e.CodTipo)
                    .HasName("PK__tbl_TipoUbicacio__15502E78");

                entity.ToTable("Tbl_TipoUbicacion");

                entity.Property(e => e.CodTipo)
                    .HasColumnName("Cod_Tipo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bloqueado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Categorias).HasMaxLength(50);

                entity.Property(e => e.Danado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MezclaOla)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PermiteAuditoria)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PermiteDespacho)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PermiteIngreso)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PermiteRegalos)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PermiteUbicacion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblTransaccional>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Transaccional");

                entity.Property(e => e.CodEmpresa)
                    .IsRequired()
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.Destinatario)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoTransaccional)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblTransporte>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Transporte");

                entity.Property(e => e.CodTransporte)
                    .IsRequired()
                    .HasColumnName("Cod_Transporte")
                    .HasMaxLength(25);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblTraslado>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Traslado");

                entity.Property(e => e.CodTienda)
                    .IsRequired()
                    .HasColumnName("Cod_Tienda")
                    .HasMaxLength(10);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.NumTraslado)
                    .IsRequired()
                    .HasColumnName("Num_Traslado")
                    .HasMaxLength(25);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblTrxSocio>(entity =>
            {
                entity.HasKey(e => new { e.IdCaja, e.Transaccion, e.StatusFact });

                entity.ToTable("Tbl_TrxSocio", "pos");

                entity.Property(e => e.IdCaja)
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(15);

                entity.Property(e => e.StatusFact)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodTienda)
                    .IsRequired()
                    .HasColumnName("Cod_Tienda")
                    .HasMaxLength(10);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblTrxTrasladable>(entity =>
            {
                entity.HasKey(e => new { e.IdCaja, e.Transaccion });

                entity.ToTable("Tbl_TrxTrasladable", "pos");

                entity.Property(e => e.IdCaja)
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(15);

                entity.Property(e => e.Fecha).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblTrxTrasladada>(entity =>
            {
                entity.HasKey(e => new { e.IdCaja, e.Transaccion, e.ServidorDest });

                entity.ToTable("Tbl_TrxTrasladada", "pos");

                entity.Property(e => e.IdCaja)
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(15);

                entity.Property(e => e.ServidorDest).HasMaxLength(40);

                entity.Property(e => e.Dbdest)
                    .IsRequired()
                    .HasColumnName("DBDest")
                    .HasMaxLength(40);

                entity.Property(e => e.Fecha).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblUbicacion>(entity =>
            {
                entity.HasKey(e => new { e.IdUbicacion, e.CodTipo })
                    .HasName("PK_Ubicacion");

                entity.ToTable("Tbl_Ubicacion");

                entity.HasIndex(e => new { e.IdUbicacion, e.CodTipo })
                    .HasName("Z_Idx_TblDet_Ola_CL1");

                entity.Property(e => e.IdUbicacion)
                    .HasColumnName("ID_Ubicacion")
                    .HasMaxLength(25);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodBodega)
                    .IsRequired()
                    .HasColumnName("Cod_Bodega")
                    .HasMaxLength(10);

                entity.Property(e => e.Licencia)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Nivel)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.NivelRack)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Pasillo)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Rack)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblUbicacionGrupo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_UbicacionGrupo");

                entity.Property(e => e.CodEmpresa)
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.CodGrupo)
                    .IsRequired()
                    .HasColumnName("Cod_Grupo")
                    .HasMaxLength(25);

                entity.Property(e => e.IdUbicacion)
                    .IsRequired()
                    .HasColumnName("ID_Ubicacion")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblUbicacionWms>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_UbicacionWMS");

                entity.Property(e => e.CodBodega)
                    .IsRequired()
                    .HasColumnName("Cod_Bodega")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.IdUbicacion)
                    .IsRequired()
                    .HasColumnName("ID_Ubicacion")
                    .HasMaxLength(25);

                entity.Property(e => e.Licencia)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Nivel)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.NivelRack)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Pasillo)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Rack)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblUsuario>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Usuario");

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("Id_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(70);
            });

            modelBuilder.Entity<TblVentaTiempoAire>(entity =>
            {
                entity.HasKey(e => new { e.IdCaja, e.Transaccion, e.Idx });

                entity.ToTable("Tbl_VentaTiempoAire", "pos");

                entity.Property(e => e.IdCaja)
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(10);

                entity.Property(e => e.CodMensaje).HasMaxLength(15);

                entity.Property(e => e.CodSocio)
                    .IsRequired()
                    .HasColumnName("Cod_Socio")
                    .HasMaxLength(25);

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.Mensaje).HasMaxLength(100);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TransacSocio).HasMaxLength(25);
            });

            modelBuilder.Entity<TblVisita>(entity =>
            {
                entity.HasKey(e => new { e.IdAsociado, e.Fecha })
                    .HasName("PK_Tbl_CuponSoc");

                entity.ToTable("Tbl_Visita", "pos");

                entity.Property(e => e.IdAsociado)
                    .HasColumnName("ID_Asociado")
                    .HasMaxLength(25);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.CodTienda)
                    .HasColumnName("Cod_Tienda")
                    .HasMaxLength(25);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblZona>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Zona");

                entity.Property(e => e.CodAreaDist)
                    .HasColumnName("Cod_AreaDist")
                    .HasMaxLength(10);

                entity.Property(e => e.CodDepartamento).HasColumnName("Cod_Departamento");

                entity.Property(e => e.CodMunicipio).HasColumnName("Cod_Municipio");

                entity.Property(e => e.CodPais)
                    .IsRequired()
                    .HasColumnName("Cod_Pais")
                    .HasMaxLength(5);

                entity.Property(e => e.CostoTransporte).HasColumnType("money");

                entity.Property(e => e.Transporte)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Zona)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TempDetPedido>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TempDet_Pedido");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Precio).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.PrecioBase).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.PrecioOrig).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(20);

                entity.Property(e => e.Skufact)
                    .HasColumnName("SKUFact")
                    .HasMaxLength(20);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TempDetRuta>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TempDet_Ruta");

                entity.Property(e => e.FechaConfirmacion).HasColumnType("datetime");

                entity.Property(e => e.FechaEntrega).HasColumnType("datetime");

                entity.Property(e => e.Firma).HasColumnType("text");

                entity.Property(e => e.NumConex).HasColumnName("Num_Conex");

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.NumeroId)
                    .HasColumnName("NumeroID")
                    .HasMaxLength(25);

                entity.Property(e => e.Receptor).HasMaxLength(100);

                entity.Property(e => e.SerieId)
                    .HasColumnName("SerieID")
                    .HasMaxLength(10);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TempDetUbicInventario>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TempDet_UbicInventario");

                entity.Property(e => e.IdUbicacion)
                    .IsRequired()
                    .HasColumnName("Id_Ubicacion")
                    .HasMaxLength(25);

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.NumConex).HasColumnName("Num_Conex");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TempDetUsrInventario>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TempDet_UsrInventario");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.NumConex).HasColumnName("Num_Conex");
            });

            modelBuilder.Entity<TempOferta>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_Oferta", "pos");

                entity.Property(e => e.CodCliente)
                    .IsRequired()
                    .HasColumnName("Cod_Cliente")
                    .HasMaxLength(15);

                entity.Property(e => e.CodLista).HasColumnName("Cod_Lista");

                entity.Property(e => e.Descuento).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Desde).HasColumnType("datetime");

                entity.Property(e => e.Hasta).HasColumnType("datetime");

                entity.Property(e => e.NumPromocion)
                    .HasColumnName("Num_Promocion")
                    .HasMaxLength(15);

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TmpArticuloEcommerce>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmp_ArticuloECommerce");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TmpSincronizaSkuMagentoWms3>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmpSincronizaSkuMagentoWms3");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("sku")
                    .HasMaxLength(18)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TmsDocInterfaz>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TMS_DocInterfaz");

                entity.Property(e => e.CodEmpresa)
                    .IsRequired()
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ViwArchDetFactura>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViwArchDet_Factura");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTipoFinal).HasColumnName("Cod_TipoFinal");

                entity.Property(e => e.NumDocFinal)
                    .HasColumnName("Num_DocFinal")
                    .HasMaxLength(50);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Precio).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.PrecioBase).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.PrecioOrig).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.Skufact)
                    .HasColumnName("skufact")
                    .HasMaxLength(20);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ViwArchDetFacturaAnulada>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViwArchDet_FacturaAnulada");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTipoFinal).HasColumnName("Cod_TipoFinal");

                entity.Property(e => e.NumDocFinal)
                    .HasColumnName("Num_DocFinal")
                    .HasMaxLength(50);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Precio).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.PrecioBase).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.PrecioOrig).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.Skufact)
                    .HasColumnName("skufact")
                    .HasMaxLength(20);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ViwCardex>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Viw_Cardex");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTipoOrg).HasColumnName("Cod_TipoOrg");

                entity.Property(e => e.Destino)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.DocSap)
                    .IsRequired()
                    .HasColumnName("DocSAP")
                    .HasMaxLength(25);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.NumDocOrg)
                    .IsRequired()
                    .HasColumnName("Num_DocOrg")
                    .HasMaxLength(25);

                entity.Property(e => e.NumDocumento)
                    .HasColumnName("Num_documento")
                    .HasMaxLength(50);

                entity.Property(e => e.OrdenCompra)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Origen)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Pedido)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Reclamo)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<ViwComboDisponible>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Viw_ComboDisponible");

                entity.Property(e => e.CodCombo)
                    .IsRequired()
                    .HasColumnName("Cod_Combo")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<ViwDetFactura>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViwDet_Factura");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTipoFinal).HasColumnName("Cod_TipoFinal");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("ID_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.Intercambio)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumDocFinal)
                    .HasColumnName("Num_DocFinal")
                    .HasMaxLength(50);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.PrecioBase).HasColumnType("money");

                entity.Property(e => e.PrecioDesc).HasColumnType("money");

                entity.Property(e => e.PrecioFiscal).HasColumnType("money");

                entity.Property(e => e.PrecioOrig).HasColumnType("money");

                entity.Property(e => e.Skufact)
                    .HasColumnName("skufact")
                    .HasMaxLength(20);

                entity.Property(e => e.Tarima).HasMaxLength(50);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ViwDetFacturaAnulada>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViwDet_FacturaAnulada");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTipoFinal).HasColumnName("Cod_TipoFinal");

                entity.Property(e => e.NumDocFinal)
                    .HasColumnName("Num_DocFinal")
                    .HasMaxLength(50);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Precio).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.PrecioBase).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.PrecioOrig).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.Skufact)
                    .HasColumnName("skufact")
                    .HasMaxLength(20);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ViwDetOlaDesp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViwDet_OlaDesp");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.IdUbicSug)
                    .HasColumnName("ID_UbicSug")
                    .HasMaxLength(25);

                entity.Property(e => e.NumDocumento)
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.NumOla)
                    .IsRequired()
                    .HasColumnName("Num_Ola")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tarima)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViwDetPacking>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViwDet_Packing");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTipoFinal).HasColumnName("Cod_TipoFinal");

                entity.Property(e => e.NumDocFinal)
                    .HasColumnName("Num_DocFinal")
                    .HasMaxLength(50);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Precio).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.PrecioBase).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.PrecioOrig).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.Skufact)
                    .HasColumnName("skufact")
                    .HasMaxLength(20);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ViwDocumentoFiscal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Viw_DocumentoFiscal");

                entity.Property(e => e.CodEmpresa)
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.Descuento).HasColumnType("money");

                entity.Property(e => e.FormaPagoAfecta)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IdCaja)
                    .IsRequired()
                    .HasColumnName("ID_Caja")
                    .HasMaxLength(10);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.PagosAfectanTotal).HasColumnType("money");

                entity.Property(e => e.SubTotal).HasColumnType("money");

                entity.Property(e => e.Total).HasColumnType("money");
            });

            modelBuilder.Entity<ViwPedidoEmpaque>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Viw_PedidoEmpaque");

                entity.Property(e => e.CodEmpresa)
                    .IsRequired()
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.DocSap)
                    .HasColumnName("DocSAP")
                    .HasMaxLength(25);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaSap)
                    .HasColumnName("FechaSAP")
                    .HasColumnType("datetime");

                entity.Property(e => e.Guia).HasMaxLength(25);

                entity.Property(e => e.IdEmbalador)
                    .HasColumnName("ID_Embalador")
                    .HasMaxLength(40);

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.Licencia).HasMaxLength(25);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.NumEmpaque)
                    .IsRequired()
                    .HasColumnName("Num_Empaque")
                    .HasMaxLength(25);

                entity.Property(e => e.Pedido).HasMaxLength(25);

                entity.Property(e => e.Puerta).HasMaxLength(25);

                entity.Property(e => e.Tdped).HasColumnName("TDPed");

                entity.Property(e => e.Tguia).HasColumnName("TGuia");
            });

            modelBuilder.Entity<ViwPedidoEntrega>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Viw_PedidoEntrega");

                entity.Property(e => e.Factura)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaEmpaque).HasColumnType("datetime");

                entity.Property(e => e.FechaEnt).HasColumnType("datetime");

                entity.Property(e => e.Guia).HasMaxLength(25);

                entity.Property(e => e.NumEmpaque)
                    .IsRequired()
                    .HasColumnName("Num_Empaque")
                    .HasMaxLength(25);

                entity.Property(e => e.Pedido).HasMaxLength(25);

                entity.Property(e => e.PedidoLec)
                    .IsRequired()
                    .HasColumnName("PedidoLEC")
                    .HasMaxLength(25);

                entity.Property(e => e.Recibio).HasMaxLength(250);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Tguia).HasColumnName("TGuia");

                entity.Property(e => e.Transporte)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViwPedidoOcNasa>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Viw_PedidoOC_NASA");

                entity.Property(e => e.CodEmpresa)
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.Comentarios).HasColumnType("text");

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Orden)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Tienda)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViwTipoPago>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Viw_TipoPago", "pos");

                entity.Property(e => e.IdCaja)
                    .IsRequired()
                    .HasColumnName("id_caja")
                    .HasMaxLength(15);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("tipo")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Transaccion).HasColumnName("transaccion");
            });

            modelBuilder.Entity<VwClientesRfmcemacocom>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_ClientesRFMCemacocom");

                entity.Property(e => e.CodSocio)
                    .IsRequired()
                    .HasColumnName("Cod_Socio")
                    .HasMaxLength(15);

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(100);

                entity.Property(e => e.MontoRfm)
                    .HasColumnName("MontoRFM")
                    .HasColumnType("money");

                entity.Property(e => e.MontoTotal).HasColumnType("money");

                entity.Property(e => e.Nombre).HasMaxLength(100);

                entity.Property(e => e.TarjetaAsociada).HasMaxLength(13);

                entity.Property(e => e.TarjetaUtilizada).HasMaxLength(13);

                entity.Property(e => e.Telefono1).HasMaxLength(20);

                entity.Property(e => e.TransaccionesRmf).HasColumnName("TransaccionesRMF");
            });

            modelBuilder.Entity<VwPickingTiendasDetallePedido>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_PickingTiendas_detalle_pedido");

                entity.Property(e => e.Departamento).HasMaxLength(100);

                entity.Property(e => e.NumPedido)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Pedido).HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(20);

                entity.Property(e => e.Titulo)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.UrlFoto)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UrlPdp)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwUClienteprivilegio>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_u_clienteprivilegio");

                entity.Property(e => e.CodSocio)
                    .HasColumnName("Cod_socio")
                    .HasMaxLength(14);

                entity.Property(e => e.IdAsociado)
                    .IsRequired()
                    .HasColumnName("ID_Asociado")
                    .HasMaxLength(25);

                entity.Property(e => e.Segmento)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Z20190927TblDetOla>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("z20190927TblDet_Ola");

                entity.Property(e => e.CodMedida)
                    .IsRequired()
                    .HasColumnName("Cod_Medida")
                    .HasMaxLength(10);

                entity.Property(e => e.CodMedidaRec)
                    .HasColumnName("Cod_MedidaRec")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTipoDocUbic).HasColumnName("Cod_TipoDocUbic");

                entity.Property(e => e.EntregaSap)
                    .HasColumnName("EntregaSAP")
                    .HasMaxLength(40);

                entity.Property(e => e.FechaConfSap)
                    .HasColumnName("FechaConfSAP")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRec).HasColumnType("datetime");

                entity.Property(e => e.FechaTarimaSap)
                    .HasColumnName("FechaTarimaSAP")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaTransporteSap)
                    .HasColumnName("FechaTransporteSAP")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaTransporteSap2)
                    .HasColumnName("FechaTransporteSAP2")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdAuditor)
                    .HasColumnName("ID_Auditor")
                    .HasMaxLength(40);

                entity.Property(e => e.IdRecolector)
                    .HasColumnName("ID_Recolector")
                    .HasMaxLength(40);

                entity.Property(e => e.IdUbicAudit)
                    .HasColumnName("ID_UbicAudit")
                    .HasMaxLength(25);

                entity.Property(e => e.IdUbicReal)
                    .HasColumnName("ID_UbicReal")
                    .HasMaxLength(25);

                entity.Property(e => e.IdUbicSug)
                    .IsRequired()
                    .HasColumnName("ID_UbicSug")
                    .HasMaxLength(25);

                entity.Property(e => e.LineaEntregaSap).HasColumnName("LineaEntregaSAP");

                entity.Property(e => e.LineaTransporteSap).HasColumnName("LineaTransporteSAP");

                entity.Property(e => e.LineaTransporteSap2).HasColumnName("LineaTransporteSAP2");

                entity.Property(e => e.MsgError).HasColumnType("text");

                entity.Property(e => e.NumDocUbic)
                    .HasColumnName("Num_DocUbic")
                    .HasMaxLength(25);

                entity.Property(e => e.NumDocumento)
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.NumOla)
                    .IsRequired()
                    .HasColumnName("Num_Ola")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Skufact)
                    .HasColumnName("SKUFact")
                    .HasMaxLength(25);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tarima).HasMaxLength(40);

                entity.Property(e => e.TransporteSap)
                    .HasColumnName("TransporteSAP")
                    .HasMaxLength(40);

                entity.Property(e => e.TransporteSap2)
                    .HasColumnName("TransporteSAP2")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<Z20190927TblOla>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("z20190927Tbl_Ola");

                entity.Property(e => e.CodCentroDist)
                    .HasColumnName("Cod_CentroDist")
                    .HasMaxLength(10);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.ModoCierre).HasMaxLength(1);

                entity.Property(e => e.ModoContab)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumOla)
                    .IsRequired()
                    .HasColumnName("Num_Ola")
                    .HasMaxLength(25);

                entity.Property(e => e.Procesada).HasColumnType("datetime");

                entity.Property(e => e.ReqAuditoria)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Z20190927TblRequerimiento>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("z20190927Tbl_Requerimiento");

                entity.Property(e => e.CodTienda)
                    .IsRequired()
                    .HasColumnName("Cod_Tienda")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTipoDocUbic).HasColumnName("Cod_TipoDocUbic");

                entity.Property(e => e.DocSap)
                    .HasColumnName("DocSAP")
                    .HasMaxLength(250);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaAudit).HasColumnType("datetime");

                entity.Property(e => e.FechaConf).HasColumnType("datetime");

                entity.Property(e => e.FechaRecep).HasColumnType("datetime");

                entity.Property(e => e.IdUbicRecep)
                    .HasColumnName("ID_UbicRecep")
                    .HasMaxLength(25);

                entity.Property(e => e.IdUsuarioAudit)
                    .HasColumnName("ID_UsuarioAudit")
                    .HasMaxLength(40);

                entity.Property(e => e.IdUsuarioConf)
                    .HasColumnName("ID_UsuarioConf")
                    .HasMaxLength(40);

                entity.Property(e => e.IdUsuarioRecep)
                    .HasColumnName("ID_UsuarioRecep")
                    .HasMaxLength(40);

                entity.Property(e => e.MsgError).HasColumnType("text");

                entity.Property(e => e.NumDocUbic)
                    .HasColumnName("Num_DocUbic")
                    .HasMaxLength(25);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.NumRequerimiento)
                    .IsRequired()
                    .HasColumnName("Num_Requerimiento")
                    .HasMaxLength(25);

                entity.Property(e => e.NumTraslado)
                    .HasColumnName("Num_Traslado")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ZArticulosGrandesReporte>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Z_ARTICULOS_GRANDES_REPORTE");

                entity.Property(e => e.Caja)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.CarPlan)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Departamento)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Fuente)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.Property(e => e.NombreSku)
                    .IsRequired()
                    .HasColumnName("Nombre_SKU")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Tienda)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<ZDashboardCollection>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARD_COLLECTION");

                entity.Property(e => e.AccionIncompleto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodDestinatario)
                    .HasColumnName("Cod_Destinatario")
                    .HasMaxLength(25);

                entity.Property(e => e.CodEmpresa)
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.CodEnvoltorio)
                    .HasColumnName("Cod_Envoltorio")
                    .HasMaxLength(25);

                entity.Property(e => e.CodSocio)
                    .IsRequired()
                    .HasColumnName("Cod_Socio")
                    .HasMaxLength(15);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTipoCred).HasColumnName("Cod_TipoCred");

                entity.Property(e => e.CodTipoRuta).HasColumnName("Cod_TipoRuta");

                entity.Property(e => e.Comentarios).HasColumnType("text");

                entity.Property(e => e.De).HasMaxLength(250);

                entity.Property(e => e.Descuento).HasColumnType("money");

                entity.Property(e => e.DocSap)
                    .HasColumnName("DocSAP")
                    .HasMaxLength(25);

                entity.Property(e => e.Emision).HasColumnType("datetime");

                entity.Property(e => e.Expr2)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Expr4).HasMaxLength(25);

                entity.Property(e => e.Factura).HasMaxLength(25);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaFact).HasColumnType("datetime");

                entity.Property(e => e.FechaReg).HasColumnType("datetime");

                entity.Property(e => e.FinAuditoria).HasColumnType("datetime");

                entity.Property(e => e.IdEvento)
                    .HasColumnName("ID_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.IdUbicEnvuelto)
                    .HasColumnName("ID_UbicEnvuelto")
                    .HasMaxLength(25);

                entity.Property(e => e.IniAuditoria).HasColumnType("datetime");

                entity.Property(e => e.Intercambio)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mensaje).HasMaxLength(4000);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.NumDocumentoHh)
                    .HasColumnName("Num_DocumentoHH")
                    .HasMaxLength(25);

                entity.Property(e => e.NumLlamadaNc)
                    .HasColumnName("Num_LLamadaNC")
                    .HasMaxLength(25);

                entity.Property(e => e.NumOla)
                    .HasColumnName("Num_Ola")
                    .HasMaxLength(25);

                entity.Property(e => e.Para).HasMaxLength(250);

                entity.Property(e => e.Precio).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.PrecioBase).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.PrecioOrig).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(20);

                entity.Property(e => e.Skufact)
                    .HasColumnName("SKUFact")
                    .HasMaxLength(20);

                entity.Property(e => e.Skureemplazado)
                    .HasColumnName("SKUReemplazado")
                    .HasMaxLength(25);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Total).HasColumnType("money");
            });

            modelBuilder.Entity<ZDashboardboCantidadpedidosBodasenlinea>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDBO_CANTIDADPEDIDOS_BODASENLINEA");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdEvento)
                    .HasColumnName("ID_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<ZDashboardboFormapago>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDBO_FORMAPAGO");

                entity.Property(e => e.Monto)
                    .HasColumnName("MONTO")
                    .HasColumnType("money");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(50);

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZDashboardboFormapagoCm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDBO_FORMAPAGO_CM");

                entity.Property(e => e.Monto)
                    .HasColumnName("MONTO")
                    .HasColumnType("money");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(50);

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZDashboardboInventarioOrigen>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDBO_INVENTARIO_ORIGEN");

                entity.Property(e => e.Cant).HasColumnName("CANT");

                entity.Property(e => e.Inventario)
                    .IsRequired()
                    .HasColumnName("INVENTARIO")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZDashboardboInventarioOrigenVersion2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDBO_INVENTARIO_ORIGEN_VERSION2");

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("num_documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZDashboardboUsuariosunicosCompra>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDBO_USUARIOSUNICOS_COMPRA");

                entity.Property(e => e.Clientes).HasColumnName("CLIENTES");

                entity.Property(e => e.ClientesBodas).HasColumnName("Clientes bodas");

                entity.Property(e => e.ClientesNoBodas).HasColumnName("Clientes no bodas");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.TransaccionesBodas).HasColumnName("Transacciones bodas");

                entity.Property(e => e.TransaccionesNoBodas).HasColumnName("Transacciones no bodas");
            });

            modelBuilder.Entity<ZDashboardecBodaNoboda>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_BODA_NOBODA");

                entity.Property(e => e.Intercambio)
                    .IsRequired()
                    .HasColumnName("INTERCAMBIO")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.MontoQ)
                    .HasColumnName("MONTO_Q")
                    .HasColumnType("money");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Promedio)
                    .HasColumnName("PROMEDIO")
                    .HasColumnType("money");

                entity.Property(e => e.Std).HasColumnName("STD");

                entity.Property(e => e.Ticket)
                    .HasColumnName("TICKET+")
                    .HasColumnType("money");

                entity.Property(e => e.Ticket1)
                    .HasColumnName("TICKET-")
                    .HasColumnType("money");

                entity.Property(e => e.TipoPedido)
                    .IsRequired()
                    .HasColumnName("TIPO_PEDIDO")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.TransaccionPromedioQ)
                    .HasColumnName("TRANSACCION_PROMEDIO_Q")
                    .HasColumnType("money");

                entity.Property(e => e.Transacciones).HasColumnName("TRANSACCIONES");

                entity.Property(e => e.UnidadesPromedio)
                    .HasColumnName("UNIDADES_PROMEDIO")
                    .HasColumnType("numeric(38, 6)");
            });

            modelBuilder.Entity<ZDashboardecBodaNoboda2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_BODA_NOBODA_2");

                entity.Property(e => e.Documento)
                    .IsRequired()
                    .HasColumnName("DOCUMENTO")
                    .HasMaxLength(25);

                entity.Property(e => e.Intercambio)
                    .IsRequired()
                    .HasColumnName("INTERCAMBIO")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.MontoQ)
                    .HasColumnName("MONTO_Q")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.TipoPedido)
                    .IsRequired()
                    .HasColumnName("TIPO_PEDIDO")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.TransaccionPromedioQ)
                    .HasColumnName("TRANSACCION_PROMEDIO_Q")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Transacciones).HasColumnName("TRANSACCIONES");

                entity.Property(e => e.UnidadesPromedio)
                    .HasColumnName("UNIDADES_PROMEDIO")
                    .HasColumnType("numeric(38, 6)");
            });

            modelBuilder.Entity<ZDashboardecBodaNobodaCm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_BODA_NOBODA_CM");

                entity.Property(e => e.Intercambio)
                    .IsRequired()
                    .HasColumnName("INTERCAMBIO")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.MontoQ)
                    .HasColumnName("MONTO_Q")
                    .HasColumnType("money");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TipoPedido)
                    .IsRequired()
                    .HasColumnName("TIPO_PEDIDO")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.TransaccionPromedioQ)
                    .HasColumnName("TRANSACCION_PROMEDIO_Q")
                    .HasColumnType("money");

                entity.Property(e => e.Transacciones).HasColumnName("TRANSACCIONES");

                entity.Property(e => e.UnidadesPromedio)
                    .HasColumnName("UNIDADES_PROMEDIO")
                    .HasColumnType("numeric(38, 6)");
            });

            modelBuilder.Entity<ZDashboardecBodascreadas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_BODASCREADAS");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.Evento)
                    .IsRequired()
                    .HasColumnName("EVENTO")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZDashboardecBodascreadasCm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_BODASCREADAS_CM");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.Evento)
                    .IsRequired()
                    .HasColumnName("EVENTO")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZDashboardecCantidadPedidosbodas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_CANTIDAD_PEDIDOSBODAS");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZDashboardecCantidadPedidosbodasCm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_CANTIDAD_PEDIDOSBODAS_CM");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZDashboardecCatalogoMs3>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_CATALOGO_MS3");

                entity.Property(e => e.CuentaSku).HasColumnName("CUENTA_SKU");

                entity.Property(e => e.EnEvento)
                    .IsRequired()
                    .HasColumnName("EN_EVENTO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TipoArticulo)
                    .IsRequired()
                    .HasColumnName("TIPO_ARTICULO")
                    .HasMaxLength(11)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZDashboardecCentrosporpedido>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_CENTROSPORPEDIDO");

                entity.Property(e => e.Centros).HasColumnName("CENTROS");

                entity.Property(e => e.Pedido)
                    .HasColumnName("PEDIDO")
                    .HasMaxLength(25);

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZDashboardecCentrosporpedidoBodaNoboda>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_CENTROSPORPEDIDO_BODA_NOBODA");

                entity.Property(e => e.Centros).HasColumnName("CENTROS");

                entity.Property(e => e.Pedido)
                    .HasColumnName("PEDIDO")
                    .HasMaxLength(25);

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("TIPO")
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZDashboardecCentrosporpedidoCm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_CENTROSPORPEDIDO_CM");

                entity.Property(e => e.Centros).HasColumnName("CENTROS");

                entity.Property(e => e.Pedido)
                    .HasColumnName("PEDIDO")
                    .HasMaxLength(25);

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZDashboardecCostoenvio>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_COSTOENVIO");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Precio).HasColumnType("money");
            });

            modelBuilder.Entity<ZDashboardecFillrate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_FILLRATE");

                entity.Property(e => e.FillRate)
                    .HasColumnName("FILL_RATE")
                    .HasColumnType("numeric(37, 19)");

                entity.Property(e => e.PedImcomp).HasColumnName("PED_IMCOMP");

                entity.Property(e => e.PedSindespacho).HasColumnName("PED_SINDESPACHO");

                entity.Property(e => e.Pedidos).HasColumnName("PEDIDOS");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.UnidadesDesp).HasColumnName("UNIDADES_DESP");

                entity.Property(e => e.UnidadesPed).HasColumnName("UNIDADES_PED");
            });

            modelBuilder.Entity<ZDashboardecFillrateBodaIntercambio>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_FILLRATE_BODA_INTERCAMBIO");

                entity.Property(e => e.FillRate)
                    .HasColumnName("FILL_RATE")
                    .HasColumnType("numeric(37, 19)");

                entity.Property(e => e.PedIncomp).HasColumnName("PED_INCOMP");

                entity.Property(e => e.PedSindespacho).HasColumnName("PED_SINDESPACHO");

                entity.Property(e => e.Pedidos).HasColumnName("PEDIDOS");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("TIPO")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UnidadesPed).HasColumnName("UNIDADES_PED");
            });

            modelBuilder.Entity<ZDashboardecFillrateBodaNoboda>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_FILLRATE_BODA_NOBODA");

                entity.Property(e => e.FillRate)
                    .HasColumnName("FILL_RATE")
                    .HasColumnType("numeric(37, 19)");

                entity.Property(e => e.PedIncomp).HasColumnName("PED_INCOMP");

                entity.Property(e => e.PedSindespacho).HasColumnName("PED_SINDESPACHO");

                entity.Property(e => e.Pedidos).HasColumnName("PEDIDOS");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("TIPO")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UnidadesDesp).HasColumnName("UNIDADES_DESP");

                entity.Property(e => e.UnidadesPed).HasColumnName("UNIDADES_PED");
            });

            modelBuilder.Entity<ZDashboardecFillrateCentro>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_FILLRATE_CENTRO");

                entity.Property(e => e.Centro)
                    .IsRequired()
                    .HasColumnName("CENTRO")
                    .HasMaxLength(10);

                entity.Property(e => e.Despachado).HasColumnName("DESPACHADO");

                entity.Property(e => e.FillRate)
                    .HasColumnName("FILL_RATE")
                    .HasColumnType("money");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Solicitado).HasColumnName("SOLICITADO");
            });

            modelBuilder.Entity<ZDashboardecFillrateCentroBodaNoboda>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_FILLRATE_CENTRO_BODA_NOBODA");

                entity.Property(e => e.Centro)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.FillRate)
                    .HasColumnName("FILL_RATE")
                    .HasColumnType("decimal(37, 19)");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZDashboardecFillrateCentroCm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_FILLRATE_CENTRO_CM");

                entity.Property(e => e.Centro)
                    .IsRequired()
                    .HasColumnName("CENTRO")
                    .HasMaxLength(10);

                entity.Property(e => e.Despachado).HasColumnName("DESPACHADO");

                entity.Property(e => e.FillRate)
                    .HasColumnName("FILL_RATE")
                    .HasColumnType("money");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Solicitado).HasColumnName("SOLICITADO");
            });

            modelBuilder.Entity<ZDashboardecFillrateCm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_FILLRATE_CM");

                entity.Property(e => e.FillRate)
                    .HasColumnName("FILL_RATE")
                    .HasColumnType("numeric(37, 19)");

                entity.Property(e => e.PedImcomp).HasColumnName("PED_IMCOMP");

                entity.Property(e => e.Pedidos).HasColumnName("PEDIDOS");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.UnidadesDesp).HasColumnName("UNIDADES_DESP");

                entity.Property(e => e.UnidadesPed).HasColumnName("UNIDADES_PED");
            });

            modelBuilder.Entity<ZDashboardecHorasentrega>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_HORASENTREGA");

                entity.Property(e => e.EmpresaTransporte)
                    .IsRequired()
                    .HasColumnName("EMPRESA_TRANSPORTE")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Hold)
                    .IsRequired()
                    .HasColumnName("HOLD")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.HorasEntrega)
                    .HasColumnName("HORAS_ENTREGA")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pedidos).HasColumnName("PEDIDOS");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("TIPO")
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZDashboardecHorasentregaCm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_HORASENTREGA_CM");

                entity.Property(e => e.EmpresaTransporte)
                    .IsRequired()
                    .HasColumnName("EMPRESA_TRANSPORTE")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Hold)
                    .IsRequired()
                    .HasColumnName("HOLD")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.HorasEntrega)
                    .HasColumnName("HORAS_ENTREGA")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pedidos).HasColumnName("PEDIDOS");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("TIPO")
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZDashboardecHorasentregaInventario>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_HORASENTREGA_INVENTARIO");

                entity.Property(e => e.EmpresaTransporte)
                    .IsRequired()
                    .HasColumnName("EMPRESA_TRANSPORTE")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Hold)
                    .IsRequired()
                    .HasColumnName("HOLD")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.HorasEntrega)
                    .HasColumnName("HORAS_ENTREGA")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Inventario)
                    .HasColumnName("INVENTARIO")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Pedidos).HasColumnName("PEDIDOS");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("TIPO")
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZDashboardecHorashabilesrecoleccion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_HORASHABILESRECOLECCION");

                entity.Property(e => e.CodTienda)
                    .IsRequired()
                    .HasColumnName("Cod_Tienda")
                    .HasMaxLength(10);

                entity.Property(e => e.HorasPromedio)
                    .HasColumnName("Horas_promedio")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZDashboardecLineasPorPedido>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_LINEAS_POR_PEDIDO");

                entity.Property(e => e.Lineas)
                    .HasColumnName("LINEAS")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Pedidos).HasColumnName("PEDIDOS");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZDashboardecLineasPorPedidoCm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_LINEAS_POR_PEDIDO_CM");

                entity.Property(e => e.Lineas)
                    .HasColumnName("LINEAS")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Pedidos).HasColumnName("PEDIDOS");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZDashboardecPagogyt24horas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_PAGOGYT_24HORAS");

                entity.Property(e => e.PedidosMayor24h).HasColumnName("PEDIDOS_MAYOR_24H");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZDashboardecPagosbi>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_PAGOSBI");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZDashboardecPagosgyt>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_PAGOSGYT");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZDashboardecPedidosGyt>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_PEDIDOS_GYT");

                entity.Property(e => e.CantidadPedidos).HasColumnName("CANTIDAD_PEDIDOS");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZDashboardecPedidosGytCm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_PEDIDOS_GYT_CM");

                entity.Property(e => e.CantidadPedidos).HasColumnName("CANTIDAD_PEDIDOS");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZDashboardecPedidosGytXtelefono>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_PEDIDOS_GYT_XTELEFONO");

                entity.Property(e => e.CantidadPedidos).HasColumnName("CANTIDAD_PEDIDOS");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZDashboardecPedidosTarjetaCd>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_PEDIDOS_TARJETA_CD");

                entity.Property(e => e.CantPedidos).HasColumnName("CANT_PEDIDOS");

                entity.Property(e => e.FormaPago)
                    .IsRequired()
                    .HasColumnName("FORMA_PAGO")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZDashboardecPedidosTarjetaCdCm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_PEDIDOS_TARJETA_CD_CM");

                entity.Property(e => e.CantPedidos).HasColumnName("CANT_PEDIDOS");

                entity.Property(e => e.FormaPago)
                    .IsRequired()
                    .HasColumnName("FORMA_PAGO")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZDashboardecPedidosTarjetaCdXtelefono>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_PEDIDOS_TARJETA_CD_XTELEFONO");

                entity.Property(e => e.CantPedidos).HasColumnName("CANT_PEDIDOS");

                entity.Property(e => e.FormaPago)
                    .IsRequired()
                    .HasColumnName("FORMA_PAGO")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZDashboardecPedidosfacturados>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_PEDIDOSFACTURADOS");

                entity.Property(e => e.PedidosFacturados).HasColumnName("PEDIDOS_FACTURADOS");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZDashboardecPedidosfacturadosCm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_PEDIDOSFACTURADOS_CM");

                entity.Property(e => e.PedidosFacturados).HasColumnName("PEDIDOS_FACTURADOS");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZDashboardecPrivi>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_PRIVI");

                entity.Property(e => e.Monto)
                    .HasColumnName("MONTO")
                    .HasColumnType("money");

                entity.Property(e => e.Pedidos).HasColumnName("PEDIDOS");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Privilegio)
                    .IsRequired()
                    .HasColumnName("PRIVILEGIO")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZDashboardecPriviCm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_PRIVI_CM");

                entity.Property(e => e.Monto)
                    .HasColumnName("MONTO")
                    .HasColumnType("money");

                entity.Property(e => e.Pedidos).HasColumnName("PEDIDOS");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Privilegio)
                    .IsRequired()
                    .HasColumnName("PRIVILEGIO")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZDashboardecPromediocliente>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_PROMEDIOCLIENTE");

                entity.Property(e => e.CodSocio)
                    .IsRequired()
                    .HasColumnName("Cod_Socio")
                    .HasMaxLength(15);

                entity.Property(e => e.DesviacionStd).HasColumnName("DESVIACION_STD");

                entity.Property(e => e.MontoMaxq)
                    .HasColumnName("MONTO_MAXQ")
                    .HasColumnType("money");

                entity.Property(e => e.MontoMinq)
                    .HasColumnName("MONTO_MINQ")
                    .HasColumnType("money");

                entity.Property(e => e.MontoPromedioQ)
                    .HasColumnName("MONTO_PROMEDIO_Q")
                    .HasColumnType("money");

                entity.Property(e => e.MontototalQ)
                    .HasColumnName("MONTOTOTAL_Q")
                    .HasColumnType("money");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Transacciones).HasColumnName("TRANSACCIONES");

                entity.Property(e => e.TransaccionesPromedio).HasColumnName("TRANSACCIONES_PROMEDIO");
            });

            modelBuilder.Entity<ZDashboardecPromedioclienteCm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_PROMEDIOCLIENTE_CM");

                entity.Property(e => e.CodSocio)
                    .IsRequired()
                    .HasColumnName("Cod_Socio")
                    .HasMaxLength(15);

                entity.Property(e => e.DesviacionStd).HasColumnName("DESVIACION_STD");

                entity.Property(e => e.MontoMaxq)
                    .HasColumnName("MONTO_MAXQ")
                    .HasColumnType("money");

                entity.Property(e => e.MontoMinq)
                    .HasColumnName("MONTO_MINQ")
                    .HasColumnType("money");

                entity.Property(e => e.MontoPromedioQ)
                    .HasColumnName("MONTO_PROMEDIO_Q")
                    .HasColumnType("money");

                entity.Property(e => e.MontototalQ)
                    .HasColumnName("MONTOTOTAL_Q")
                    .HasColumnType("money");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Transacciones).HasColumnName("TRANSACCIONES");

                entity.Property(e => e.TransaccionesPromedio).HasColumnName("TRANSACCIONES_PROMEDIO");
            });

            modelBuilder.Entity<ZDashboardecTopMunicipiosCm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_TOP_MUNICIPIOS_CM");

                entity.Property(e => e.CodDepartamento).HasColumnName("Cod_Departamento");

                entity.Property(e => e.CodMunicipio).HasColumnName("Cod_Municipio");

                entity.Property(e => e.CodPais)
                    .IsRequired()
                    .HasColumnName("Cod_Pais")
                    .HasMaxLength(5);

                entity.Property(e => e.Departamento)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Municipio)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Pais)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Pedidos).HasColumnName("PEDIDOS");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZDashboardecTopMunicipiosLmtd>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_TOP_MUNICIPIOS_LMTD");

                entity.Property(e => e.CodDepartamento).HasColumnName("Cod_Departamento");

                entity.Property(e => e.CodMunicipio).HasColumnName("Cod_Municipio");

                entity.Property(e => e.CodPais)
                    .IsRequired()
                    .HasColumnName("Cod_Pais")
                    .HasMaxLength(5);

                entity.Property(e => e.Departamento)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Municipio)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Pais)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Pedidos).HasColumnName("PEDIDOS");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZDashboardecTopMunicipiosLw>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_TOP_MUNICIPIOS_LW");

                entity.Property(e => e.CodDepartamento).HasColumnName("Cod_Departamento");

                entity.Property(e => e.CodMunicipio).HasColumnName("Cod_Municipio");

                entity.Property(e => e.CodPais)
                    .IsRequired()
                    .HasColumnName("Cod_Pais")
                    .HasMaxLength(5);

                entity.Property(e => e.Departamento)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Municipio)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Pais)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Pedidos).HasColumnName("PEDIDOS");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZDashboardecTopMunicipiosLymtd>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_TOP_MUNICIPIOS_LYMTD");

                entity.Property(e => e.CodDepartamento).HasColumnName("Cod_Departamento");

                entity.Property(e => e.CodMunicipio).HasColumnName("Cod_Municipio");

                entity.Property(e => e.CodPais)
                    .IsRequired()
                    .HasColumnName("Cod_Pais")
                    .HasMaxLength(5);

                entity.Property(e => e.Departamento)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Municipio)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Pais)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Pedidos).HasColumnName("PEDIDOS");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZDashboardecTopMunicipiosMtd>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_TOP_MUNICIPIOS_MTD");

                entity.Property(e => e.CodDepartamento).HasColumnName("Cod_Departamento");

                entity.Property(e => e.CodMunicipio).HasColumnName("Cod_Municipio");

                entity.Property(e => e.CodPais)
                    .IsRequired()
                    .HasColumnName("Cod_Pais")
                    .HasMaxLength(5);

                entity.Property(e => e.Departamento)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Municipio)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Pais)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Pedidos).HasColumnName("PEDIDOS");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZDashboardecTopdeptosBodaCm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_TOPDEPTOS_BODA_CM");

                entity.Property(e => e.Departamento)
                    .HasColumnName("DEPARTAMENTO")
                    .HasMaxLength(100);

                entity.Property(e => e.MontoQ)
                    .HasColumnName("MONTO_Q")
                    .HasColumnType("money");

                entity.Property(e => e.Unidades).HasColumnName("UNIDADES");
            });

            modelBuilder.Entity<ZDashboardecTopdeptosBodaLmtd>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_TOPDEPTOS_BODA_LMTD");

                entity.Property(e => e.Departamento)
                    .HasColumnName("DEPARTAMENTO")
                    .HasMaxLength(100);

                entity.Property(e => e.MontoQ)
                    .HasColumnName("MONTO_Q")
                    .HasColumnType("money");

                entity.Property(e => e.Transacciones).HasColumnName("TRANSACCIONES");

                entity.Property(e => e.Unidades).HasColumnName("UNIDADES");
            });

            modelBuilder.Entity<ZDashboardecTopdeptosBodaLw>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_TOPDEPTOS_BODA_LW");

                entity.Property(e => e.Departamento)
                    .HasColumnName("DEPARTAMENTO")
                    .HasMaxLength(100);

                entity.Property(e => e.MontoQ)
                    .HasColumnName("MONTO_Q")
                    .HasColumnType("money");

                entity.Property(e => e.Transacciones).HasColumnName("TRANSACCIONES");

                entity.Property(e => e.Unidades).HasColumnName("UNIDADES");
            });

            modelBuilder.Entity<ZDashboardecTopdeptosBodaLymtd>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_TOPDEPTOS_BODA_LYMTD");

                entity.Property(e => e.Departamento)
                    .HasColumnName("DEPARTAMENTO")
                    .HasMaxLength(100);

                entity.Property(e => e.MontoQ)
                    .HasColumnName("MONTO_Q")
                    .HasColumnType("money");

                entity.Property(e => e.Transacciones).HasColumnName("TRANSACCIONES");

                entity.Property(e => e.Unidades).HasColumnName("UNIDADES");
            });

            modelBuilder.Entity<ZDashboardecTopdeptosBodaMtd>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_TOPDEPTOS_BODA_MTD");

                entity.Property(e => e.Departamento)
                    .HasColumnName("DEPARTAMENTO")
                    .HasMaxLength(100);

                entity.Property(e => e.MontoQ)
                    .HasColumnName("MONTO_Q")
                    .HasColumnType("money");

                entity.Property(e => e.Transacciones).HasColumnName("TRANSACCIONES");

                entity.Property(e => e.Unidades).HasColumnName("UNIDADES");
            });

            modelBuilder.Entity<ZDashboardecTopdeptosLmtd>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_TOPDEPTOS_LMTD");

                entity.Property(e => e.Departamento)
                    .HasColumnName("DEPARTAMENTO")
                    .HasMaxLength(100);

                entity.Property(e => e.MontoGtq)
                    .HasColumnName("MONTO_GTQ")
                    .HasColumnType("money");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Unidades).HasColumnName("UNIDADES");
            });

            modelBuilder.Entity<ZDashboardecTopdeptosLw>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_TOPDEPTOS_LW");

                entity.Property(e => e.Departamento)
                    .HasColumnName("DEPARTAMENTO")
                    .HasMaxLength(100);

                entity.Property(e => e.MontoGtq)
                    .HasColumnName("MONTO_GTQ")
                    .HasColumnType("money");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Unidades).HasColumnName("UNIDADES");
            });

            modelBuilder.Entity<ZDashboardecTopdeptosLwCm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_TOPDEPTOS_LW_CM");

                entity.Property(e => e.Departamento)
                    .HasColumnName("DEPARTAMENTO")
                    .HasMaxLength(100);

                entity.Property(e => e.MontoGtq)
                    .HasColumnName("MONTO_GTQ")
                    .HasColumnType("money");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Unidades).HasColumnName("UNIDADES");
            });

            modelBuilder.Entity<ZDashboardecTopdeptosLymtd>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_TOPDEPTOS_LYMTD");

                entity.Property(e => e.Departamento)
                    .HasColumnName("DEPARTAMENTO")
                    .HasMaxLength(100);

                entity.Property(e => e.MontoGtq)
                    .HasColumnName("MONTO_GTQ")
                    .HasColumnType("money");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Unidades).HasColumnName("UNIDADES");
            });

            modelBuilder.Entity<ZDashboardecTopdeptosMtd>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_TOPDEPTOS_MTD");

                entity.Property(e => e.Departamento)
                    .HasColumnName("DEPARTAMENTO")
                    .HasMaxLength(100);

                entity.Property(e => e.MontoGtq)
                    .HasColumnName("MONTO_GTQ")
                    .HasColumnType("money");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Unidades).HasColumnName("UNIDADES");
            });

            modelBuilder.Entity<ZDashboardecTopdeptosNobodaCm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_TOPDEPTOS_NOBODA_CM");

                entity.Property(e => e.Departamento)
                    .HasColumnName("DEPARTAMENTO")
                    .HasMaxLength(100);

                entity.Property(e => e.MontoQ)
                    .HasColumnName("MONTO_Q")
                    .HasColumnType("money");

                entity.Property(e => e.Unidades).HasColumnName("UNIDADES");
            });

            modelBuilder.Entity<ZDashboardecTopdeptosNobodaLmtd>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_TOPDEPTOS_NOBODA_LMTD");

                entity.Property(e => e.Departamento)
                    .HasColumnName("DEPARTAMENTO")
                    .HasMaxLength(100);

                entity.Property(e => e.MontoQ)
                    .HasColumnName("MONTO_Q")
                    .HasColumnType("money");

                entity.Property(e => e.Transacciones).HasColumnName("TRANSACCIONES");

                entity.Property(e => e.Unidades).HasColumnName("UNIDADES");
            });

            modelBuilder.Entity<ZDashboardecTopdeptosNobodaLw>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_TOPDEPTOS_NOBODA_LW");

                entity.Property(e => e.Departamento)
                    .HasColumnName("DEPARTAMENTO")
                    .HasMaxLength(100);

                entity.Property(e => e.MontoQ)
                    .HasColumnName("MONTO_Q")
                    .HasColumnType("money");

                entity.Property(e => e.Transacciones).HasColumnName("TRANSACCIONES");

                entity.Property(e => e.Unidades).HasColumnName("UNIDADES");
            });

            modelBuilder.Entity<ZDashboardecTopdeptosNobodaLymtd>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_TOPDEPTOS_NOBODA_LYMTD");

                entity.Property(e => e.Departamento)
                    .HasColumnName("DEPARTAMENTO")
                    .HasMaxLength(100);

                entity.Property(e => e.MontoQ)
                    .HasColumnName("MONTO_Q")
                    .HasColumnType("money");

                entity.Property(e => e.Transacciones).HasColumnName("TRANSACCIONES");

                entity.Property(e => e.Unidades).HasColumnName("UNIDADES");
            });

            modelBuilder.Entity<ZDashboardecTopdeptosNobodaMtd>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_TOPDEPTOS_NOBODA_MTD");

                entity.Property(e => e.Departamento)
                    .HasColumnName("DEPARTAMENTO")
                    .HasMaxLength(100);

                entity.Property(e => e.MontoQ)
                    .HasColumnName("MONTO_Q")
                    .HasColumnType("money");

                entity.Property(e => e.Transacciones).HasColumnName("TRANSACCIONES");

                entity.Property(e => e.Unidades).HasColumnName("UNIDADES");
            });

            modelBuilder.Entity<ZDashboardecTrDia>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_TR_DIA");

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA")
                    .HasColumnType("datetime");

                entity.Property(e => e.MontoQ)
                    .HasColumnName("MONTO_Q")
                    .HasColumnType("money");

                entity.Property(e => e.Transacciones).HasColumnName("TRANSACCIONES");
            });

            modelBuilder.Entity<ZDashboardecTrDiaCm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_TR_DIA_CM");

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA")
                    .HasColumnType("datetime");

                entity.Property(e => e.MontoQ)
                    .HasColumnName("MONTO_Q")
                    .HasColumnType("money");

                entity.Property(e => e.Transacciones).HasColumnName("TRANSACCIONES");
            });

            modelBuilder.Entity<ZDashboardecTransacciones>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_TRANSACCIONES");

                entity.Property(e => e.MontoQ)
                    .HasColumnName("MONTO_Q")
                    .HasColumnType("money");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.TransaccionPromedioQ)
                    .HasColumnName("TRANSACCION_PROMEDIO_Q")
                    .HasColumnType("numeric(23, 6)");

                entity.Property(e => e.Transacciones).HasColumnName("TRANSACCIONES");

                entity.Property(e => e.UnidadesPromedio)
                    .HasColumnName("UNIDADES_PROMEDIO")
                    .HasColumnType("decimal(38, 6)");
            });

            modelBuilder.Entity<ZDashboardecTransaccionesCm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_TRANSACCIONES_CM");

                entity.Property(e => e.MontoQ)
                    .HasColumnName("MONTO_Q")
                    .HasColumnType("money");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TransaccionPromedioQ)
                    .HasColumnName("TRANSACCION_PROMEDIO_Q")
                    .HasColumnType("numeric(23, 6)");

                entity.Property(e => e.Transacciones).HasColumnName("TRANSACCIONES");

                entity.Property(e => e.UnidadesPromedio)
                    .HasColumnName("UNIDADES_PROMEDIO")
                    .HasColumnType("decimal(38, 6)");
            });

            modelBuilder.Entity<ZDashboardecTransaccionesVentasxtelefono>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_TRANSACCIONES_VENTASXTELEFONO");

                entity.Property(e => e.MontoQ)
                    .HasColumnName("MONTO_Q")
                    .HasColumnType("money");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.TransaccionPromedioQ)
                    .HasColumnName("TRANSACCION_PROMEDIO_Q")
                    .HasColumnType("numeric(23, 6)");

                entity.Property(e => e.Transacciones).HasColumnName("TRANSACCIONES");

                entity.Property(e => e.UnidadesPromedio)
                    .HasColumnName("UNIDADES_PROMEDIO")
                    .HasColumnType("decimal(38, 6)");
            });

            modelBuilder.Entity<ZDashboardecVentabodasTiendaInternet>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_VENTABODAS_TIENDA_INTERNET");

                entity.Property(e => e.Enlinea)
                    .HasColumnName("ENLINEA")
                    .HasColumnType("money");

                entity.Property(e => e.Fecharegistro)
                    .HasColumnName("FECHAREGISTRO")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("ID_EVENTO")
                    .HasMaxLength(25);

                entity.Property(e => e.Tienda)
                    .HasColumnName("TIENDA")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<ZDashboardecVentasBoda>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_VENTAS_BODA");

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Intercambio)
                    .IsRequired()
                    .HasColumnName("INTERCAMBIO")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.MontoQ)
                    .HasColumnName("MONTO_Q")
                    .HasColumnType("money");

                entity.Property(e => e.TipoPedido)
                    .IsRequired()
                    .HasColumnName("TIPO_PEDIDO")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.TransaccionPromedioQ)
                    .HasColumnName("TRANSACCION_PROMEDIO_Q")
                    .HasColumnType("money");

                entity.Property(e => e.Transacciones).HasColumnName("TRANSACCIONES");
            });

            modelBuilder.Entity<ZDashboardecVentasBodaCm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_VENTAS_BODA_CM");

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Intercambio)
                    .IsRequired()
                    .HasColumnName("INTERCAMBIO")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.MontoQ)
                    .HasColumnName("MONTO_Q")
                    .HasColumnType("money");

                entity.Property(e => e.TipoPedido)
                    .IsRequired()
                    .HasColumnName("TIPO_PEDIDO")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.TransaccionPromedioQ)
                    .HasColumnName("TRANSACCION_PROMEDIO_Q")
                    .HasColumnType("money");

                entity.Property(e => e.Transacciones).HasColumnName("TRANSACCIONES");
            });

            modelBuilder.Entity<ZDashboardecVentasCallcenter>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_VENTAS_CALLCENTER");

                entity.Property(e => e.MontoQ)
                    .HasColumnName("MONTO_Q")
                    .HasColumnType("money");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.TransaccionPromedioQ)
                    .HasColumnName("TRANSACCION_PROMEDIO_Q")
                    .HasColumnType("numeric(23, 6)");

                entity.Property(e => e.Transacciones).HasColumnName("TRANSACCIONES");

                entity.Property(e => e.UnidadesPromedio)
                    .HasColumnName("UNIDADES_PROMEDIO")
                    .HasColumnType("decimal(38, 6)");
            });

            modelBuilder.Entity<ZDashboardecVentasCallcenterColaborador>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_VENTAS_CALLCENTER_COLABORADOR");

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(100);

                entity.Property(e => e.MontoQ)
                    .HasColumnName("MONTO_Q")
                    .HasColumnType("money");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.TransaccionPromedioQ)
                    .HasColumnName("TRANSACCION_PROMEDIO_Q")
                    .HasColumnType("numeric(23, 6)");

                entity.Property(e => e.Transacciones).HasColumnName("TRANSACCIONES");

                entity.Property(e => e.UnidadesPromedio)
                    .HasColumnName("UNIDADES_PROMEDIO")
                    .HasColumnType("decimal(38, 6)");
            });

            modelBuilder.Entity<ZDashboardecVentasNoboda>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_VENTAS_NOBODA");

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Intercambio)
                    .IsRequired()
                    .HasColumnName("INTERCAMBIO")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.MontoQ)
                    .HasColumnName("MONTO_Q")
                    .HasColumnType("money");

                entity.Property(e => e.TipoPedido)
                    .IsRequired()
                    .HasColumnName("TIPO_PEDIDO")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.TransaccionPromedioQ)
                    .HasColumnName("TRANSACCION_PROMEDIO_Q")
                    .HasColumnType("money");

                entity.Property(e => e.Transacciones).HasColumnName("TRANSACCIONES");
            });

            modelBuilder.Entity<ZDashboardecVentasNobodaCm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_VENTAS_NOBODA_CM");

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Intercambio)
                    .IsRequired()
                    .HasColumnName("INTERCAMBIO")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.MontoQ)
                    .HasColumnName("MONTO_Q")
                    .HasColumnType("money");

                entity.Property(e => e.TipoPedido)
                    .IsRequired()
                    .HasColumnName("TIPO_PEDIDO")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.TransaccionPromedioQ)
                    .HasColumnName("TRANSACCION_PROMEDIO_Q")
                    .HasColumnType("money");

                entity.Property(e => e.Transacciones).HasColumnName("TRANSACCIONES");
            });

            modelBuilder.Entity<ZDashboardecVentasdia>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_VENTASDIA");

                entity.Property(e => e.Diasemana)
                    .HasColumnName("DIASEMANA")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.MontoPromediodia)
                    .HasColumnName("MONTO_PROMEDIODIA")
                    .HasColumnType("money");

                entity.Property(e => e.MontoTotal)
                    .HasColumnName("MONTO_TOTAL")
                    .HasColumnType("money");

                entity.Property(e => e.TicketPromedio)
                    .HasColumnName("TICKET_PROMEDIO")
                    .HasColumnType("money");

                entity.Property(e => e.Transacciones).HasColumnName("TRANSACCIONES");

                entity.Property(e => e.TransaccionesPromediodia)
                    .HasColumnName("TRANSACCIONES_PROMEDIODIA")
                    .HasColumnType("numeric(29, 15)");
            });

            modelBuilder.Entity<ZDashboardecVentasdiaBoda>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_VENTASDIA_BODA");

                entity.Property(e => e.Diasemana)
                    .HasColumnName("DIASEMANA")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.MontoPromediodia)
                    .HasColumnName("MONTO_PROMEDIODIA")
                    .HasColumnType("money");

                entity.Property(e => e.MontoTotal)
                    .HasColumnName("MONTO_TOTAL")
                    .HasColumnType("money");

                entity.Property(e => e.TicketPromedio)
                    .HasColumnName("TICKET_PROMEDIO")
                    .HasColumnType("money");

                entity.Property(e => e.Transacciones).HasColumnName("TRANSACCIONES");

                entity.Property(e => e.TransaccionesPromediodia)
                    .HasColumnName("TRANSACCIONES_PROMEDIODIA")
                    .HasColumnType("numeric(29, 15)");
            });

            modelBuilder.Entity<ZDashboardecVentasdiaBodaCm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_VENTASDIA_BODA_CM");

                entity.Property(e => e.Diasemana)
                    .HasColumnName("DIASEMANA")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.MontoPromediodia)
                    .HasColumnName("MONTO_PROMEDIODIA")
                    .HasColumnType("money");

                entity.Property(e => e.MontoTotal)
                    .HasColumnName("MONTO_TOTAL")
                    .HasColumnType("money");

                entity.Property(e => e.TicketPromedio)
                    .HasColumnName("TICKET_PROMEDIO")
                    .HasColumnType("decimal(38, 23)");

                entity.Property(e => e.Transacciones).HasColumnName("TRANSACCIONES");

                entity.Property(e => e.TransaccionesPromediodia)
                    .HasColumnName("TRANSACCIONES_PROMEDIODIA")
                    .HasColumnType("decimal(24, 6)");
            });

            modelBuilder.Entity<ZDashboardecVentasdiaCm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_VENTASDIA_CM");

                entity.Property(e => e.Diasemana)
                    .HasColumnName("DIASEMANA")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.MontoPromediodia)
                    .HasColumnName("MONTO_PROMEDIODIA")
                    .HasColumnType("money");

                entity.Property(e => e.MontoTotal)
                    .HasColumnName("MONTO_TOTAL")
                    .HasColumnType("money");

                entity.Property(e => e.TicketPromedio)
                    .HasColumnName("TICKET_PROMEDIO")
                    .HasColumnType("decimal(38, 23)");

                entity.Property(e => e.Transacciones).HasColumnName("TRANSACCIONES");

                entity.Property(e => e.TransaccionesPromediodia)
                    .HasColumnName("TRANSACCIONES_PROMEDIODIA")
                    .HasColumnType("decimal(24, 6)");
            });

            modelBuilder.Entity<ZDashboardecVentasdiaNoboda>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_VENTASDIA_NOBODA");

                entity.Property(e => e.Diasemana)
                    .HasColumnName("DIASEMANA")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.MontoPromediodia)
                    .HasColumnName("MONTO_PROMEDIODIA")
                    .HasColumnType("money");

                entity.Property(e => e.MontoTotal)
                    .HasColumnName("MONTO_TOTAL")
                    .HasColumnType("money");

                entity.Property(e => e.TicketPromedio)
                    .HasColumnName("TICKET_PROMEDIO")
                    .HasColumnType("money");

                entity.Property(e => e.Transacciones).HasColumnName("TRANSACCIONES");

                entity.Property(e => e.TransaccionesPromediodia)
                    .HasColumnName("TRANSACCIONES_PROMEDIODIA")
                    .HasColumnType("numeric(29, 15)");
            });

            modelBuilder.Entity<ZDashboardecVentasdiaNobodaCm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_VENTASDIA_NOBODA_CM");

                entity.Property(e => e.Diasemana)
                    .HasColumnName("DIASEMANA")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.MontoPromediodia)
                    .HasColumnName("MONTO_PROMEDIODIA")
                    .HasColumnType("money");

                entity.Property(e => e.MontoTotal)
                    .HasColumnName("MONTO_TOTAL")
                    .HasColumnType("money");

                entity.Property(e => e.TicketPromedio)
                    .HasColumnName("TICKET_PROMEDIO")
                    .HasColumnType("decimal(38, 23)");

                entity.Property(e => e.Transacciones).HasColumnName("TRANSACCIONES");

                entity.Property(e => e.TransaccionesPromediodia)
                    .HasColumnName("TRANSACCIONES_PROMEDIODIA")
                    .HasColumnType("decimal(24, 6)");
            });

            modelBuilder.Entity<ZEmailRequerimientoManual>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Z_EMAIL_REQUERIMIENTO_MANUAL");

                entity.Property(e => e.NumRequerimiento)
                    .HasColumnName("Num_Requerimiento")
                    .HasMaxLength(25);

                entity.Property(e => e.Status).HasMaxLength(1);
            });

            modelBuilder.Entity<ZMard>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Z_MARD");

                entity.Property(e => e.Labst)
                    .HasColumnName("LABST")
                    .HasColumnType("numeric(13, 3)");

                entity.Property(e => e.Matnr)
                    .IsRequired()
                    .HasColumnName("MATNR")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Werks)
                    .IsRequired()
                    .HasColumnName("WERKS")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZOlas>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Z_OLAS");

                entity.Property(e => e.CodTienda)
                    .IsRequired()
                    .HasColumnName("Cod_Tienda")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<ZPedidoIncompleto>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Z_PEDIDO_INCOMPLETO");

                entity.Property(e => e.DocSap)
                    .HasColumnName("DocSAP")
                    .HasMaxLength(25);

                entity.Property(e => e.Fecha).HasColumnType("datetime");
            });

            modelBuilder.Entity<ZPedidoMontoAlto>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Z_PEDIDO_MONTO_ALTO");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<ZRequerimientos>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Z_REQUERIMIENTOS");

                entity.Property(e => e.CodTienda)
                    .IsRequired()
                    .HasColumnName("Cod_Tienda")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<ZSkuPromocion>(entity =>
            {
                entity.HasKey(e => e.Sku);

                entity.ToTable("Z_SKU_PROMOCION");

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<ZStockcomprometido>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Z_STOCKCOMPROMETIDO");

                entity.Property(e => e.Matnr)
                    .IsRequired()
                    .HasColumnName("MATNR")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Menge)
                    .HasColumnName("MENGE")
                    .HasColumnType("numeric(38, 3)");

                entity.Property(e => e.Werks)
                    .IsRequired()
                    .HasColumnName("WERKS")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZTblAreaDistCentro20200620>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zTbl_AreaDistCentro20200620");

                entity.Property(e => e.CodAreaDist)
                    .IsRequired()
                    .HasColumnName("Cod_AreaDist")
                    .HasMaxLength(10);

                entity.Property(e => e.CodCentroDist)
                    .IsRequired()
                    .HasColumnName("Cod_CentroDist")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<ZTblArticuloFalta>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("z_tbl_articulo_falta");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("sku")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ZTbldetCodigoDescuento>(entity =>
            {
                entity.HasKey(e => e.CodDesc)
                    .HasName("PK_Z_TBLDET_CODIGO_DESCUENTO2");

                entity.ToTable("Z_TBLDET_CODIGO_DESCUENTO");

                entity.Property(e => e.CodDesc)
                    .HasColumnName("COD_DESC")
                    .HasMaxLength(15);

                entity.Property(e => e.CodTipo).HasColumnName("COD_TIPO");

                entity.Property(e => e.FechaUso)
                    .HasColumnName("FECHA_USO")
                    .HasColumnType("datetime");

                entity.Property(e => e.NumDocumento)
                    .HasColumnName("NUM_DOCUMENTO")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.TipoDesc)
                    .HasColumnName("TIPO_DESC")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ZTbldetCodigoDescuento3>(entity =>
            {
                entity.HasKey(e => e.CodDesc)
                    .HasName("PK_Z_TBLDET_CODIGO_DESCUENTO");

                entity.ToTable("Z_TBLDET_CODIGO_DESCUENTO3");

                entity.HasIndex(e => new { e.CodTipo, e.NumDocumento })
                    .HasName("IX_Z_TBLDET_CODIGO_DESCUENTO_1");

                entity.HasIndex(e => new { e.TipoDesc, e.CodTipo })
                    .HasName("IX_Z_TBLDET_CODIGO_DESCUENTO");

                entity.Property(e => e.CodDesc)
                    .HasColumnName("COD_DESC")
                    .HasMaxLength(15);

                entity.Property(e => e.CodTipo).HasColumnName("COD_TIPO");

                entity.Property(e => e.FechaUso)
                    .HasColumnName("FECHA_USO")
                    .HasColumnType("datetime");

                entity.Property(e => e.NumDocumento)
                    .HasColumnName("NUM_DOCUMENTO")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.TipoDesc)
                    .HasColumnName("TIPO_DESC")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ZVentaCelular>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Z_VENTA_CELULAR");

                entity.Property(e => e.Direccion).HasMaxLength(300);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.NombreCliente).HasMaxLength(250);

                entity.Property(e => e.NombreSku)
                    .HasColumnName("NombreSKU")
                    .HasMaxLength(100);

                entity.Property(e => e.NumDocumento)
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Telefono).HasMaxLength(150);
            });

            modelBuilder.Entity<ZVwCarretaRt>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("z_vw_carreta_rt");

                entity.Property(e => e.Carreta).HasMaxLength(50);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<ZVwDashboardTiendas1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_VW_DASHBOARD_TIENDAS1");

                entity.Property(e => e.AnioCalendarioFact).HasColumnName("ANIO_CALENDARIO_FACT");

                entity.Property(e => e.AnioCalendarioPed).HasColumnName("ANIO_CALENDARIO_PED");

                entity.Property(e => e.CentroDistribucion)
                    .HasColumnName("CENTRO_DISTRIBUCION")
                    .HasMaxLength(10);

                entity.Property(e => e.DiaCalendarioFact).HasColumnName("DIA_CALENDARIO_FACT");

                entity.Property(e => e.DiaCalendarioPed).HasColumnName("DIA_CALENDARIO_PED");

                entity.Property(e => e.DocSap)
                    .HasColumnName("DOC_SAP")
                    .HasMaxLength(25);

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCalendarioFact)
                    .HasColumnName("FECHA_CALENDARIO_FACT")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCalendarioPed)
                    .HasColumnName("FECHA_CALENDARIO_PED")
                    .HasColumnType("datetime");

                entity.Property(e => e.HoraDiaFact).HasColumnName("HORA_DIA_FACT");

                entity.Property(e => e.HoraDiaPed).HasColumnName("HORA_DIA_PED");

                entity.Property(e => e.MesCalendarioFact).HasColumnName("MES_CALENDARIO_FACT");

                entity.Property(e => e.MesCalendarioPed).HasColumnName("MES_CALENDARIO_PED");

                entity.Property(e => e.NombreRecolector)
                    .HasColumnName("NOMBRE_RECOLECTOR")
                    .HasMaxLength(70);

                entity.Property(e => e.RecogerTienda)
                    .IsRequired()
                    .HasColumnName("RECOGER_TIENDA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Recolector)
                    .HasColumnName("RECOLECTOR")
                    .HasMaxLength(40);

                entity.Property(e => e.Telefono).HasMaxLength(150);

                entity.Property(e => e.TiendaEnQueRecoge)
                    .IsRequired()
                    .HasColumnName("TIENDA_EN_QUE_RECOGE")
                    .HasMaxLength(10);

                entity.Property(e => e.TotalPedido)
                    .HasColumnName("TOTAL_PEDIDO")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<ZVwDashboardTiendas2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_VW_DASHBOARD_TIENDAS_2");

                entity.Property(e => e.AñoCalendarioAudita).HasColumnName("AÑO_CALENDARIO_AUDITA");

                entity.Property(e => e.AñoCalendarioConf).HasColumnName("AÑO_CALENDARIO_CONF");

                entity.Property(e => e.AñoRequerimiento).HasColumnName("AÑO_REQUERIMIENTO");

                entity.Property(e => e.CantidadAudita).HasColumnName("CANTIDAD_AUDITA");

                entity.Property(e => e.CantidadConfirma).HasColumnName("CANTIDAD_CONFIRMA");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasColumnName("CATEGORIA")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Departamento)
                    .IsRequired()
                    .HasColumnName("DEPARTAMENTO")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DiaCalendarioAudita).HasColumnName("DIA_CALENDARIO_AUDITA");

                entity.Property(e => e.DiaCalendarioConf).HasColumnName("DIA_CALENDARIO_CONF");

                entity.Property(e => e.DiaRequerimiento).HasColumnName("DIA_REQUERIMIENTO");

                entity.Property(e => e.FechaAudita)
                    .HasColumnName("FECHA_AUDITA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaConfirma)
                    .HasColumnName("FECHA_CONFIRMA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRecibeCatm)
                    .HasColumnName("FECHA_RECIBE_CATM")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRequerimiento)
                    .HasColumnName("FECHA_REQUERIMIENTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.HoraCalendarioAudita).HasColumnName("HORA_CALENDARIO_AUDITA");

                entity.Property(e => e.HoraCalendarioConf).HasColumnName("HORA_CALENDARIO_CONF");

                entity.Property(e => e.HoraRequerimiento).HasColumnName("HORA_REQUERIMIENTO");

                entity.Property(e => e.MesCalendarioAudita).HasColumnName("MES_CALENDARIO_AUDITA");

                entity.Property(e => e.MesCalendarioConf).HasColumnName("MES_CALENDARIO_CONF");

                entity.Property(e => e.MesRequerimiento).HasColumnName("MES_REQUERIMIENTO");

                entity.Property(e => e.NombreEstado)
                    .HasColumnName("NOMBRE_ESTADO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NombreSku)
                    .IsRequired()
                    .HasColumnName("NOMBRE_SKU")
                    .HasMaxLength(100);

                entity.Property(e => e.NombreUsuarioAudita)
                    .HasColumnName("NOMBRE_USUARIO_AUDITA")
                    .HasMaxLength(70);

                entity.Property(e => e.NombreUsuarioConfirma)
                    .HasColumnName("NOMBRE_USUARIO_CONFIRMA")
                    .HasMaxLength(70);

                entity.Property(e => e.NumeroDocumento)
                    .IsRequired()
                    .HasColumnName("NUMERO_DOCUMENTO")
                    .HasMaxLength(25);

                entity.Property(e => e.NumeroPedido)
                    .HasColumnName("NUMERO_PEDIDO")
                    .HasMaxLength(25);

                entity.Property(e => e.NumeroRequerimiento)
                    .IsRequired()
                    .HasColumnName("NUMERO_REQUERIMIENTO")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Tienda)
                    .IsRequired()
                    .HasColumnName("TIENDA")
                    .HasMaxLength(10);

                entity.Property(e => e.UsuarioAudita)
                    .HasColumnName("USUARIO_AUDITA")
                    .HasMaxLength(40);

                entity.Property(e => e.UsuarioConfirma)
                    .HasColumnName("USUARIO_CONFIRMA")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<ZVwDashboardecEmpresaTransporte>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_VW_DASHBOARDEC_EMPRESA_TRANSPORTE");

                entity.Property(e => e.EmpresaTransporte)
                    .IsRequired()
                    .HasColumnName("EMPRESA_TRANSPORTE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Pedidos).HasColumnName("PEDIDOS");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZVwDashboardecEmpresaTransporteCm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_VW_DASHBOARDEC_EMPRESA_TRANSPORTE_CM");

                entity.Property(e => e.EmpresaTransporte)
                    .IsRequired()
                    .HasColumnName("EMPRESA_TRANSPORTE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Pedidos).HasColumnName("PEDIDOS");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZVwHorasEntrega>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_VW_HORAS_ENTREGA");

                entity.Property(e => e.AgrupaHorasEntrega)
                    .HasColumnName("AGRUPA_HORAS_ENTREGA")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.EmpresaTransporte)
                    .IsRequired()
                    .HasColumnName("EMPRESA_TRANSPORTE")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.HorasEntrega).HasColumnName("HORAS_ENTREGA");

                entity.Property(e => e.NumDocumento)
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<ZVwPickingFechaOla>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zVW_PickingFechaOla");

                entity.Property(e => e.Comentarios).HasColumnType("text");

                entity.Property(e => e.FechaOla).HasColumnType("datetime");

                entity.Property(e => e.FechaPick).HasColumnType("datetime");

                entity.Property(e => e.FechaTarima).HasColumnType("datetime");

                entity.Property(e => e.LineaTransporteSap).HasColumnName("LineaTransporteSAP");

                entity.Property(e => e.NumOla)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Pedido).HasMaxLength(25);

                entity.Property(e => e.Recolector).HasMaxLength(40);

                entity.Property(e => e.Tarima).HasMaxLength(40);

                entity.Property(e => e.Tienda)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.TransporteSap)
                    .HasColumnName("TransporteSAP")
                    .HasMaxLength(40);

                entity.Property(e => e.Ubic).HasMaxLength(25);
            });

            modelBuilder.Entity<ZVwPickingPorEntregaDup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_VW_PICKING_POR_ENTREGA_DUP");

                entity.Property(e => e.Año).HasColumnName("AÑO");

                entity.Property(e => e.Departamento)
                    .HasColumnName("DEPARTAMENTO")
                    .HasMaxLength(100);

                entity.Property(e => e.Dia).HasColumnName("DIA");

                entity.Property(e => e.Entrega)
                    .HasColumnName("ENTREGA")
                    .HasMaxLength(40);

                entity.Property(e => e.Mes).HasColumnName("MES");

                entity.Property(e => e.NombreSku)
                    .IsRequired()
                    .HasColumnName("NOMBRE_SKU")
                    .HasMaxLength(100);

                entity.Property(e => e.Pedido)
                    .HasColumnName("PEDIDO")
                    .HasMaxLength(25);

                entity.Property(e => e.Pickeada).HasColumnName("PICKEADA");

                entity.Property(e => e.PosEntrega).HasColumnName("POS_ENTREGA");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Tienda)
                    .IsRequired()
                    .HasColumnName("TIENDA")
                    .HasMaxLength(15);

                entity.Property(e => e.UnidadesAPickear).HasColumnName("UNIDADES_A_PICKEAR");

                entity.Property(e => e.UnidadesPickeadas).HasColumnName("UNIDADES_PICKEADAS");
            });

            modelBuilder.Entity<ZVwPickingPorEntregaFinal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_VW_PICKING_POR_ENTREGA_FINAL");

                entity.Property(e => e.Año).HasColumnName("AÑO");

                entity.Property(e => e.Departamento)
                    .HasColumnName("DEPARTAMENTO")
                    .HasMaxLength(100);

                entity.Property(e => e.Dia).HasColumnName("DIA");

                entity.Property(e => e.Entrega)
                    .HasColumnName("ENTREGA")
                    .HasMaxLength(40);

                entity.Property(e => e.Linea).HasColumnName("LINEA");

                entity.Property(e => e.Mes).HasColumnName("MES");

                entity.Property(e => e.NombreSku)
                    .IsRequired()
                    .HasColumnName("NOMBRE_SKU")
                    .HasMaxLength(100);

                entity.Property(e => e.Pedido)
                    .HasColumnName("PEDIDO")
                    .HasMaxLength(25);

                entity.Property(e => e.Pickeada).HasColumnName("PICKEADA");

                entity.Property(e => e.PickingCero).HasColumnName("PICKING_CERO");

                entity.Property(e => e.PickingCompleto).HasColumnName("PICKING_COMPLETO");

                entity.Property(e => e.PickingParcial).HasColumnName("PICKING_PARCIAL");

                entity.Property(e => e.PosEntrega).HasColumnName("POS_ENTREGA");

                entity.Property(e => e.SinPicking).HasColumnName("SIN_PICKING");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Tienda)
                    .IsRequired()
                    .HasColumnName("TIENDA")
                    .HasMaxLength(15);

                entity.Property(e => e.UnidadesAPickear).HasColumnName("UNIDADES_A_PICKEAR");

                entity.Property(e => e.UnidadesPickeadas).HasColumnName("UNIDADES_PICKEADAS");
            });

            modelBuilder.Entity<ZVwPickingPorEntregaNodup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_VW_PICKING_POR_ENTREGA_NODUP");

                entity.Property(e => e.Año).HasColumnName("AÑO");

                entity.Property(e => e.Departamento)
                    .HasColumnName("DEPARTAMENTO")
                    .HasMaxLength(100);

                entity.Property(e => e.Dia).HasColumnName("DIA");

                entity.Property(e => e.Entrega)
                    .HasColumnName("ENTREGA")
                    .HasMaxLength(40);

                entity.Property(e => e.Mes).HasColumnName("MES");

                entity.Property(e => e.NombreSku)
                    .IsRequired()
                    .HasColumnName("NOMBRE_SKU")
                    .HasMaxLength(100);

                entity.Property(e => e.Pedido)
                    .HasColumnName("PEDIDO")
                    .HasMaxLength(25);

                entity.Property(e => e.Pickeada).HasColumnName("PICKEADA");

                entity.Property(e => e.PosEntrega).HasColumnName("POS_ENTREGA");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Tienda)
                    .IsRequired()
                    .HasColumnName("TIENDA")
                    .HasMaxLength(15);

                entity.Property(e => e.UnidadesAPickear).HasColumnName("UNIDADES_A_PICKEAR");

                entity.Property(e => e.UnidadesPickeadas).HasColumnName("UNIDADES_PICKEADAS");
            });

            modelBuilder.Entity<ZVwRevisionDirecciones>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_VW_REVISION_DIRECCIONES");

                entity.Property(e => e.Departamento).HasMaxLength(100);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.EMail)
                    .HasColumnName("e-mail")
                    .HasMaxLength(100);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Municipio).HasMaxLength(50);

                entity.Property(e => e.NombreCliente)
                    .HasColumnName("Nombre Cliente")
                    .HasMaxLength(100);

                entity.Property(e => e.Pedido).HasMaxLength(25);

                entity.Property(e => e.Telefono).HasMaxLength(150);
            });

            modelBuilder.Entity<ZVwSkuEnProceso>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_VW_SKU_EN_PROCESO");

                entity.Property(e => e.EnProceso).HasColumnName("EN_PROCESO");

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<ZVwSkuEnProceso1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_VW_SKU_EN_PROCESO1");

                entity.Property(e => e.EnProceso).HasColumnName("EN_PROCESO");

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<Zbackuphistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZBackuphistory");

                entity.Property(e => e.BackupFinishDate)
                    .HasColumnName("backup_finish_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.BackupSize)
                    .HasColumnName("backup_size")
                    .HasColumnType("numeric(20, 0)");

                entity.Property(e => e.BackupStartDate)
                    .HasColumnName("backup_start_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.BackupType)
                    .HasColumnName("backup_type")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.BackupsetName)
                    .HasColumnName("backupset_name")
                    .HasMaxLength(128);

                entity.Property(e => e.DatabaseName)
                    .HasColumnName("database_name")
                    .HasMaxLength(128);

                entity.Property(e => e.PhysicalDeviceName)
                    .HasColumnName("physical_device_name")
                    .HasMaxLength(260);

                entity.Property(e => e.Server)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Zcalendarioretail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zcalendarioretail");

                entity.Property(e => e.FechaCalendario).HasColumnType("datetime");
            });

            modelBuilder.Entity<ZcrgArticulodef>(entity =>
            {
                entity.HasKey(e => e.Sku);

                entity.ToTable("ZCRG_ARTICULODEF");

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(20);

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ZnjerarArea>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZNJERAR_AREA");

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasColumnName("AREA")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasColumnName("CATEGORIA")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Departamento)
                    .IsRequired()
                    .HasColumnName("DEPARTAMENTO")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Desarea)
                    .IsRequired()
                    .HasColumnName("DESAREA")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Descategoria)
                    .IsRequired()
                    .HasColumnName("DESCATEGORIA")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Desdepartamento)
                    .IsRequired()
                    .HasColumnName("DESDEPARTAMENTO")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Desfamilia)
                    .IsRequired()
                    .HasColumnName("DESFAMILIA")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Dessubcategoria)
                    .IsRequired()
                    .HasColumnName("DESSUBCATEGORIA")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Familia)
                    .IsRequired()
                    .HasColumnName("FAMILIA")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Subcategoria)
                    .IsRequired()
                    .HasColumnName("SUBCATEGORIA")
                    .HasMaxLength(9)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Zoc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZOC");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.EntregaSap)
                    .HasColumnName("EntregaSAP")
                    .HasMaxLength(1000);

                entity.Property(e => e.Fecha).HasColumnType("datetime");
            });

            modelBuilder.Entity<Zresultadotec>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zresultadotec");

                entity.Property(e => e.VentasT0ec)
                    .HasColumnName("VENTAS_T0EC")
                    .HasMaxLength(43)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Zskumal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zskumal");

                entity.Property(e => e.Categoria)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodEmpresa)
                    .IsRequired()
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.CodGrupo)
                    .HasColumnName("Cod_Grupo")
                    .HasMaxLength(20);

                entity.Property(e => e.CodGrupoMarca).HasColumnName("Cod_GrupoMarca");

                entity.Property(e => e.CodMarca).HasColumnName("Cod_Marca");

                entity.Property(e => e.Creacion).HasColumnType("datetime");

                entity.Property(e => e.Foto)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Modelo).HasMaxLength(100);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<Zskumal2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zskumal2");

                entity.Property(e => e.Categoria)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodEmpresa)
                    .IsRequired()
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.CodGrupo)
                    .HasColumnName("Cod_Grupo")
                    .HasMaxLength(20);

                entity.Property(e => e.CodGrupoMarca).HasColumnName("Cod_GrupoMarca");

                entity.Property(e => e.CodMarca).HasColumnName("Cod_Marca");

                entity.Property(e => e.Creacion).HasColumnType("datetime");

                entity.Property(e => e.Foto)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Modelo).HasMaxLength(100);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<ZtblAreaDistCentroDomingo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZTbl_AreaDistCentro_DOMINGO");

                entity.Property(e => e.CodAreaDist)
                    .IsRequired()
                    .HasColumnName("Cod_AreaDist")
                    .HasMaxLength(10);

                entity.Property(e => e.CodCentroDist)
                    .IsRequired()
                    .HasColumnName("Cod_CentroDist")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<ZtblAreaDistCentroDomingopm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZTbl_AreaDistCentro_DOMINGOPM");

                entity.Property(e => e.CodAreaDist)
                    .IsRequired()
                    .HasColumnName("Cod_AreaDist")
                    .HasMaxLength(10);

                entity.Property(e => e.CodCentroDist)
                    .IsRequired()
                    .HasColumnName("Cod_CentroDist")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<ZtblAreaDistCentroSemana>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZTbl_AreaDistCentro_SEMANA");

                entity.Property(e => e.CodAreaDist)
                    .IsRequired()
                    .HasColumnName("Cod_AreaDist")
                    .HasMaxLength(10);

                entity.Property(e => e.CodCentroDist)
                    .IsRequired()
                    .HasColumnName("Cod_CentroDist")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<ZtblEntregaGuia>(entity =>
            {
                entity.HasKey(e => new { e.Empresa, e.Correlativo })
                    .HasName("PK__ZTBL_ENT__DDB89C043FBB6990");

                entity.ToTable("ZTBL_ENTREGA_GUIA");

                entity.Property(e => e.Empresa).HasMaxLength(15);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Referencia)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Unidad)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Usuario).HasMaxLength(20);
            });

            modelBuilder.Entity<ZtblEntregaProveedor>(entity =>
            {
                entity.HasKey(e => e.IdEntregaProveedor);

                entity.ToTable("ZTbl_EntregaProveedor");

                entity.Property(e => e.IdEntregaProveedor).HasColumnName("Id_EntregaProveedor");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdOrden)
                    .IsRequired()
                    .HasColumnName("Id_Orden")
                    .HasMaxLength(25);

                entity.Property(e => e.IdPedido)
                    .IsRequired()
                    .HasColumnName("Id_Pedido")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.IdResultado)
                    .IsRequired()
                    .HasColumnName("Id_Resultado")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PerEntrega)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PerRecibe)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ZtblEntregaProveedorFotos>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZTbl_EntregaProveedorFotos");

                entity.Property(e => e.Foto)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.IdOrden)
                    .IsRequired()
                    .HasColumnName("Id_Orden")
                    .HasMaxLength(25);

                entity.Property(e => e.IdPedido)
                    .IsRequired()
                    .HasColumnName("Id_Pedido")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<ZtblProveedorLocal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZTbl_ProveedorLocal");

                entity.Property(e => e.CodProveedor)
                    .IsRequired()
                    .HasColumnName("Cod_Proveedor")
                    .HasMaxLength(25);

                entity.Property(e => e.Email).HasColumnName("EMail");

                entity.Property(e => e.HoraCorte1)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.HoraCorte2)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Modo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UltimoCorte)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<ZtbldetEntregaGuia>(entity =>
            {
                entity.HasKey(e => new { e.Empresa, e.Correlativo, e.NoGuia })
                    .HasName("PK__ZTBLDET___7DB2D896438BFA74");

                entity.ToTable("ZTBLDET_ENTREGA_GUIA");

                entity.Property(e => e.Empresa).HasMaxLength(15);

                entity.Property(e => e.NoGuia).HasMaxLength(50);

                entity.Property(e => e.Fecha).HasColumnType("date");
            });

            modelBuilder.Entity<ZtbldetHistorialPedido>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZTBLDET_HISTORIAL_PEDIDO");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.NumDocumento)
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Texto).HasMaxLength(300);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ZtbldetSms>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZTBLDET_SMS");

                entity.HasIndex(e => new { e.CodTipo, e.NumDocumento, e.Tipo })
                    .HasName("idx_codtipo_docto_tipo");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.FechaEnvio).HasColumnType("datetime");

                entity.Property(e => e.FechaGrabacion).HasColumnType("datetime");

                entity.Property(e => e.NumDocumento)
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Resultado).HasMaxLength(10);

                entity.Property(e => e.Telefono).HasMaxLength(150);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ZtbldetSms20200404>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZTBLDET_SMS20200404");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.FechaEnvio).HasColumnType("datetime");

                entity.Property(e => e.FechaGrabacion).HasColumnType("date");

                entity.Property(e => e.Mensaje).HasMaxLength(250);

                entity.Property(e => e.NumDocumento)
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Resultado).HasMaxLength(10);

                entity.Property(e => e.Telefono).HasMaxLength(150);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Ztemporal>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Autorizacion)
                    .IsRequired()
                    .HasColumnName("AUTORIZACION")
                    .HasMaxLength(50);

                entity.Property(e => e.Caja)
                    .IsRequired()
                    .HasColumnName("CAJA")
                    .HasMaxLength(15);

                entity.Property(e => e.CorrPago).HasColumnName("CORR_PAGO");

                entity.Property(e => e.Documento)
                    .HasColumnName("DOCUMENTO")
                    .HasMaxLength(250);

                entity.Property(e => e.Empresa)
                    .IsRequired()
                    .HasColumnName("EMPRESA")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("ESTADO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FormaPago)
                    .IsRequired()
                    .HasColumnName("FORMA_PAGO")
                    .HasMaxLength(50);

                entity.Property(e => e.Moneda)
                    .HasColumnName("MONEDA")
                    .HasMaxLength(5);

                entity.Property(e => e.MontoFormaPago)
                    .HasColumnName("MONTO_FORMA_PAGO")
                    .HasColumnType("money");

                entity.Property(e => e.NumFact)
                    .IsRequired()
                    .HasColumnName("NUM_FACT")
                    .HasMaxLength(25);

                entity.Property(e => e.Serie)
                    .IsRequired()
                    .HasColumnName("SERIE")
                    .HasMaxLength(10);

                entity.Property(e => e.Tienda)
                    .IsRequired()
                    .HasColumnName("TIENDA")
                    .HasMaxLength(10);

                entity.Property(e => e.TipoCambio)
                    .HasColumnName("TIPO_CAMBIO")
                    .HasColumnType("money");

                entity.Property(e => e.Total)
                    .HasColumnName("TOTAL")
                    .HasColumnType("money");

                entity.Property(e => e.Transaccion).HasColumnName("TRANSACCION");
            });

            modelBuilder.Entity<ZtmpSms>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZTMP_SMS");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.DocSap)
                    .HasColumnName("DocSAP")
                    .HasMaxLength(25);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Incompleto)
                    .HasColumnName("INCOMPLETO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(250);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.Telefono).HasMaxLength(150);
            });

            modelBuilder.Entity<ZtmpTblArticuloLocal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZTMP_Tbl_ArticuloLocal");

                entity.Property(e => e.CodProveedor)
                    .HasColumnName("cod_proveedor")
                    .HasMaxLength(25);

                entity.Property(e => e.Modelo)
                    .HasColumnName("modelo")
                    .HasMaxLength(50);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("sku")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<ZviwPedidoIncompleto>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ZVIW_PEDIDO_INCOMPLETO");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.Incompleto)
                    .HasColumnName("INCOMPLETO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<ZviwRequerimientosCentroDistB001>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zviw_RequerimientosCentroDistB001");

                entity.Property(e => e.CentroDistribucion).HasMaxLength(10);

                entity.Property(e => e.FechaLec)
                    .HasColumnName("FechaLEC")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pedido).HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(20);

                entity.Property(e => e.Tienda)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<ZviweBodaNoboda>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ZViwe_BODA_NOBODA");

                entity.Property(e => e.AccionIncompleto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodDestinatario)
                    .HasColumnName("Cod_Destinatario")
                    .HasMaxLength(25);

                entity.Property(e => e.CodEmpresa)
                    .HasColumnName("Cod_Empresa")
                    .HasMaxLength(10);

                entity.Property(e => e.CodEnvoltorio)
                    .HasColumnName("Cod_Envoltorio")
                    .HasMaxLength(25);

                entity.Property(e => e.CodSocio)
                    .IsRequired()
                    .HasColumnName("Cod_Socio")
                    .HasMaxLength(15);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTipoB).HasColumnName("Cod_TipoB");

                entity.Property(e => e.CodTipoC).HasColumnName("Cod_TipoC");

                entity.Property(e => e.CodTipoCred).HasColumnName("Cod_TipoCred");

                entity.Property(e => e.CodTipoRuta).HasColumnName("Cod_TipoRuta");

                entity.Property(e => e.Comentarios).HasColumnType("text");

                entity.Property(e => e.De).HasMaxLength(250);

                entity.Property(e => e.Descuento).HasColumnType("money");

                entity.Property(e => e.DocSap)
                    .HasColumnName("DocSAP")
                    .HasMaxLength(25);

                entity.Property(e => e.Emision).HasColumnType("datetime");

                entity.Property(e => e.Factura).HasMaxLength(25);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaFact).HasColumnType("datetime");

                entity.Property(e => e.FechaReg).HasColumnType("datetime");

                entity.Property(e => e.FinAuditoria).HasColumnType("datetime");

                entity.Property(e => e.IdEvento)
                    .HasColumnName("ID_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.IdUbicEnvuelto)
                    .HasColumnName("ID_UbicEnvuelto")
                    .HasMaxLength(25);

                entity.Property(e => e.IniAuditoria).HasColumnType("datetime");

                entity.Property(e => e.Intercambio)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mensaje).HasMaxLength(4000);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.NumDocumentoB)
                    .IsRequired()
                    .HasColumnName("Num_DocumentoB")
                    .HasMaxLength(25);

                entity.Property(e => e.NumDocumentoC)
                    .HasColumnName("Num_DocumentoC")
                    .HasMaxLength(25);

                entity.Property(e => e.NumDocumentoHh)
                    .HasColumnName("Num_DocumentoHH")
                    .HasMaxLength(25);

                entity.Property(e => e.NumLlamadaNc)
                    .HasColumnName("Num_LLamadaNC")
                    .HasMaxLength(25);

                entity.Property(e => e.NumOla)
                    .HasColumnName("Num_Ola")
                    .HasMaxLength(25);

                entity.Property(e => e.Para).HasMaxLength(250);

                entity.Property(e => e.Precio).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.PrecioBase).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.PrecioOrig).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(20);

                entity.Property(e => e.Skufact)
                    .HasColumnName("SKUFact")
                    .HasMaxLength(20);

                entity.Property(e => e.Skureemplazado)
                    .HasColumnName("SKUReemplazado")
                    .HasMaxLength(25);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Total).HasColumnType("money");
            });

            modelBuilder.Entity<ZvwPedidoIncluyeMuebles>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ZVW_PEDIDO_INCLUYE_MUEBLES");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.IncluyeMuebles)
                    .IsRequired()
                    .HasColumnName("INCLUYE_MUEBLES")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<ZvwPedidoIncluyePromocion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ZVW_PEDIDO_INCLUYE_PROMOCION");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.IncluyePromocion)
                    .IsRequired()
                    .HasColumnName("INCLUYE_PROMOCION")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<ZvwPrimeraCompra>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ZVW_PRIMERA_COMPRA");

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasColumnName("CLIENTE")
                    .HasMaxLength(15);

                entity.Property(e => e.EmailCliente)
                    .HasColumnName("EMAIL_CLIENTE")
                    .HasMaxLength(100);

                entity.Property(e => e.NombreCliente)
                    .HasColumnName("NOMBRE_CLIENTE")
                    .HasMaxLength(100);

                entity.Property(e => e.PrimeraCompra).HasColumnName("PRIMERA_COMPRA");

                entity.Property(e => e.PrimeraCompraNoBodas).HasColumnName("PRIMERA_COMPRA_NO_BODAS");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
