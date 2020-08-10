using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Models.ModelsDomCemaco
{
    public partial class DomCemacoContext : DbContext
    {
        public DomCemacoContext()
        {
        }

        public DomCemacoContext(DbContextOptions<DomCemacoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AcreditacionesPrivilegio> AcreditacionesPrivilegio { get; set; }
        public virtual DbSet<AcreditacionesPrivilegioReserva> AcreditacionesPrivilegioReserva { get; set; }
        public virtual DbSet<ActualizarRutas> ActualizarRutas { get; set; }
        public virtual DbSet<Calendarioretail> Calendarioretail { get; set; }
        public virtual DbSet<CrgArticulo> CrgArticulo { get; set; }
        public virtual DbSet<CrgArticuloConsignado> CrgArticuloConsignado { get; set; }
        public virtual DbSet<CrgArticuloDef> CrgArticuloDef { get; set; }
        public virtual DbSet<CrgBarras> CrgBarras { get; set; }
        public virtual DbSet<CrgDetListaPrecios> CrgDetListaPrecios { get; set; }
        public virtual DbSet<CrgDetListaPreciosDev> CrgDetListaPreciosDev { get; set; }
        public virtual DbSet<CrgGrupoArticulo> CrgGrupoArticulo { get; set; }
        public virtual DbSet<CrgOferta> CrgOferta { get; set; }
        public virtual DbSet<DatosPersonales> DatosPersonales { get; set; }
        public virtual DbSet<DetEnvio> DetEnvio { get; set; }
        public virtual DbSet<EliminarActualizarRegistros> EliminarActualizarRegistros { get; set; }
        public virtual DbSet<Envio> Envio { get; set; }
        public virtual DbSet<Evento> Evento { get; set; }
        public virtual DbSet<ExpoBodas> ExpoBodas { get; set; }
        public virtual DbSet<FormRutas> FormRutas { get; set; }
        public virtual DbSet<HistoDetListaRegalos> HistoDetListaRegalos { get; set; }
        public virtual DbSet<IntDetEnvio> IntDetEnvio { get; set; }
        public virtual DbSet<IntEnvio> IntEnvio { get; set; }
        public virtual DbSet<IntEvento> IntEvento { get; set; }
        public virtual DbSet<IntListaRegalos> IntListaRegalos { get; set; }
        public virtual DbSet<IntNovios> IntNovios { get; set; }
        public virtual DbSet<IntPersonaEvento> IntPersonaEvento { get; set; }
        public virtual DbSet<IntRegaloComprado> IntRegaloComprado { get; set; }
        public virtual DbSet<ListaRegalos> ListaRegalos { get; set; }
        public virtual DbSet<PersonaEvento> PersonaEvento { get; set; }
        public virtual DbSet<PosOferta> PosOferta { get; set; }
        public virtual DbSet<PosPrecio> PosPrecio { get; set; }
        public virtual DbSet<RegaloComprado> RegaloComprado { get; set; }
        public virtual DbSet<RegalosAgregados> RegalosAgregados { get; set; }
        public virtual DbSet<ReptempDetenvio> ReptempDetenvio { get; set; }
        public virtual DbSet<ReptempEntregado> ReptempEntregado { get; set; }
        public virtual DbSet<ReptempEnvio> ReptempEnvio { get; set; }
        public virtual DbSet<ReptempNumrutas> ReptempNumrutas { get; set; }
        public virtual DbSet<ReptempRecepcatm> ReptempRecepcatm { get; set; }
        public virtual DbSet<ReptempRutas> ReptempRutas { get; set; }
        public virtual DbSet<RevDetRequerimiento> RevDetRequerimiento { get; set; }
        public virtual DbSet<RutaFormulario> RutaFormulario { get; set; }
        public virtual DbSet<TblAplicacion> TblAplicacion { get; set; }
        public virtual DbSet<TblAreaDistribucion> TblAreaDistribucion { get; set; }
        public virtual DbSet<TblAreaDistribucionCentro> TblAreaDistribucionCentro { get; set; }
        public virtual DbSet<TblArticulo> TblArticulo { get; set; }
        public virtual DbSet<TblArticuloAct> TblArticuloAct { get; set; }
        public virtual DbSet<TblArticuloConsignado> TblArticuloConsignado { get; set; }
        public virtual DbSet<TblArticuloDef> TblArticuloDef { get; set; }
        public virtual DbSet<TblArticuloGrupo> TblArticuloGrupo { get; set; }
        public virtual DbSet<TblArticuloListaReg> TblArticuloListaReg { get; set; }
        public virtual DbSet<TblAsociadoEventos> TblAsociadoEventos { get; set; }
        public virtual DbSet<TblBarras> TblBarras { get; set; }
        public virtual DbSet<TblBeneficioBodas> TblBeneficioBodas { get; set; }
        public virtual DbSet<TblCambioSoft> TblCambioSoft { get; set; }
        public virtual DbSet<TblCanjeCupon> TblCanjeCupon { get; set; }
        public virtual DbSet<TblCierreOs> TblCierreOs { get; set; }
        public virtual DbSet<TblCliente> TblCliente { get; set; }
        public virtual DbSet<TblColor> TblColor { get; set; }
        public virtual DbSet<TblConex> TblConex { get; set; }
        public virtual DbSet<TblConexPunto> TblConexPunto { get; set; }
        public virtual DbSet<TblContactoCliente> TblContactoCliente { get; set; }
        public virtual DbSet<TblContactoPedido> TblContactoPedido { get; set; }
        public virtual DbSet<TblConversionEventos> TblConversionEventos { get; set; }
        public virtual DbSet<TblDepartamento> TblDepartamento { get; set; }
        public virtual DbSet<TblDetAreaDistribucion> TblDetAreaDistribucion { get; set; }
        public virtual DbSet<TblDetEnvio> TblDetEnvio { get; set; }
        public virtual DbSet<TblDetEnvioRetorno> TblDetEnvioRetorno { get; set; }
        public virtual DbSet<TblDetLiberado> TblDetLiberado { get; set; }
        public virtual DbSet<TblDetListaPrecios> TblDetListaPrecios { get; set; }
        public virtual DbSet<TblDetListaRegalos> TblDetListaRegalos { get; set; }
        public virtual DbSet<TblDetListaRegalosVencido> TblDetListaRegalosVencido { get; set; }
        public virtual DbSet<TblDetOrdenMant> TblDetOrdenMant { get; set; }
        public virtual DbSet<TblDetPedido> TblDetPedido { get; set; }
        public virtual DbSet<TblDetReqPendiente> TblDetReqPendiente { get; set; }
        public virtual DbSet<TblDetRequerimiento> TblDetRequerimiento { get; set; }
        public virtual DbSet<TblDetRequerimientoAnul> TblDetRequerimientoAnul { get; set; }
        public virtual DbSet<TblDetReserva> TblDetReserva { get; set; }
        public virtual DbSet<TblDetRuta> TblDetRuta { get; set; }
        public virtual DbSet<TblDetRutaRechazo> TblDetRutaRechazo { get; set; }
        public virtual DbSet<TblDetRutaRetenido> TblDetRutaRetenido { get; set; }
        public virtual DbSet<TblDetTraslado> TblDetTraslado { get; set; }
        public virtual DbSet<TblDetTrasladoVenta> TblDetTrasladoVenta { get; set; }
        public virtual DbSet<TblDetValeComb> TblDetValeComb { get; set; }
        public virtual DbSet<TblDirSinConfirmar> TblDirSinConfirmar { get; set; }
        public virtual DbSet<TblDocSap> TblDocSap { get; set; }
        public virtual DbSet<TblDocumentoDig> TblDocumentoDig { get; set; }
        public virtual DbSet<TblEntregaDistal> TblEntregaDistal { get; set; }
        public virtual DbSet<TblEntregaMonia> TblEntregaMonia { get; set; }
        public virtual DbSet<TblEnvio> TblEnvio { get; set; }
        public virtual DbSet<TblEnvioDir> TblEnvioDir { get; set; }
        public virtual DbSet<TblEnvioEmp> TblEnvioEmp { get; set; }
        public virtual DbSet<TblEnvioErrAsociacion> TblEnvioErrAsociacion { get; set; }
        public virtual DbSet<TblEnvioMail> TblEnvioMail { get; set; }
        public virtual DbSet<TblEnvioNc> TblEnvioNc { get; set; }
        public virtual DbSet<TblEnvioNcmail> TblEnvioNcmail { get; set; }
        public virtual DbSet<TblEnvioOpEntrega> TblEnvioOpEntrega { get; set; }
        public virtual DbSet<TblEnvioOs> TblEnvioOs { get; set; }
        public virtual DbSet<TblEnvioTrasladoLec> TblEnvioTrasladoLec { get; set; }
        public virtual DbSet<TblEtiquetaEnvio> TblEtiquetaEnvio { get; set; }
        public virtual DbSet<TblEvento> TblEvento { get; set; }
        public virtual DbSet<TblEvento2> TblEvento2 { get; set; }
        public virtual DbSet<TblEventoActualizado> TblEventoActualizado { get; set; }
        public virtual DbSet<TblEventoAlerta> TblEventoAlerta { get; set; }
        public virtual DbSet<TblEventoCancelado> TblEventoCancelado { get; set; }
        public virtual DbSet<TblEventoCertRegalo> TblEventoCertRegalo { get; set; }
        public virtual DbSet<TblEventoExpo> TblEventoExpo { get; set; }
        public virtual DbSet<TblEventoMail> TblEventoMail { get; set; }
        public virtual DbSet<TblEventoModif> TblEventoModif { get; set; }
        public virtual DbSet<TblEventoPrivi> TblEventoPrivi { get; set; }
        public virtual DbSet<TblEventoRef> TblEventoRef { get; set; }
        public virtual DbSet<TblEventoTdaLiq> TblEventoTdaLiq { get; set; }
        public virtual DbSet<TblExistencia> TblExistencia { get; set; }
        public virtual DbSet<TblGrupoArticulo> TblGrupoArticulo { get; set; }
        public virtual DbSet<TblGrupoArticuloNOld> TblGrupoArticuloNOld { get; set; }
        public virtual DbSet<TblImgDocumentoDig> TblImgDocumentoDig { get; set; }
        public virtual DbSet<TblListaRegalos> TblListaRegalos { get; set; }
        public virtual DbSet<TblLogMailEvento> TblLogMailEvento { get; set; }
        public virtual DbSet<TblLogTrasladoCentral> TblLogTrasladoCentral { get; set; }
        public virtual DbSet<TblLoginTemporal> TblLoginTemporal { get; set; }
        public virtual DbSet<TblMarca> TblMarca { get; set; }
        public virtual DbSet<TblMarcaVehiculo> TblMarcaVehiculo { get; set; }
        public virtual DbSet<TblMedida> TblMedida { get; set; }
        public virtual DbSet<TblMunicipio> TblMunicipio { get; set; }
        public virtual DbSet<TblObsEvento> TblObsEvento { get; set; }
        public virtual DbSet<TblObsEventoExpo> TblObsEventoExpo { get; set; }
        public virtual DbSet<TblObsPedido> TblObsPedido { get; set; }
        public virtual DbSet<TblOferta> TblOferta { get; set; }
        public virtual DbSet<TblOrdenMant> TblOrdenMant { get; set; }
        public virtual DbSet<TblPais> TblPais { get; set; }
        public virtual DbSet<TblParametro> TblParametro { get; set; }
        public virtual DbSet<TblPedido> TblPedido { get; set; }
        public virtual DbSet<TblPerfil> TblPerfil { get; set; }
        public virtual DbSet<TblPermiso> TblPermiso { get; set; }
        public virtual DbSet<TblPersonaEvento> TblPersonaEvento { get; set; }
        public virtual DbSet<TblPersonaEventoExpo> TblPersonaEventoExpo { get; set; }
        public virtual DbSet<TblPersonal> TblPersonal { get; set; }
        public virtual DbSet<TblPrecioNormal> TblPrecioNormal { get; set; }
        public virtual DbSet<TblProveedor> TblProveedor { get; set; }
        public virtual DbSet<TblPuntosArranque> TblPuntosArranque { get; set; }
        public virtual DbSet<TblRefGeografica> TblRefGeografica { get; set; }
        public virtual DbSet<TblRepDinamico> TblRepDinamico { get; set; }
        public virtual DbSet<TblReservaRegalo> TblReservaRegalo { get; set; }
        public virtual DbSet<TblRuta> TblRuta { get; set; }
        public virtual DbSet<TblRutaDisatel> TblRutaDisatel { get; set; }
        public virtual DbSet<TblSeguimiento> TblSeguimiento { get; set; }
        public virtual DbSet<TblSeguimientoExpo> TblSeguimientoExpo { get; set; }
        public virtual DbSet<TblServRep> TblServRep { get; set; }
        public virtual DbSet<TblSkuSuplemento> TblSkuSuplemento { get; set; }
        public virtual DbSet<TblSobre> TblSobre { get; set; }
        public virtual DbSet<TblTamanoProducto> TblTamanoProducto { get; set; }
        public virtual DbSet<TblTiendaDespLec> TblTiendaDespLec { get; set; }
        public virtual DbSet<TblTiendaPerfil> TblTiendaPerfil { get; set; }
        public virtual DbSet<TblTiendaPerfilMala> TblTiendaPerfilMala { get; set; }
        public virtual DbSet<TblTipoAlerta> TblTipoAlerta { get; set; }
        public virtual DbSet<TblTipoAnfitrion> TblTipoAnfitrion { get; set; }
        public virtual DbSet<TblTipoContacto> TblTipoContacto { get; set; }
        public virtual DbSet<TblTipoCupon> TblTipoCupon { get; set; }
        public virtual DbSet<TblTipoDocumento> TblTipoDocumento { get; set; }
        public virtual DbSet<TblTipoEmpaque> TblTipoEmpaque { get; set; }
        public virtual DbSet<TblTipoEvento> TblTipoEvento { get; set; }
        public virtual DbSet<TblTipoEventoLv> TblTipoEventoLv { get; set; }
        public virtual DbSet<TblTipoIdentificacion> TblTipoIdentificacion { get; set; }
        public virtual DbSet<TblTipoLista> TblTipoLista { get; set; }
        public virtual DbSet<TblTipoMail> TblTipoMail { get; set; }
        public virtual DbSet<TblTipoPago> TblTipoPago { get; set; }
        public virtual DbSet<TblTipoPedido> TblTipoPedido { get; set; }
        public virtual DbSet<TblTipoProducto> TblTipoProducto { get; set; }
        public virtual DbSet<TblTipoUbicFisica> TblTipoUbicFisica { get; set; }
        public virtual DbSet<TblTipoUbicTev> TblTipoUbicTev { get; set; }
        public virtual DbSet<TblTipoVehiculo> TblTipoVehiculo { get; set; }
        public virtual DbSet<TblTipoZonaRoja> TblTipoZonaRoja { get; set; }
        public virtual DbSet<TblTrasladoCentral> TblTrasladoCentral { get; set; }
        public virtual DbSet<TblUbicFisica> TblUbicFisica { get; set; }
        public virtual DbSet<TblUbicFisicaLec> TblUbicFisicaLec { get; set; }
        public virtual DbSet<TblUbicFisicaMala> TblUbicFisicaMala { get; set; }
        public virtual DbSet<TblUsuario> TblUsuario { get; set; }
        public virtual DbSet<TblUsuarioTmp> TblUsuarioTmp { get; set; }
        public virtual DbSet<TblValeComb> TblValeComb { get; set; }
        public virtual DbSet<TblVehiculo> TblVehiculo { get; set; }
        public virtual DbSet<TblZona> TblZona { get; set; }
        public virtual DbSet<TblZonaRoja> TblZonaRoja { get; set; }
        public virtual DbSet<TbldetListaregalosAll> TbldetListaregalosAll { get; set; }
        public virtual DbSet<TempDetEnvio> TempDetEnvio { get; set; }
        public virtual DbSet<TempDetListaRegalos> TempDetListaRegalos { get; set; }
        public virtual DbSet<TempDetOrdenMant> TempDetOrdenMant { get; set; }
        public virtual DbSet<TempDetReserva> TempDetReserva { get; set; }
        public virtual DbSet<TempDetRuta> TempDetRuta { get; set; }
        public virtual DbSet<TempEventos> TempEventos { get; set; }
        public virtual DbSet<TempOferta> TempOferta { get; set; }
        public virtual DbSet<TempPersonaEvento> TempPersonaEvento { get; set; }
        public virtual DbSet<TempTipoAnfitrion> TempTipoAnfitrion { get; set; }
        public virtual DbSet<TmpEcommerceSkuListasNoCreados> TmpEcommerceSkuListasNoCreados { get; set; }
        public virtual DbSet<TmpListadosBodas220417> TmpListadosBodas220417 { get; set; }
        public virtual DbSet<TmpMailEnvioBodasErroneo030517> TmpMailEnvioBodasErroneo030517 { get; set; }
        public virtual DbSet<TmsDocInterfaz> TmsDocInterfaz { get; set; }
        public virtual DbSet<Upc> Upc { get; set; }
        public virtual DbSet<ViwAcumulacionRegalo> ViwAcumulacionRegalo { get; set; }
        public virtual DbSet<ViwAnalisisBodas> ViwAnalisisBodas { get; set; }
        public virtual DbSet<ViwAnalisisLiquidacionesBodasBorrar> ViwAnalisisLiquidacionesBodasBorrar { get; set; }
        public virtual DbSet<ViwAnfitrion> ViwAnfitrion { get; set; }
        public virtual DbSet<ViwAniversarioBodas> ViwAniversarioBodas { get; set; }
        public virtual DbSet<ViwAniversarioBodasCompras> ViwAniversarioBodasCompras { get; set; }
        public virtual DbSet<ViwAniversarioBodasComprasDespuesDeLiquidacion> ViwAniversarioBodasComprasDespuesDeLiquidacion { get; set; }
        public virtual DbSet<ViwAniversarioBodasExpo> ViwAniversarioBodasExpo { get; set; }
        public virtual DbSet<ViwAniversarioBodasSinCompras> ViwAniversarioBodasSinCompras { get; set; }
        public virtual DbSet<ViwAniversariobodascompraslistascompletas> ViwAniversariobodascompraslistascompletas { get; set; }
        public virtual DbSet<ViwArea> ViwArea { get; set; }
        public virtual DbSet<ViwAreaBodas> ViwAreaBodas { get; set; }
        public virtual DbSet<ViwAreaCs> ViwAreaCs { get; set; }
        public virtual DbSet<ViwAreaDom> ViwAreaDom { get; set; }
        public virtual DbSet<ViwArticuloGrupo> ViwArticuloGrupo { get; set; }
        public virtual DbSet<ViwArticulos> ViwArticulos { get; set; }
        public virtual DbSet<ViwBodasCompras> ViwBodasCompras { get; set; }
        public virtual DbSet<ViwBodasComprasCall> ViwBodasComprasCall { get; set; }
        public virtual DbSet<ViwBodasComprasCallDir> ViwBodasComprasCallDir { get; set; }
        public virtual DbSet<ViwBodasComprasSku> ViwBodasComprasSku { get; set; }
        public virtual DbSet<ViwBodasComprasXela> ViwBodasComprasXela { get; set; }
        public virtual DbSet<ViwBodasComprasXelaSku> ViwBodasComprasXelaSku { get; set; }
        public virtual DbSet<ViwBodasIntercambio> ViwBodasIntercambio { get; set; }
        public virtual DbSet<ViwBodasLiquidadas> ViwBodasLiquidadas { get; set; }
        public virtual DbSet<ViwBodasNoviosConPrivilegio> ViwBodasNoviosConPrivilegio { get; set; }
        public virtual DbSet<ViwBodasRegistradasXela> ViwBodasRegistradasXela { get; set; }
        public virtual DbSet<ViwBodasTipoLista> ViwBodasTipoLista { get; set; }
        public virtual DbSet<ViwCantidadBodas> ViwCantidadBodas { get; set; }
        public virtual DbSet<ViwCantidadBodasCertificados> ViwCantidadBodasCertificados { get; set; }
        public virtual DbSet<ViwCantidadDeBodasTipo> ViwCantidadDeBodasTipo { get; set; }
        public virtual DbSet<ViwConsultaExistenciaTiendas> ViwConsultaExistenciaTiendas { get; set; }
        public virtual DbSet<ViwDetApartado> ViwDetApartado { get; set; }
        public virtual DbSet<ViwDetEnvioLib> ViwDetEnvioLib { get; set; }
        public virtual DbSet<ViwDetListaRegalos> ViwDetListaRegalos { get; set; }
        public virtual DbSet<ViwDetListaRegalosAct> ViwDetListaRegalosAct { get; set; }
        public virtual DbSet<ViwDetRegalosComprados> ViwDetRegalosComprados { get; set; }
        public virtual DbSet<ViwDetRequerimiento> ViwDetRequerimiento { get; set; }
        public virtual DbSet<ViwDetTraslado> ViwDetTraslado { get; set; }
        public virtual DbSet<ViwDetalleBodasTipo> ViwDetalleBodasTipo { get; set; }
        public virtual DbSet<ViwDirEnvio> ViwDirEnvio { get; set; }
        public virtual DbSet<ViwDirEvento> ViwDirEvento { get; set; }
        public virtual DbSet<ViwEnvioEnt> ViwEnvioEnt { get; set; }
        public virtual DbSet<ViwEnviosPosterioresBodasLiquidadas> ViwEnviosPosterioresBodasLiquidadas { get; set; }
        public virtual DbSet<ViwEnviosporEmp> ViwEnviosporEmp { get; set; }
        public virtual DbSet<ViwEstatusDeRegalos> ViwEstatusDeRegalos { get; set; }
        public virtual DbSet<ViwEventoBeneficio> ViwEventoBeneficio { get; set; }
        public virtual DbSet<ViwExistencias> ViwExistencias { get; set; }
        public virtual DbSet<ViwExistencias2> ViwExistencias2 { get; set; }
        public virtual DbSet<ViwExpoBodas> ViwExpoBodas { get; set; }
        public virtual DbSet<ViwInscripcionAsesoras> ViwInscripcionAsesoras { get; set; }
        public virtual DbSet<ViwNoRecorridos> ViwNoRecorridos { get; set; }
        public virtual DbSet<ViwNovios> ViwNovios { get; set; }
        public virtual DbSet<ViwNovios2> ViwNovios2 { get; set; }
        public virtual DbSet<ViwRegaloComprado> ViwRegaloComprado { get; set; }
        public virtual DbSet<ViwRegalosComprados> ViwRegalosComprados { get; set; }
        public virtual DbSet<ViwTiempoEntrega> ViwTiempoEntrega { get; set; }
        public virtual DbSet<ViwTrasladoEnvio> ViwTrasladoEnvio { get; set; }
        public virtual DbSet<ViwTrasladoPendiente> ViwTrasladoPendiente { get; set; }
        public virtual DbSet<ViwVentasTienda> ViwVentasTienda { get; set; }
        public virtual DbSet<VwBodasTotalCompras> VwBodasTotalCompras { get; set; }
        public virtual DbSet<VwEventosPorFechaEventoReporteDinamico> VwEventosPorFechaEventoReporteDinamico { get; set; }
        public virtual DbSet<VwFormularioEntrega> VwFormularioEntrega { get; set; }
        public virtual DbSet<VwFormularioLogisticaVerificarNoPedido> VwFormularioLogisticaVerificarNoPedido { get; set; }
        public virtual DbSet<VwInscripcionesBebe> VwInscripcionesBebe { get; set; }
        public virtual DbSet<VwInscripcionesClubBebe> VwInscripcionesClubBebe { get; set; }
        public virtual DbSet<VwInscripcionesEventosReporteDinamico> VwInscripcionesEventosReporteDinamico { get; set; }
        public virtual DbSet<VwInscripcionesSinRecoridoBebe> VwInscripcionesSinRecoridoBebe { get; set; }
        public virtual DbSet<VwRecorridoEventoAdultosReporteDinamico> VwRecorridoEventoAdultosReporteDinamico { get; set; }
        public virtual DbSet<VwRecorridosClubBebe> VwRecorridosClubBebe { get; set; }
        public virtual DbSet<VwVentasporEvento1> VwVentasporEvento1 { get; set; }
        public virtual DbSet<VwVentasporEvento2> VwVentasporEvento2 { get; set; }
        public virtual DbSet<VwZreporteCallCenterLista> VwZreporteCallCenterLista { get; set; }
        public virtual DbSet<VwZreporteTotalVentasClubBebe> VwZreporteTotalVentasClubBebe { get; set; }
        public virtual DbSet<VwZreporteVentasClubBebe> VwZreporteVentasClubBebe { get; set; }
        public virtual DbSet<ZBorrarEvenoBebe> ZBorrarEvenoBebe { get; set; }
        public virtual DbSet<ZDashboardecActivoevento> ZDashboardecActivoevento { get; set; }
        public virtual DbSet<ZDashboardecBodasActivas> ZDashboardecBodasActivas { get; set; }
        public virtual DbSet<ZDashboardecEventosConRegalo> ZDashboardecEventosConRegalo { get; set; }
        public virtual DbSet<ZDashboardecEventosConRegaloCm> ZDashboardecEventosConRegaloCm { get; set; }
        public virtual DbSet<ZDashboardecEventosRegaloT0ec> ZDashboardecEventosRegaloT0ec { get; set; }
        public virtual DbSet<ZDashboardecEventosRegaloT0ecCm> ZDashboardecEventosRegaloT0ecCm { get; set; }
        public virtual DbSet<ZDashboardecEventosregistrados> ZDashboardecEventosregistrados { get; set; }
        public virtual DbSet<ZDashboardecEventosregistradosCm> ZDashboardecEventosregistradosCm { get; set; }
        public virtual DbSet<ZDashboardecTopskuCm> ZDashboardecTopskuCm { get; set; }
        public virtual DbSet<ZDashboardecTopskuLmtd> ZDashboardecTopskuLmtd { get; set; }
        public virtual DbSet<ZDashboardecTopskuLw> ZDashboardecTopskuLw { get; set; }
        public virtual DbSet<ZDashboardecTopskuLymtd> ZDashboardecTopskuLymtd { get; set; }
        public virtual DbSet<ZDashboardecTopskuMtd> ZDashboardecTopskuMtd { get; set; }
        public virtual DbSet<ZDashboardecVentasTiendaInternet> ZDashboardecVentasTiendaInternet { get; set; }
        public virtual DbSet<ZDashboardecVentasTiendaInternetCm> ZDashboardecVentasTiendaInternetCm { get; set; }
        public virtual DbSet<ZEncabezadoEnvio> ZEncabezadoEnvio { get; set; }
        public virtual DbSet<ZEventoBebe> ZEventoBebe { get; set; }
        public virtual DbSet<ZEventosBdBodas> ZEventosBdBodas { get; set; }
        public virtual DbSet<ZTblEmailEnvio> ZTblEmailEnvio { get; set; }
        public virtual DbSet<ZVwBwEventos> ZVwBwEventos { get; set; }
        public virtual DbSet<ZtblAnalisisDatos2018> ZtblAnalisisDatos2018 { get; set; }
        public virtual DbSet<ZtblAnalisisDatos2019> ZtblAnalisisDatos2019 { get; set; }
        public virtual DbSet<ZtblBeneficiosbodas> ZtblBeneficiosbodas { get; set; }
        public virtual DbSet<ZtblBkTblUbicfisicaCl> ZtblBkTblUbicfisicaCl { get; set; }
        public virtual DbSet<ZtblCorrigeprecio> ZtblCorrigeprecio { get; set; }
        public virtual DbSet<ZtblCorrigeprecio1> ZtblCorrigeprecio1 { get; set; }
        public virtual DbSet<ZtblEncVentasAcumuladas> ZtblEncVentasAcumuladas { get; set; }
        public virtual DbSet<ZtblEnvio> ZtblEnvio { get; set; }
        public virtual DbSet<ZtblEnvioerrasociacionjra> ZtblEnvioerrasociacionjra { get; set; }
        public virtual DbSet<ZtblEvento20160908> ZtblEvento20160908 { get; set; }
        public virtual DbSet<ZtblEvento2017090093> ZtblEvento2017090093 { get; set; }
        public virtual DbSet<ZtblEventocertregalo> ZtblEventocertregalo { get; set; }
        public virtual DbSet<ZtblEventopruebas> ZtblEventopruebas { get; set; }
        public virtual DbSet<ZtblEventosliquidados> ZtblEventosliquidados { get; set; }
        public virtual DbSet<ZtblPersonaevento2017090093> ZtblPersonaevento2017090093 { get; set; }
        public virtual DbSet<ZtblPersonalBk> ZtblPersonalBk { get; set; }
        public virtual DbSet<ZtblTeAgarre> ZtblTeAgarre { get; set; }
        public virtual DbSet<ZtblVentasAcumuladas> ZtblVentasAcumuladas { get; set; }
        public virtual DbSet<ZtmpBodasEcommNoEmail> ZtmpBodasEcommNoEmail { get; set; }
        public virtual DbSet<ZtmpBodasEcommerceCargadas> ZtmpBodasEcommerceCargadas { get; set; }
        public virtual DbSet<ZtmpBodasregalos20142015> ZtmpBodasregalos20142015 { get; set; }
        public virtual DbSet<ZtmpConlista> ZtmpConlista { get; set; }
        public virtual DbSet<ZtmpDetalleregalos2010Fecha> ZtmpDetalleregalos2010Fecha { get; set; }
        public virtual DbSet<ZtmpEcommerceDatosNovios> ZtmpEcommerceDatosNovios { get; set; }
        public virtual DbSet<ZtmpEcommerceDatosNovios071119> ZtmpEcommerceDatosNovios071119 { get; set; }
        public virtual DbSet<ZtmpEcommerceNoviosEmail> ZtmpEcommerceNoviosEmail { get; set; }
        public virtual DbSet<ZtmpEcommerceNoviosEmail2> ZtmpEcommerceNoviosEmail2 { get; set; }
        public virtual DbSet<ZtmpEnvio> ZtmpEnvio { get; set; }
        public virtual DbSet<ZtmpEnvioCc07> ZtmpEnvioCc07 { get; set; }
        public virtual DbSet<ZtmpEnvionc> ZtmpEnvionc { get; set; }
        public virtual DbSet<ZtmpEnviosLiquidacion> ZtmpEnviosLiquidacion { get; set; }
        public virtual DbSet<ZtmpEventoBackupBabyshower> ZtmpEventoBackupBabyshower { get; set; }
        public virtual DbSet<ZtmpEventoHernandez> ZtmpEventoHernandez { get; set; }
        public virtual DbSet<ZtmpEventoPopaSacor> ZtmpEventoPopaSacor { get; set; }
        public virtual DbSet<ZtmpEventoSaquilmer> ZtmpEventoSaquilmer { get; set; }
        public virtual DbSet<ZtmpEventoprueba> ZtmpEventoprueba { get; set; }
        public virtual DbSet<ZtmpEventos> ZtmpEventos { get; set; }
        public virtual DbSet<ZtmpEventossinpersonaevento> ZtmpEventossinpersonaevento { get; set; }
        public virtual DbSet<ZtmpExistencia> ZtmpExistencia { get; set; }
        public virtual DbSet<ZtmpExpoBodas> ZtmpExpoBodas { get; set; }
        public virtual DbSet<ZtmpLiquidaciones> ZtmpLiquidaciones { get; set; }
        public virtual DbSet<ZtmpListaregalos> ZtmpListaregalos { get; set; }
        public virtual DbSet<ZtmpNombresinvitados> ZtmpNombresinvitados { get; set; }
        public virtual DbSet<ZtmpPasaparaenvios> ZtmpPasaparaenvios { get; set; }
        public virtual DbSet<ZtmpPersonaeventoPopaSacor> ZtmpPersonaeventoPopaSacor { get; set; }
        public virtual DbSet<ZtmpPersonaeventoSaquilmer> ZtmpPersonaeventoSaquilmer { get; set; }
        public virtual DbSet<ZtmpPersonaeventosinevento> ZtmpPersonaeventosinevento { get; set; }
        public virtual DbSet<ZtmpSinlista> ZtmpSinlista { get; set; }
        public virtual DbSet<ZtmpUsuariosbodasactivos> ZtmpUsuariosbodasactivos { get; set; }
        public virtual DbSet<ZtmpVentasevento> ZtmpVentasevento { get; set; }
        public virtual DbSet<ZtmpdetEnviosinenvios> ZtmpdetEnviosinenvios { get; set; }
        public virtual DbSet<ZtmpdetListaregalos> ZtmpdetListaregalos { get; set; }
        public virtual DbSet<ZviwListadoBebes> ZviwListadoBebes { get; set; }
        public virtual DbSet<ZviwRegaloDetalle> ZviwRegaloDetalle { get; set; }
        public virtual DbSet<ZvwEnvioRuta> ZvwEnvioRuta { get; set; }
        public virtual DbSet<ZvwVistaTemp> ZvwVistaTemp { get; set; }
        public virtual DbSet<ZvwVistaTemp1> ZvwVistaTemp1 { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AcreditacionesPrivilegio>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Acreditaciones_Privilegio");

                entity.Property(e => e.ApellidoNovia1).HasMaxLength(30);

                entity.Property(e => e.ApellidoNovia2).HasMaxLength(30);

                entity.Property(e => e.ApellidoNovio1).HasMaxLength(30);

                entity.Property(e => e.ApellidoNovio2).HasMaxLength(30);

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasColumnName("Cod_Ubicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.FechaEvento).HasColumnType("datetime");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("Id_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.MontoEnVentas)
                    .HasColumnName("Monto_en_Ventas")
                    .HasColumnType("money");

                entity.Property(e => e.NombreNovia1).HasMaxLength(30);

                entity.Property(e => e.NombreNovia2).HasMaxLength(30);

                entity.Property(e => e.NombreNovio1).HasMaxLength(30);

                entity.Property(e => e.NombreNovio2).HasMaxLength(30);

                entity.Property(e => e.TarjetaPrivilegio)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AcreditacionesPrivilegioReserva>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Acreditaciones_Privilegio_Reserva");

                entity.Property(e => e.ApellidoNovia1).HasMaxLength(30);

                entity.Property(e => e.ApellidoNovia2).HasMaxLength(30);

                entity.Property(e => e.ApellidoNovio1).HasMaxLength(30);

                entity.Property(e => e.ApellidoNovio2).HasMaxLength(30);

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasColumnName("Cod_Ubicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.FechaEvento).HasColumnType("datetime");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("Id_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.Monto)
                    .HasColumnName("monto")
                    .HasColumnType("money");

                entity.Property(e => e.NombreNovia1).HasMaxLength(30);

                entity.Property(e => e.NombreNovia2).HasMaxLength(30);

                entity.Property(e => e.NombreNovio1).HasMaxLength(30);

                entity.Property(e => e.NombreNovio2).HasMaxLength(30);

                entity.Property(e => e.TarjetaPrivilegio)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ActualizarRutas>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.FechaEntrega)
                    .HasColumnName("Fecha entrega")
                    .HasColumnType("datetime");

                entity.Property(e => e.Guia).HasMaxLength(255);

                entity.Property(e => e.PersonaQueEntrega)
                    .HasColumnName("Persona que entrega")
                    .HasMaxLength(255);

                entity.Property(e => e.PersonaQueRecibe)
                    .HasColumnName("Persona que recibe")
                    .HasMaxLength(255);

                entity.Property(e => e.ResultadoDeLaEntrega)
                    .HasColumnName("Resultado de la entrega")
                    .HasMaxLength(255);

                entity.Property(e => e.SeleccioneElTipoDeGuíaDatosAntesDelGuión)
                    .HasColumnName("Seleccione el tipo de guía (datos antes del guión)")
                    .HasMaxLength(255);

                entity.Property(e => e.Timestamp).HasMaxLength(255);
            });

            modelBuilder.Entity<Calendarioretail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("calendarioretail");

                entity.Property(e => e.FechaCalendario).HasColumnType("datetime");
            });

            modelBuilder.Entity<CrgArticulo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Crg_Articulo");

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

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CrgArticuloConsignado>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Crg_ArticuloConsignado");

                entity.Property(e => e.Proveedor)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(18);
            });

            modelBuilder.Entity<CrgArticuloDef>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Crg_ArticuloDef");

                entity.Property(e => e.Modelo).HasMaxLength(50);

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(20);
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
            });

            modelBuilder.Entity<CrgDetListaPrecios>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CrgDet_ListaPrecios");

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

                entity.ToTable("CrgDet_ListaPreciosDev");

                entity.Property(e => e.CodLista).HasColumnName("Cod_Lista");

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<CrgGrupoArticulo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Crg_GrupoArticulo");

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

            modelBuilder.Entity<CrgOferta>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Crg_Oferta");

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

            modelBuilder.Entity<DatosPersonales>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ApellidoCasada)
                    .HasColumnName("Apellido_Casada")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Apellidos)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CedulaNumero)
                    .HasColumnName("Cedula_Numero")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CedulaOrden)
                    .HasColumnName("Cedula_Orden")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Codearea)
                    .HasColumnName("codearea")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Colonia)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Departamento)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Deptoemitida)
                    .HasColumnName("DEPTOEMITIDA")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DirCorres)
                    .HasColumnName("Dir_Corres")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.EMail)
                    .HasColumnName("E_Mail")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Esdircorrespondencia)
                    .HasColumnName("esdircorrespondencia")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoCivil)
                    .HasColumnName("Estado_Civil")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Extension)
                    .HasColumnName("EXTENSION")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Extranjero)
                    .HasColumnName("extranjero")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FechaNac).HasColumnType("datetime");

                entity.Property(e => e.FechaSys).HasColumnType("datetime");

                entity.Property(e => e.Fechaalta)
                    .HasColumnName("fechaalta")
                    .HasColumnType("datetime");

                entity.Property(e => e.Muniemitida)
                    .HasColumnName("MUNIEMITIDA")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Nit)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.NombreTarjeta)
                    .HasColumnName("Nombre_Tarjeta")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombres)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Paisresidencia)
                    .HasColumnName("paisresidencia")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Postal)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Residencia)
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");

                entity.Property(e => e.Sexo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Solicitud).HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tarjeta)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TelCasa)
                    .HasColumnName("Tel_Casa")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono2)
                    .HasColumnName("telefono_2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono3)
                    .HasColumnName("TELEFONO_3")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .HasColumnName("usuario")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Zona)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<DetEnvio>(entity =>
            {
                entity.HasKey(e => new { e.Tienda, e.NoEnvio, e.NoLinea, e.CodEvento, e.Correlativo, e.Mes, e.Anio, e.TiendaEnvio })
                    .HasName("PK_det_envio")
                    .IsClustered(false);

                entity.ToTable("DET_ENVIO");

                entity.HasIndex(e => new { e.Tienda, e.TiendaEnvio, e.Correlativo, e.Anio, e.NoEnvio, e.Mes, e.CodEvento })
                    .HasName("Idx_DET_ENVIO_CL1");

                entity.Property(e => e.Tienda)
                    .HasColumnName("tienda")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NoEnvio)
                    .HasColumnName("no_envio")
                    .HasColumnType("decimal(12, 0)");

                entity.Property(e => e.NoLinea).HasColumnName("no_linea");

                entity.Property(e => e.CodEvento)
                    .HasColumnName("cod_evento")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Correlativo)
                    .HasColumnName("correlativo")
                    .HasColumnType("decimal(9, 0)");

                entity.Property(e => e.Mes)
                    .HasColumnName("mes")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.Anio)
                    .HasColumnName("anio")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.TiendaEnvio)
                    .HasColumnName("tienda_envio")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.NoTracking).HasColumnName("no_tracking");

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("sku")
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Unimed)
                    .IsRequired()
                    .HasColumnName("unimed")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<EliminarActualizarRegistros>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Comentarios)
                    .HasColumnName("comentarios")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.NumeroGuia).HasColumnName("numero_guia");

                entity.Property(e => e.PersonaEntrega)
                    .HasColumnName("persona_entrega")
                    .HasMaxLength(255);

                entity.Property(e => e.PersonaRecibe)
                    .HasColumnName("persona_recibe")
                    .HasMaxLength(255);

                entity.Property(e => e.ResultadoEntrega).HasColumnName("resultado_entrega");

                entity.Property(e => e.TerminacionGuia)
                    .HasColumnName("terminacion_guia")
                    .HasMaxLength(255);

                entity.Property(e => e.TipoGuia)
                    .HasColumnName("tipo_guia")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Envio>(entity =>
            {
                entity.HasKey(e => new { e.Tienda, e.NoEnvio, e.CodEvento, e.Correlativo, e.Mes, e.Anio, e.TiendaEnvio })
                    .HasName("PK_envio")
                    .IsClustered(false);

                entity.ToTable("ENVIO");

                entity.HasIndex(e => new { e.Anio, e.Correlativo, e.Mes, e.NoEnvio, e.Tienda, e.TiendaEnvio, e.CodEvento })
                    .HasName("Idx_ENVIO_01");

                entity.Property(e => e.Tienda)
                    .HasColumnName("tienda")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NoEnvio)
                    .HasColumnName("no_envio")
                    .HasColumnType("decimal(12, 0)");

                entity.Property(e => e.CodEvento)
                    .HasColumnName("cod_evento")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Correlativo)
                    .HasColumnName("correlativo")
                    .HasColumnType("decimal(9, 0)");

                entity.Property(e => e.Mes).HasColumnName("mes");

                entity.Property(e => e.Anio).HasColumnName("anio");

                entity.Property(e => e.TiendaEnvio)
                    .HasColumnName("tienda_envio")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEnvio)
                    .HasColumnName("fecha_envio")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRecibido)
                    .HasColumnName("fecha_recibido")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdenRecPor)
                    .IsRequired()
                    .HasColumnName("iden_rec_por")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Piloto)
                    .IsRequired()
                    .HasColumnName("piloto")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RecibidoPor)
                    .HasColumnName("recibido_por")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Evento>(entity =>
            {
                entity.HasKey(e => new { e.TipoEvento, e.CorreEvento, e.Tienda, e.Mes, e.Anio })
                    .HasName("PK_evento")
                    .IsClustered(false);

                entity.ToTable("EVENTO");

                entity.Property(e => e.TipoEvento)
                    .HasColumnName("tipo_evento")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CorreEvento)
                    .HasColumnName("corre_evento")
                    .HasColumnType("decimal(12, 0)");

                entity.Property(e => e.Tienda)
                    .HasColumnName("tienda")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mes).HasColumnName("MES");

                entity.Property(e => e.Anio).HasColumnName("ANIO");

                entity.Property(e => e.AcreditaPuntos)
                    .HasColumnName("acredita_puntos")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AliasNovia)
                    .HasColumnName("aliasNOVIA")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AliasNovio)
                    .HasColumnName("aliasNOVIO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Asesora)
                    .IsRequired()
                    .HasColumnName("ASESORA")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.AsesoraRecorrido)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ClaveInvitados)
                    .HasColumnName("claveINVITADOS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClaveNovios)
                    .HasColumnName("claveNOVIOS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ColoniaEntrega)
                    .HasColumnName("colonia_entrega")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ComparteInfo)
                    .HasColumnName("comparteInfo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DireccionEntrega)
                    .HasColumnName("direccion_entrega")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCierre)
                    .HasColumnName("fecha_cierre")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaDev)
                    .HasColumnName("fecha_dev")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaEvento)
                    .HasColumnName("fecha_evento")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaLista)
                    .HasColumnName("fecha_lista")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaMonia)
                    .HasColumnName("fecha_monia")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRecorrido)
                    .HasColumnName("fecha_recorrido")
                    .HasColumnType("datetime");

                entity.Property(e => e.NombreEvento)
                    .HasColumnName("nombre_evento")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NombreNovia)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreNovio)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .HasColumnName("observaciones")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones1)
                    .HasColumnName("OBSERVACIONES1")
                    .HasMaxLength(254)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Observaciones2)
                    .HasColumnName("OBSERVACIONES2")
                    .HasMaxLength(254)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PersonaRecMonia)
                    .HasColumnName("persona_rec_monia")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StatusMonia)
                    .IsRequired()
                    .HasColumnName("status_monia")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TelefonoEntrega)
                    .HasColumnName("telefono_entrega")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TextoLibre)
                    .HasColumnName("texto_libre")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.ZonaEntrega)
                    .HasColumnName("zona_entrega")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ExpoBodas>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.F1).HasMaxLength(255);

                entity.Property(e => e.F2).HasMaxLength(255);

                entity.Property(e => e.F3).HasMaxLength(255);

                entity.Property(e => e.F4).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<FormRutas>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("'FormRutas'");

                entity.Property(e => e.ComentariosEntrega).HasColumnName("Comentarios entrega");

                entity.Property(e => e.FechaDeVisita)
                    .HasColumnName("Fecha de visita")
                    .HasColumnType("datetime");

                entity.Property(e => e.FotografíasDeEntregaGuíaFirmadaYClienteRecibiendoSuPed)
                    .HasColumnName("Fotografías de entrega (Guía firmada y cliente recibiendo su ped")
                    .HasMaxLength(255);

                entity.Property(e => e.GuíaTerminaEn1)
                    .HasColumnName("Guía termina en '-1'")
                    .HasMaxLength(255);

                entity.Property(e => e.HoraDeVisita)
                    .HasColumnName("Hora de visita")
                    .HasColumnType("datetime");

                entity.Property(e => e.IngreseElNúmeroDeGuíaDespuésDelGuiónAntesDel1).HasColumnName("Ingrese el número de guía (después del guión, antes del '-1')");

                entity.Property(e => e.IngreseElNúmeroDeGuíaDespésDelGuiónAntesDel1)
                    .HasColumnName("Ingrese el número de guía (despés del guión, antes del -1)")
                    .HasMaxLength(255);

                entity.Property(e => e.NoName).HasMaxLength(255);

                entity.Property(e => e.NoName1).HasMaxLength(255);

                entity.Property(e => e.NoName2).HasMaxLength(255);

                entity.Property(e => e.PersonaQueEntrega)
                    .HasColumnName("Persona que entrega")
                    .HasMaxLength(255);

                entity.Property(e => e.PersonaQueRecibe)
                    .HasColumnName("Persona que recibe")
                    .HasMaxLength(255);

                entity.Property(e => e.ResultadoDeLaEntrega)
                    .HasColumnName("Resultado de la entrega")
                    .HasMaxLength(255);

                entity.Property(e => e.SeleccioneElTipoDeGuíaDatosAntesDelGuión)
                    .HasColumnName("Seleccione el tipo de guía (datos antes del guión)")
                    .HasMaxLength(255);

                entity.Property(e => e.Timestamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<HistoDetListaRegalos>(entity =>
            {
                entity.HasKey(e => new { e.IdLista, e.Sku, e.Color });

                entity.ToTable("HistoDet_ListaRegalos");

                entity.Property(e => e.IdLista)
                    .HasColumnName("Id_Lista")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(50);

                entity.Property(e => e.Color).HasMaxLength(100);

                entity.Property(e => e.Ambiente)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Ean)
                    .IsRequired()
                    .HasColumnName("EAN")
                    .HasMaxLength(50);

                entity.Property(e => e.Marca)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.UnidMed)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<IntDetEnvio>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Int_Det_Envio");

                entity.Property(e => e.CodEvento)
                    .IsRequired()
                    .HasColumnName("Cod_Evento")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Correlativo).HasColumnType("numeric(12, 0)");

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("ID_Envio")
                    .HasMaxLength(25);

                entity.Property(e => e.NoEnvio).HasColumnName("No_Envio");

                entity.Property(e => e.NoLinea).HasColumnName("No_Linea");

                entity.Property(e => e.NoTracking).HasColumnName("No_Tracking");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Tienda)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.TiendaEnvio)
                    .IsRequired()
                    .HasColumnName("Tienda_Envio")
                    .HasMaxLength(10);

                entity.Property(e => e.UniMed)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IntEnvio>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Int_Envio");

                entity.Property(e => e.CodEvento)
                    .IsRequired()
                    .HasColumnName("Cod_Evento")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Correlativo).HasColumnType("numeric(12, 0)");

                entity.Property(e => e.FechaEnvio)
                    .HasColumnName("Fecha_Envio")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRecibido)
                    .HasColumnName("Fecha_Recibido")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("ID_Envio")
                    .HasMaxLength(25);

                entity.Property(e => e.IdenRecPor)
                    .HasColumnName("Iden_Rec_Por")
                    .HasMaxLength(10);

                entity.Property(e => e.NoEnvio).HasColumnName("No_Envio");

                entity.Property(e => e.RecibidoPor)
                    .HasColumnName("Recibido_Por")
                    .HasMaxLength(45);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StatusEnvio)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tienda)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.TiendaEnvio)
                    .IsRequired()
                    .HasColumnName("Tienda_Envio")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<IntEvento>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Int_Evento");

                entity.Property(e => e.AcreditaPuntos)
                    .IsRequired()
                    .HasColumnName("Acredita_Puntos")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AliasNovia)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AliasNovio)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Asesora)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ClaveInvitados)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ClaveNovios)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ColoniaEntrega)
                    .IsRequired()
                    .HasColumnName("Colonia_Entrega")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ComparteInfo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CorreEvento)
                    .HasColumnName("Corre_Evento")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.DireccionEntrega)
                    .IsRequired()
                    .HasColumnName("Direccion_Entrega")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCierre).HasColumnName("Fecha_Cierre");

                entity.Property(e => e.FechaDev).HasColumnName("Fecha_Dev");

                entity.Property(e => e.FechaEvento)
                    .HasColumnName("Fecha_Evento")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaLista)
                    .HasColumnName("Fecha_Lista")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaMonia)
                    .HasColumnName("Fecha_Monia")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRecorrido)
                    .HasColumnName("Fecha_Recorrido")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("ID_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.NombreEvento)
                    .IsRequired()
                    .HasColumnName("Nombre_Evento")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NombreNovia).HasMaxLength(151);

                entity.Property(e => e.NombreNovio).HasMaxLength(151);

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones1)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones2)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PersonaRecMonia).HasColumnName("Persona_Rec_Monia");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StatusMonia)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoEntrega)
                    .IsRequired()
                    .HasColumnName("Telefono_Entrega")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TextoLibre)
                    .IsRequired()
                    .HasColumnName("Texto_Libre")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Tienda)
                    .IsRequired()
                    .HasMaxLength(11);

                entity.Property(e => e.TipoEvento)
                    .IsRequired()
                    .HasColumnName("Tipo_Evento")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ZonaEntrega)
                    .IsRequired()
                    .HasColumnName("Zona_Entrega")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IntListaRegalos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Int_Lista_Regalos");

                entity.Property(e => e.Agregado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Ambiente).HasMaxLength(50);

                entity.Property(e => e.Barra).HasMaxLength(50);

                entity.Property(e => e.CantidadComprada).HasColumnName("Cantidad_Comprada");

                entity.Property(e => e.CantidadSolicitada).HasColumnName("Cantidad_Solicitada");

                entity.Property(e => e.ColorDesc).HasMaxLength(100);

                entity.Property(e => e.Correlativo).HasColumnType("numeric(12, 0)");

                entity.Property(e => e.Depto)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("ID_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.Marca).HasMaxLength(100);

                entity.Property(e => e.Modelo).HasMaxLength(100);

                entity.Property(e => e.NoRegalo)
                    .IsRequired()
                    .HasColumnName("No_Regalo")
                    .HasMaxLength(50);

                entity.Property(e => e.RegaloMarcado).HasColumnName("Regalo_Marcado");

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(18);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Tienda)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.TipoEvento)
                    .IsRequired()
                    .HasColumnName("Tipo_Evento")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.UniMed)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Vajilla)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IntNovios>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("int_novios");

                entity.Property(e => e.Apellidonovia)
                    .HasColumnName("apellidonovia")
                    .HasMaxLength(101);

                entity.Property(e => e.Apellidonovio)
                    .HasColumnName("apellidonovio")
                    .HasMaxLength(101);

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("id_evento")
                    .HasMaxLength(25);

                entity.Property(e => e.Nombrenovia)
                    .HasColumnName("nombrenovia")
                    .HasMaxLength(151);

                entity.Property(e => e.Nombrenovio)
                    .HasColumnName("nombrenovio")
                    .HasMaxLength(151);
            });

            modelBuilder.Entity<IntPersonaEvento>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Int_PersonaEvento");

                entity.Property(e => e.Ape1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Ape2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Celular)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Colonia)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Correlativo).HasColumnType("numeric(12, 0)");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Fax)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("ID_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.Identificacion)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Localizador)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NoPersona).HasColumnName("No_Persona");

                entity.Property(e => e.Nom1)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Nom2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TarPrivi)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TeleOficina)
                    .IsRequired()
                    .HasColumnName("Tele_Oficina")
                    .HasMaxLength(50);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Tienda)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.TipoEvento)
                    .IsRequired()
                    .HasColumnName("Tipo_Evento")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Zona)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IntRegaloComprado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Int_Regalo_Comprado");

                entity.Property(e => e.Caja).HasMaxLength(5);

                entity.Property(e => e.Correlativo).HasColumnType("numeric(12, 0)");

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(30);

                entity.Property(e => e.Enviado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCompra)
                    .HasColumnName("Fecha_Compra")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("ID_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.NoRegLta).HasColumnName("no_reg_lta");

                entity.Property(e => e.NoTracking).HasColumnName("No_Tracking");

                entity.Property(e => e.NombreComprador)
                    .HasColumnName("Nombre_Comprador")
                    .HasMaxLength(100);

                entity.Property(e => e.Notx).HasColumnName("NOTX");

                entity.Property(e => e.NumeroRegalo)
                    .IsRequired()
                    .HasColumnName("Numero_Regalo")
                    .HasMaxLength(25);

                entity.Property(e => e.PrecioCompra)
                    .HasColumnName("Precio_Compra")
                    .HasColumnType("money");

                entity.Property(e => e.ProcesoActual)
                    .IsRequired()
                    .HasColumnName("Proceso_Actual")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RegaloComprado).HasColumnName("Regalo_comprado");

                entity.Property(e => e.Responsable)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(18);

                entity.Property(e => e.TelefonoComprador)
                    .HasColumnName("Telefono_Comprador")
                    .HasMaxLength(50);

                entity.Property(e => e.Tienda).HasMaxLength(10);

                entity.Property(e => e.TiendaEvento)
                    .IsRequired()
                    .HasColumnName("Tienda_evento")
                    .HasMaxLength(10);

                entity.Property(e => e.TipoEvento)
                    .IsRequired()
                    .HasColumnName("Tipo_Evento")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.TipoPrecio)
                    .IsRequired()
                    .HasColumnName("Tipo_Precio")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.UniMed)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ListaRegalos>(entity =>
            {
                entity.HasKey(e => new { e.TipoEvento, e.Correlativo, e.NoRegalo, e.Mes, e.Anio, e.Tienda })
                    .HasName("PK_lista_regalos")
                    .IsClustered(false);

                entity.ToTable("LISTA_REGALOS");

                entity.Property(e => e.TipoEvento)
                    .HasColumnName("tipo_evento")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Correlativo)
                    .HasColumnName("correlativo")
                    .HasColumnType("decimal(12, 0)");

                entity.Property(e => e.NoRegalo).HasColumnName("no_regalo");

                entity.Property(e => e.Mes).HasColumnName("mes");

                entity.Property(e => e.Anio).HasColumnName("anio");

                entity.Property(e => e.Tienda)
                    .HasColumnName("tienda")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Agregado)
                    .IsRequired()
                    .HasColumnName("agregado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ambiente)
                    .IsRequired()
                    .HasColumnName("ambiente")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Barra)
                    .IsRequired()
                    .HasColumnName("barra")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.CantidadComprada).HasColumnName("cantidad_comprada");

                entity.Property(e => e.CantidadSolicitada).HasColumnName("cantidad_solicitada");

                entity.Property(e => e.Colordesc)
                    .HasColumnName("colordesc")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Depto)
                    .IsRequired()
                    .HasColumnName("depto")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Marca)
                    .HasColumnName("marca")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Modelo)
                    .HasColumnName("modelo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RegaloMarcado).HasColumnName("regalo_marcado");

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("sku")
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Unimed)
                    .IsRequired()
                    .HasColumnName("unimed")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Vajilla)
                    .IsRequired()
                    .HasColumnName("vajilla")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PersonaEvento>(entity =>
            {
                entity.HasKey(e => new { e.TipoEvento, e.Correlativo, e.NoPersona, e.Mes, e.Anio, e.Tienda })
                    .IsClustered(false);

                entity.ToTable("persona_evento");

                entity.Property(e => e.TipoEvento)
                    .HasColumnName("tipo_evento")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Correlativo)
                    .HasColumnName("correlativo")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.NoPersona).HasColumnName("no_persona");

                entity.Property(e => e.Mes).HasColumnName("mes");

                entity.Property(e => e.Anio).HasColumnName("anio");

                entity.Property(e => e.Tienda)
                    .HasColumnName("tienda")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ape1)
                    .HasColumnName("ape1")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ape2)
                    .HasColumnName("ape2")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Celular)
                    .HasColumnName("celular")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Colonia)
                    .HasColumnName("colonia")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasColumnName("direccion")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Identificacion)
                    .HasColumnName("identificacion")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Localizador)
                    .HasColumnName("localizador")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nom1)
                    .HasColumnName("nom1")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nom2)
                    .HasColumnName("nom2")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Tarprivi)
                    .HasColumnName("tarprivi")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.TeleOficina)
                    .HasColumnName("tele_oficina")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Zona)
                    .HasColumnName("zona")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PosOferta>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("POS_Oferta");

                entity.HasIndex(e => e.Codpro)
                    .HasName("Idx_POS_Oferta_CL1")
                    .IsClustered();

                entity.Property(e => e.Codpro)
                    .IsRequired()
                    .HasColumnName("CODPRO")
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fechafin)
                    .HasColumnName("FECHAFIN")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fechaini)
                    .HasColumnName("FECHAINI")
                    .HasColumnType("datetime");

                entity.Property(e => e.NumeroPromocion)
                    .HasColumnName("NUMERO_PROMOCION")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoOferta)
                    .HasColumnName("tipo_oferta")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Unimed)
                    .IsRequired()
                    .HasColumnName("UNIMED")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Valor)
                    .HasColumnName("VALOR")
                    .HasColumnType("decimal(12, 2)");
            });

            modelBuilder.Entity<PosPrecio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("POS_Precio");

                entity.Property(e => e.Codpro)
                    .IsRequired()
                    .HasColumnName("CODPRO")
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PrecioBase)
                    .HasColumnName("PRECIO_BASE")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Unimed)
                    .IsRequired()
                    .HasColumnName("UNIMED")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<RegaloComprado>(entity =>
            {
                entity.HasKey(e => new { e.TipoEvento, e.Correlativo, e.Mes, e.Anio, e.NumeroRegalo, e.FechaCompra, e.TiendaEvento })
                    .IsClustered(false);

                entity.ToTable("REGALO_COMPRADO");

                entity.HasIndex(e => new { e.Email, e.Cantidad, e.NombreComprador, e.FechaCompra, e.TelefonoComprador, e.Correlativo, e.Mes, e.Anio, e.Sku, e.TiendaEvento })
                    .HasName("Idx_REGALO_COMPRADO_CL1");

                entity.Property(e => e.TipoEvento)
                    .HasColumnName("TIPO_EVENTO")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Correlativo).HasColumnName("CORRELATIVO");

                entity.Property(e => e.Mes).HasColumnName("MES");

                entity.Property(e => e.Anio).HasColumnName("ANIO");

                entity.Property(e => e.NumeroRegalo).HasColumnName("NUMERO_REGALO");

                entity.Property(e => e.FechaCompra)
                    .HasColumnName("FECHA_COMPRA")
                    .HasColumnType("datetime");

                entity.Property(e => e.TiendaEvento)
                    .HasColumnName("tienda_evento")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Caja)
                    .HasColumnName("CAJA")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Enviado)
                    .IsRequired()
                    .HasColumnName("enviado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('S')");

                entity.Property(e => e.NoRegLta)
                    .HasColumnName("no_reg_lta")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.NoTracking).HasColumnName("NO_TRACKING");

                entity.Property(e => e.NombreComprador)
                    .HasColumnName("NOMBRE_COMPRADOR")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.Notx)
                    .HasColumnName("NOTX")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.PrecioCompra)
                    .HasColumnName("PRECIO_COMPRA")
                    .HasColumnType("numeric(12, 2)");

                entity.Property(e => e.ProcesoActual)
                    .HasColumnName("PROCESO_ACTUAL")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RegaloComprado1).HasColumnName("regalo_comprado");

                entity.Property(e => e.Responsable)
                    .HasColumnName("RESPONSABLE")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('999999')");

                entity.Property(e => e.TelefonoComprador)
                    .HasColumnName("TELEFONO_COMPRADOR")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.Tienda)
                    .IsRequired()
                    .HasColumnName("tienda")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoPrecio)
                    .HasColumnName("tipo_precio")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Unimed)
                    .IsRequired()
                    .HasColumnName("UNIMED")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('EA')");
            });

            modelBuilder.Entity<RegalosAgregados>(entity =>
            {
                entity.HasKey(e => new { e.Tienda, e.TipoEvento, e.Mes, e.Anio, e.Correlativo, e.NoRegalo })
                    .IsClustered(false);

                entity.ToTable("REGALOS_AGREGADOS");

                entity.Property(e => e.Tienda)
                    .HasColumnName("TIENDA")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoEvento)
                    .HasColumnName("TIPO_EVENTO")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mes)
                    .HasColumnName("MES")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Anio)
                    .HasColumnName("ANIO")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.Correlativo)
                    .HasColumnName("CORRELATIVO")
                    .HasColumnType("decimal(12, 0)");

                entity.Property(e => e.NoRegalo).HasColumnName("NO_REGALO");

                entity.Property(e => e.FechaAgregado)
                    .HasColumnName("FECHA_AGREGADO")
                    .HasColumnType("datetime");

                entity.Property(e => e.PersonaAgrega).HasColumnName("PERSONA_AGREGA");

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");
            });

            modelBuilder.Entity<ReptempDetenvio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("REPTEMP_DETENVIO");

                entity.Property(e => e.Arts).HasColumnName("ARTS");

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("ID_ENVIO")
                    .HasMaxLength(25);

                entity.Property(e => e.Skus).HasColumnName("SKUS");
            });

            modelBuilder.Entity<ReptempEntregado>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("REPTEMP_ENTREGADO");

                entity.Property(e => e.Fechaentrega)
                    .HasColumnName("FECHAENTREGA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("ID_ENVIO")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<ReptempEnvio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("REPTEMP_ENVIO");

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("ID_ENVIO")
                    .HasMaxLength(25);

                entity.Property(e => e.IdEvento)
                    .HasColumnName("ID_EVENTO")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<ReptempNumrutas>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("REPTEMP_NUMRUTAS");

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("ID_ENVIO")
                    .HasMaxLength(25);

                entity.Property(e => e.Numrutas).HasColumnName("NUMRUTAS");
            });

            modelBuilder.Entity<ReptempRecepcatm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("REPTEMP_RECEPCATM");

                entity.Property(e => e.Fecharecep)
                    .HasColumnName("FECHARECEP")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("ID_ENVIO")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<ReptempRutas>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("REPTEMP_RUTAS");

                entity.Property(e => e.Fecharuta)
                    .HasColumnName("FECHARUTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("ID_ENVIO")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<RevDetRequerimiento>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RevDet_Requerimiento");

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasColumnName("Cod_Ubicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FechaConf).HasColumnType("datetime");

                entity.Property(e => e.FechaGen).HasColumnType("datetime");

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("ID_Envio")
                    .HasMaxLength(25);

                entity.Property(e => e.IdTraslado)
                    .HasColumnName("ID_Traslado")
                    .HasMaxLength(25);

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.Localizacion).HasMaxLength(15);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoLoc).HasMaxLength(10);
            });

            modelBuilder.Entity<RutaFormulario>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Ruta_formulario");

                entity.Property(e => e.Comentario).HasMaxLength(255);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdEnvio)
                    .HasColumnName("Id_Envio")
                    .HasMaxLength(255);

                entity.Property(e => e.IdFormulario).HasColumnName("Id_Formulario");

                entity.Property(e => e.Status).HasMaxLength(255);
            });

            modelBuilder.Entity<TblAplicacion>(entity =>
            {
                entity.HasKey(e => e.CodAplicacion);

                entity.ToTable("Tbl_Aplicacion");

                entity.Property(e => e.CodAplicacion)
                    .HasColumnName("Cod_Aplicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TipoAplicacion)
                    .IsRequired()
                    .HasColumnName("Tipo_Aplicacion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblAreaDistribucion>(entity =>
            {
                entity.HasKey(e => e.CodArea);

                entity.ToTable("Tbl_AreaDistribucion");

                entity.Property(e => e.CodArea)
                    .HasColumnName("Cod_Area")
                    .ValueGeneratedNever();

                entity.Property(e => e.CodCentroDist)
                    .HasColumnName("Cod_CentroDist")
                    .HasMaxLength(10);

                entity.Property(e => e.CodDepartamento).HasColumnName("Cod_Departamento");

                entity.Property(e => e.CodPais)
                    .IsRequired()
                    .HasColumnName("Cod_Pais")
                    .HasMaxLength(5);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Puntos).HasMaxLength(4000);

                entity.Property(e => e.Puntos2).HasColumnType("text");
            });

            modelBuilder.Entity<TblAreaDistribucionCentro>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_AreaDistribucionCentro");

                entity.Property(e => e.CodArea).HasColumnName("Cod_Area");

                entity.Property(e => e.CodCentroDist)
                    .IsRequired()
                    .HasColumnName("Cod_CentroDist")
                    .HasMaxLength(10);

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasColumnName("Cod_Ubicacion")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<TblArticulo>(entity =>
            {
                entity.HasKey(e => e.Sku)
                    .IsClustered(false);

                entity.ToTable("Tbl_Articulo");

                entity.HasIndex(e => new { e.Sku, e.Nombre })
                    .HasName("Idx_Tbl_Articulo")
                    .IsClustered();

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
                entity.HasNoKey();

                entity.ToTable("Tbl_ArticuloAct");

                entity.HasIndex(e => new { e.Sku, e.FechaAct })
                    .HasName("Idx_Tbl_ArticuloAct_CL1");

                entity.Property(e => e.FechaAct).HasColumnType("datetime");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblArticuloConsignado>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_ArticuloConsignado");

                entity.Property(e => e.Proveedor)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(18);
            });

            modelBuilder.Entity<TblArticuloDef>(entity =>
            {
                entity.HasKey(e => e.Sku);

                entity.ToTable("Tbl_ArticuloDef");

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(20);

                entity.Property(e => e.Modelo).HasMaxLength(50);
            });

            modelBuilder.Entity<TblArticuloGrupo>(entity =>
            {
                entity.HasKey(e => new { e.Sku, e.CodGrupo });

                entity.ToTable("Tbl_ArticuloGrupo");

                entity.HasIndex(e => new { e.Sku, e.CodGrupo })
                    .HasName("Idx_Tbl_ArticuloGrupo_CL1");

                entity.Property(e => e.Sku)
                    .HasColumnName("sku")
                    .HasMaxLength(20);

                entity.Property(e => e.CodGrupo)
                    .HasColumnName("cod_grupo")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TblArticuloListaReg>(entity =>
            {
                entity.HasKey(e => e.Sku)
                    .HasName("PK_ArticuloListaRegalo");

                entity.ToTable("Tbl_ArticuloListaReg");

                entity.HasIndex(e => e.Skures)
                    .HasName("Idx_ArticuloReg2");

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Barras)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.CodGrupo)
                    .IsRequired()
                    .HasColumnName("Cod_Grupo")
                    .HasMaxLength(15);

                entity.Property(e => e.Marca)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NomGrupo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Oferta).HasColumnType("money");

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.Skures)
                    .IsRequired()
                    .HasColumnName("SKURes")
                    .HasMaxLength(25);

                entity.Property(e => e.UnidMed)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<TblAsociadoEventos>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_AsociadoEventos");

                entity.Property(e => e.CodAsociado)
                    .IsRequired()
                    .HasColumnName("Cod_Asociado")
                    .HasMaxLength(10);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblBarras>(entity =>
            {
                entity.HasKey(e => e.Barras)
                    .IsClustered(false);

                entity.ToTable("Tbl_Barras");

                entity.HasIndex(e => e.Barras)
                    .HasName("Idx_Barras")
                    .IsClustered();

                entity.HasIndex(e => new { e.Sku, e.Barras })
                    .HasName("Idx_Tbl_Barras");

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

            modelBuilder.Entity<TblBeneficioBodas>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_BeneficioBodas");

                entity.Property(e => e.Al).HasColumnType("date");

                entity.Property(e => e.CodAsociado)
                    .IsRequired()
                    .HasColumnName("Cod_Asociado")
                    .HasMaxLength(10);

                entity.Property(e => e.CodBeneficio)
                    .IsRequired()
                    .HasColumnName("Cod_Beneficio")
                    .HasMaxLength(10);

                entity.Property(e => e.Del).HasColumnType("date");

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblCambioSoft>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_CambioSoft");

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

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblCanjeCupon>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_CanjeCupon");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("ID_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.IdPersonal)
                    .IsRequired()
                    .HasColumnName("ID_Personal")
                    .HasMaxLength(25);

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(25);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblCierreOs>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_CierreOS");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("ID_Envio")
                    .HasMaxLength(25);

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<TblCliente>(entity =>
            {
                entity.HasKey(e => e.CodCliente);

                entity.ToTable("Tbl_Cliente");

                entity.Property(e => e.CodCliente)
                    .HasColumnName("Cod_Cliente")
                    .HasMaxLength(10);

                entity.Property(e => e.CodDepartamento).HasColumnName("Cod_Departamento");

                entity.Property(e => e.CodMunicipio).HasColumnName("Cod_Municipio");

                entity.Property(e => e.CodPais)
                    .IsRequired()
                    .HasColumnName("Cod_Pais")
                    .HasMaxLength(5);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Telefonos)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Zona)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblColor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Color");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblConex>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Conex");

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("Id_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.NumConex).HasColumnName("Num_Conex");
            });

            modelBuilder.Entity<TblConexPunto>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_ConexPunto");

                entity.Property(e => e.NumConex).HasColumnName("Num_Conex");
            });

            modelBuilder.Entity<TblContactoCliente>(entity =>
            {
                entity.HasKey(e => new { e.CodCliente, e.Idx });

                entity.ToTable("Tbl_ContactoCliente");

                entity.Property(e => e.CodCliente)
                    .HasColumnName("Cod_Cliente")
                    .HasMaxLength(25);

                entity.Property(e => e.Apellido1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Apellido2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Celular)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CodTipoCont).HasColumnName("Cod_TipoCont");

                entity.Property(e => e.CodTipoIdent).HasColumnName("Cod_TipoIdent");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMail")
                    .HasMaxLength(100);

                entity.Property(e => e.Fax)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Nombre1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Nombre2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NumeroId)
                    .IsRequired()
                    .HasColumnName("NumeroID")
                    .HasMaxLength(25);

                entity.Property(e => e.SerieId)
                    .IsRequired()
                    .HasColumnName("SerieID")
                    .HasMaxLength(10);

                entity.Property(e => e.TelOficina)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblContactoPedido>(entity =>
            {
                entity.HasKey(e => new { e.IdPedido, e.Idx });

                entity.ToTable("Tbl_ContactoPedido");

                entity.Property(e => e.IdPedido)
                    .HasColumnName("Id_Pedido")
                    .HasMaxLength(25);

                entity.Property(e => e.Apellido1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Apellido2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Celular)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CodTipoCont).HasColumnName("Cod_TipoCont");

                entity.Property(e => e.CodTipoIdent).HasColumnName("Cod_TipoIdent");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMail")
                    .HasMaxLength(100);

                entity.Property(e => e.Fax)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Nombre1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Nombre2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NumeroId)
                    .IsRequired()
                    .HasColumnName("NumeroID")
                    .HasMaxLength(25);

                entity.Property(e => e.SerieId)
                    .IsRequired()
                    .HasColumnName("SerieID")
                    .HasMaxLength(10);

                entity.Property(e => e.TelOficina)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblConversionEventos>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_ConversionEventos");

                entity.HasIndex(e => e.IdEvento)
                    .HasName("Idx_Tbl_ConversionEventos_CL1");

                entity.Property(e => e.Anio).HasColumnName("ANIO");

                entity.Property(e => e.CorreEvento)
                    .HasColumnName("corre_evento")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdEvento)
                    .HasColumnName("ID_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.Mes).HasColumnName("MES");

                entity.Property(e => e.Tienda)
                    .IsRequired()
                    .HasColumnName("tienda")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoEvento)
                    .IsRequired()
                    .HasColumnName("tipo_evento")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblDepartamento>(entity =>
            {
                entity.HasKey(e => new { e.CodPais, e.CodDepartamento });

                entity.ToTable("Tbl_Departamento");

                entity.Property(e => e.CodPais)
                    .HasColumnName("Cod_Pais")
                    .HasMaxLength(5);

                entity.Property(e => e.CodDepartamento).HasColumnName("Cod_Departamento");

                entity.Property(e => e.NomCorto)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblDetAreaDistribucion>(entity =>
            {
                entity.HasKey(e => new { e.CodArea, e.Idx });

                entity.ToTable("TblDet_AreaDistribucion");

                entity.Property(e => e.CodArea).HasColumnName("Cod_Area");

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasColumnName("Cod_Ubicacion")
                    .HasMaxLength(40);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblDetEnvio>(entity =>
            {
                entity.HasKey(e => new { e.IdEnvio, e.Sku, e.Color, e.Precio });

                entity.ToTable("TblDet_Envio");

                entity.HasIndex(e => e.Sku)
                    .HasName("Idx_2556_2555_TblDet_Envio");

                entity.HasIndex(e => new { e.IdEnvio, e.Status })
                    .HasName("Idx_TblDet_Envio_CL2");

                entity.HasIndex(e => new { e.IdEnvio, e.Cantidad, e.Precio, e.Status })
                    .HasName("Idx_TblDet_Envio_CL3");

                entity.HasIndex(e => new { e.Status, e.Sku, e.TiendasB, e.Cantidad, e.Color, e.Ambiente, e.CodTamano, e.Descripcion, e.EmpaqTienda, e.CodTipoEmpaque, e.IdEnvio, e.Precio })
                    .HasName("Idx_TblDet_Envio_XM");

                entity.Property(e => e.IdEnvio)
                    .HasColumnName("ID_Envio")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Color).HasMaxLength(100);

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.Ambiente)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CodTamano).HasColumnName("Cod_Tamano");

                entity.Property(e => e.CodTipoEmpaque).HasColumnName("Cod_TipoEmpaque");

                entity.Property(e => e.Danado).HasMaxLength(1);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(350);

                entity.Property(e => e.EmpOriginal).HasMaxLength(1);

                entity.Property(e => e.EmpaqTienda)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Exhibido).HasMaxLength(1);

                entity.Property(e => e.Origen).HasMaxLength(10);

                entity.Property(e => e.ReqArmado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TiendasB).HasMaxLength(100);
            });

            modelBuilder.Entity<TblDetEnvioRetorno>(entity =>
            {
                entity.HasKey(e => new { e.IdEnvio, e.Sku });

                entity.ToTable("TblDet_EnvioRetorno");

                entity.Property(e => e.IdEnvio)
                    .HasColumnName("ID_Envio")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(350);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblDetLiberado>(entity =>
            {
                entity.HasKey(e => new { e.IdEnvio, e.Sku, e.Color });

                entity.ToTable("TblDet_Liberado");

                entity.Property(e => e.IdEnvio)
                    .HasColumnName("ID_Envio")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Color).HasMaxLength(100);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FechaGondola).HasColumnType("datetime");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblDetListaPrecios>(entity =>
            {
                entity.HasKey(e => new { e.Sku, e.CodLista });

                entity.ToTable("TblDet_ListaPrecios");

                entity.HasIndex(e => new { e.CodLista, e.Sku })
                    .HasName("idx_Precios");

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(20);

                entity.Property(e => e.CodLista).HasColumnName("Cod_Lista");

                entity.Property(e => e.Precio).HasColumnType("money");
            });

            modelBuilder.Entity<TblDetListaRegalos>(entity =>
            {
                entity.HasKey(e => new { e.IdLista, e.Sku, e.Color });

                entity.ToTable("TblDet_ListaRegalos");

                entity.HasIndex(e => new { e.Marca, e.Sku })
                    .HasName("Idx_TblDet_ListaRegalos");

                entity.Property(e => e.IdLista)
                    .HasColumnName("Id_Lista")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(50);

                entity.Property(e => e.Color).HasMaxLength(100);

                entity.Property(e => e.Ambiente)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Ean)
                    .IsRequired()
                    .HasColumnName("EAN")
                    .HasMaxLength(50);

                entity.Property(e => e.Marca)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.UnidMed)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblDetListaRegalosVencido>(entity =>
            {
                entity.HasKey(e => new { e.IdLista, e.Sku, e.Color });

                entity.ToTable("TblDet_ListaRegalos_Vencido");

                entity.Property(e => e.IdLista)
                    .HasColumnName("Id_Lista")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(50);

                entity.Property(e => e.Color).HasMaxLength(100);

                entity.Property(e => e.Ambiente)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Ean)
                    .IsRequired()
                    .HasColumnName("EAN")
                    .HasMaxLength(50);

                entity.Property(e => e.Marca)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.UnidMed)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblDetOrdenMant>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_OrdenMant");

                entity.Property(e => e.CodMedida).HasColumnName("Cod_Medida");

                entity.Property(e => e.CodServRep).HasColumnName("Cod_ServRep");

                entity.Property(e => e.NumOrden)
                    .IsRequired()
                    .HasColumnName("Num_Orden")
                    .HasMaxLength(15);

                entity.Property(e => e.Precio).HasColumnType("money");
            });

            modelBuilder.Entity<TblDetPedido>(entity =>
            {
                entity.HasKey(e => new { e.IdPedido, e.Sku, e.Color });

                entity.ToTable("TblDet_Pedido");

                entity.Property(e => e.IdPedido)
                    .HasColumnName("ID_Pedido")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Color).HasMaxLength(100);

                entity.Property(e => e.Ambiente)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CodTamano).HasColumnName("Cod_Tamano");

                entity.Property(e => e.CodTipoEmpaque).HasColumnName("Cod_TipoEmpaque");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EmpaqTienda)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblDetReqPendiente>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_ReqPendiente");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("ID_Envio")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblDetRequerimiento>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_Requerimiento");

                entity.HasIndex(e => e.IdTraslado)
                    .HasName("Idx_TblDet_Requerimiento_CL4");

                entity.HasIndex(e => new { e.CantidadConf, e.IdTraslado })
                    .HasName("Idx_Tbldet_CL2");

                entity.HasIndex(e => new { e.CodUbicacion, e.Status, e.IdTraslado, e.CantidadConf })
                    .HasName("Idx_TblDet_Requerimiento_CL5");

                entity.HasIndex(e => new { e.IdEnvio, e.Sku, e.Color, e.CodUbicacion, e.Status })
                    .HasName("Idx_Tbldet_CL1");

                entity.HasIndex(e => new { e.FechaGen, e.Cantidad, e.Sku, e.Color, e.Localizacion, e.IdEnvio, e.CodUbicacion, e.Status })
                    .HasName("Idx_TblDet_Requerimiento_CL3");

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasColumnName("Cod_Ubicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FechaConf).HasColumnType("datetime");

                entity.Property(e => e.FechaGen).HasColumnType("datetime");

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("ID_Envio")
                    .HasMaxLength(25);

                entity.Property(e => e.IdTraslado)
                    .HasColumnName("ID_Traslado")
                    .HasMaxLength(25);

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.Localizacion).HasMaxLength(15);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoLoc).HasMaxLength(10);
            });

            modelBuilder.Entity<TblDetRequerimientoAnul>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_RequerimientoAnul");

                entity.HasIndex(e => e.IdTraslado)
                    .HasName("Idx_TblDet_RequerimientoAnul_CL1");

                entity.HasIndex(e => new { e.CodUbicacion, e.Status, e.IdTraslado, e.CantidadConf })
                    .HasName("Idx_TblDet_RequerimientoAnul_01");

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasColumnName("Cod_Ubicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FechaConf).HasColumnType("datetime");

                entity.Property(e => e.FechaGen).HasColumnType("datetime");

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("ID_Envio")
                    .HasMaxLength(25);

                entity.Property(e => e.IdTraslado)
                    .HasColumnName("ID_Traslado")
                    .HasMaxLength(25);

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.Localizacion).HasMaxLength(15);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoLoc).HasMaxLength(10);
            });

            modelBuilder.Entity<TblDetReserva>(entity =>
            {
                entity.HasKey(e => new { e.IdReserva, e.Sku, e.Color });

                entity.ToTable("TblDet_Reserva");

                entity.Property(e => e.IdReserva)
                    .HasColumnName("ID_Reserva")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Precio).HasColumnType("money");
            });

            modelBuilder.Entity<TblDetRuta>(entity =>
            {
                entity.HasKey(e => new { e.IdRuta, e.IdEnvio });

                entity.ToTable("TblDet_Ruta");

                entity.HasIndex(e => e.IdEnvio)
                    .HasName("Idx_TblDet_Ruta_CL1");

                entity.Property(e => e.IdRuta)
                    .HasColumnName("ID_Ruta")
                    .HasMaxLength(20);

                entity.Property(e => e.IdEnvio)
                    .HasColumnName("ID_Envio")
                    .HasMaxLength(25);

                entity.Property(e => e.FechaConfirmacion).HasColumnType("datetime");

                entity.Property(e => e.FechaEntrega).HasColumnType("datetime");

                entity.Property(e => e.Firma).HasColumnType("text");

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

            modelBuilder.Entity<TblDetRutaRechazo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_RutaRechazo");

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("ID_Envio")
                    .HasMaxLength(25);

                entity.Property(e => e.IdRuta)
                    .IsRequired()
                    .HasColumnName("ID_Ruta")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblDetRutaRetenido>(entity =>
            {
                entity.HasKey(e => new { e.IdRuta, e.IdEnvio });

                entity.ToTable("TblDet_RutaRetenido");

                entity.Property(e => e.IdRuta)
                    .HasColumnName("ID_Ruta")
                    .HasMaxLength(20);

                entity.Property(e => e.IdEnvio)
                    .HasColumnName("ID_Envio")
                    .HasMaxLength(25);

                entity.Property(e => e.FechaConfirmacion).HasColumnType("datetime");

                entity.Property(e => e.FechaEntrega).HasColumnType("datetime");

                entity.Property(e => e.Firma).HasColumnType("text");

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

            modelBuilder.Entity<TblDetTraslado>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_Traslado");

                entity.HasIndex(e => new { e.IdEnvio, e.Sku, e.Color })
                    .HasName("Idx_2");

                entity.HasIndex(e => new { e.IdTraslado, e.Recibido, e.Cantidad })
                    .HasName("Idx_1");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FechaRecep).HasColumnType("datetime");

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("ID_Envio")
                    .HasMaxLength(25);

                entity.Property(e => e.IdTraslado)
                    .IsRequired()
                    .HasColumnName("ID_Traslado")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblDetTrasladoVenta>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_TrasladoVenta");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("ID_Envio")
                    .HasMaxLength(25);

                entity.Property(e => e.IdTraslado)
                    .HasColumnName("ID_Traslado")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblDetValeComb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblDet_ValeComb");

                entity.Property(e => e.CodMedida).HasColumnName("Cod_Medida");

                entity.Property(e => e.CodServRep).HasColumnName("Cod_ServRep");

                entity.Property(e => e.NumVale)
                    .IsRequired()
                    .HasColumnName("Num_Vale")
                    .HasMaxLength(15);

                entity.Property(e => e.Precio).HasColumnType("money");
            });

            modelBuilder.Entity<TblDirSinConfirmar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_DirSinConfirmar");

                entity.Property(e => e.CodTipoDato).HasColumnName("Cod_TipoDato");

                entity.Property(e => e.IdDato)
                    .IsRequired()
                    .HasColumnName("ID_Dato")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblDocSap>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_DocSAP");

                entity.Property(e => e.DocSap)
                    .IsRequired()
                    .HasColumnName("DocSAP")
                    .HasMaxLength(25);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdTraslado)
                    .HasColumnName("ID_Traslado")
                    .HasMaxLength(25);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblDocumentoDig>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_DocumentoDig");

                entity.Property(e => e.CodTipoDoc).HasColumnName("Cod_TipoDoc");

                entity.Property(e => e.FechaDoc).HasColumnType("datetime");

                entity.Property(e => e.FechaGrab).HasColumnType("datetime");

                entity.Property(e => e.IdDocumento)
                    .IsRequired()
                    .HasColumnName("Id_Documento")
                    .HasMaxLength(25);

                entity.Property(e => e.IdOrigen)
                    .IsRequired()
                    .HasColumnName("Id_Origen")
                    .HasMaxLength(25);

                entity.Property(e => e.Origen)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.Referencia)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TipoVal)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Valor)
                    .IsRequired()
                    .HasColumnType("text");
            });

            modelBuilder.Entity<TblEntregaDistal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_EntregaDistal");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("ID_Envio")
                    .HasMaxLength(25);

                entity.Property(e => e.IdRuta)
                    .HasColumnName("ID_Ruta")
                    .HasMaxLength(25);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblEntregaMonia>(entity =>
            {
                entity.HasKey(e => e.IdEvento);

                entity.ToTable("Tbl_EntregaMonia");

                entity.Property(e => e.IdEvento)
                    .HasColumnName("ID_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.CodUbicacion)
                    .HasColumnName("Cod_Ubicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaConfirmacion).HasColumnType("datetime");

                entity.Property(e => e.Firma).HasColumnType("text");

                entity.Property(e => e.IdEnvio)
                    .HasColumnName("ID_Envio")
                    .HasMaxLength(25);

                entity.Property(e => e.IdPersonal)
                    .HasColumnName("ID_Personal")
                    .HasMaxLength(25);

                entity.Property(e => e.NumeroId)
                    .HasColumnName("NumeroID")
                    .HasMaxLength(25);

                entity.Property(e => e.Receptor).HasMaxLength(100);

                entity.Property(e => e.SerieId)
                    .HasColumnName("SerieID")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<TblEnvio>(entity =>
            {
                entity.HasKey(e => e.IdEnvio);

                entity.ToTable("Tbl_Envio");

                entity.HasIndex(e => e.IdEvento)
                    .HasName("Idx_Tbl_Envio_CL2");

                entity.HasIndex(e => new { e.Caja, e.Transaccion })
                    .HasName("Idx_Tbl_Envio_CL1");

                entity.HasIndex(e => new { e.IdEnvio, e.IdEvento, e.Status })
                    .HasName("Idx_Tbl_Envio_Status");

                entity.HasIndex(e => new { e.IdEnvio, e.Status, e.CodArea })
                    .HasName("Idx_Tbl_Envio_CL3");

                entity.HasIndex(e => new { e.IdEnvio, e.Transaccion, e.Fecha, e.Caja, e.Status })
                    .HasName("Idx_Tbl_Envio_CL4");

                entity.HasIndex(e => new { e.Fecha, e.IdEvento, e.IdEnvio, e.CodUbicacion, e.Caja, e.Status })
                    .HasName("Idx_Tbl_Envio_01");

                entity.HasIndex(e => new { e.IdEnvio, e.Transaccion, e.CodUbicacion, e.Fecha, e.Caja, e.Status })
                    .HasName("Idx_TblDet_Envio_XM");

                entity.Property(e => e.IdEnvio)
                    .HasColumnName("ID_Envio")
                    .HasMaxLength(25);

                entity.Property(e => e.Caja)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.CodArea).HasColumnName("Cod_Area");

                entity.Property(e => e.CodTipoPago).HasColumnName("Cod_TipoPago");

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasColumnName("Cod_Ubicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.Comprador)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdEvento)
                    .HasColumnName("ID_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.IdPersonal)
                    .IsRequired()
                    .HasColumnName("Id_Personal")
                    .HasMaxLength(25);

                entity.Property(e => e.MailEntrega).HasMaxLength(50);

                entity.Property(e => e.Observaciones).HasMaxLength(1000);

                entity.Property(e => e.Paquetes).HasDefaultValueSql("(1)");

                entity.Property(e => e.PorInternet)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sobre).HasMaxLength(25);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TelEntrega).HasMaxLength(50);

                entity.Property(e => e.Transaccion)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblEnvioDir>(entity =>
            {
                entity.HasKey(e => e.IdEnvio);

                entity.ToTable("Tbl_EnvioDir");

                entity.Property(e => e.IdEnvio)
                    .HasColumnName("Id_Envio")
                    .HasMaxLength(25);

                entity.Property(e => e.CodDepartamento).HasColumnName("Cod_Departamento");

                entity.Property(e => e.CodMunicipio).HasColumnName("Cod_Municipio");

                entity.Property(e => e.CodPais)
                    .IsRequired()
                    .HasColumnName("Cod_Pais")
                    .HasMaxLength(5);

                entity.Property(e => e.CodUbicacion)
                    .HasColumnName("Cod_Ubicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.Direccion).HasMaxLength(300);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Zona)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblEnvioEmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_EnvioEmp");

                entity.Property(e => e.FechaEmp).HasColumnType("datetime");

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("ID_Envio")
                    .HasMaxLength(25);

                entity.Property(e => e.IdPersonal)
                    .IsRequired()
                    .HasColumnName("ID_Personal")
                    .HasMaxLength(25);

                entity.Property(e => e.IdRegistro)
                    .IsRequired()
                    .HasColumnName("ID_Registro")
                    .HasMaxLength(25);

                entity.Property(e => e.Ubicacion).HasMaxLength(25);
            });

            modelBuilder.Entity<TblEnvioErrAsociacion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_EnvioErrAsociacion");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("ID_Envio")
                    .HasMaxLength(25);

                entity.Property(e => e.Mensaje)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<TblEnvioMail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_EnvioMail");

                entity.Property(e => e.FechaMail).HasColumnType("datetime");

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("ID_Envio")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblEnvioNc>(entity =>
            {
                entity.HasKey(e => e.IdEnvio);

                entity.ToTable("Tbl_EnvioNC");

                entity.HasIndex(e => new { e.Nota, e.IdEnvio })
                    .HasName("Idx_Tbl_EnvioNC_01");

                entity.Property(e => e.IdEnvio)
                    .HasColumnName("Id_Envio")
                    .HasMaxLength(25);

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasColumnName("Cod_Ubicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaGrab).HasColumnType("datetime");

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.Nit)
                    .IsRequired()
                    .HasColumnName("NIT")
                    .HasMaxLength(15);

                entity.Property(e => e.Nombre).HasMaxLength(250);

                entity.Property(e => e.Nota)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblEnvioNcmail>(entity =>
            {
                entity.HasKey(e => e.IdEnvio);

                entity.ToTable("Tbl_EnvioNCMail");

                entity.Property(e => e.IdEnvio)
                    .HasColumnName("Id_Envio")
                    .HasMaxLength(25);

                entity.Property(e => e.FechaEnvio).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblEnvioOpEntrega>(entity =>
            {
                entity.HasKey(e => e.IdEnvio)
                    .HasName("PK_EnvioOpEntrega");

                entity.ToTable("Tbl_EnvioOpEntrega");

                entity.Property(e => e.IdEnvio)
                    .HasColumnName("ID_Envio")
                    .HasMaxLength(25);

                entity.Property(e => e.CamionGar)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoGar)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.DirVecino).HasMaxLength(250);

                entity.Property(e => e.Edificio)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ElevadorCarga)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Empresa).HasMaxLength(100);

                entity.Property(e => e.EntregaGar)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EntregaRec)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EsEmpresa)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EspGradas)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaEnt).HasColumnType("datetime");

                entity.Property(e => e.Garita)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HorarioEnt)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IngresaCamion)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nivel)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.NomVecino).HasMaxLength(100);

                entity.Property(e => e.PapFactura)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PapOc)
                    .HasColumnName("PapOC")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recibe).HasMaxLength(100);

                entity.Property(e => e.RecibeVecino)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RestEntrega).HasMaxLength(250);

                entity.Property(e => e.TelRecibe).HasMaxLength(100);
            });

            modelBuilder.Entity<TblEnvioOs>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_EnvioOS");

                entity.HasIndex(e => new { e.Direccion, e.Fax, e.VencimientoGar, e.IdEnvio })
                    .HasName("Idx_Tbl_EnvioOS_CL1");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Fax)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("ID_Envio")
                    .HasMaxLength(25);

                entity.Property(e => e.VencimientoGar).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblEnvioTrasladoLec>(entity =>
            {
                entity.HasKey(e => e.IdEnvio)
                    .HasName("PK_EnvioTrasladoLEC");

                entity.ToTable("Tbl_EnvioTrasladoLEC");

                entity.Property(e => e.IdEnvio)
                    .HasColumnName("ID_Envio")
                    .HasMaxLength(25);

                entity.Property(e => e.Fecha).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblEtiquetaEnvio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_EtiquetaEnvio");

                entity.Property(e => e.CodTienda)
                    .IsRequired()
                    .HasColumnName("Cod_Tienda")
                    .HasMaxLength(10);

                entity.Property(e => e.Etiqueta)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.FechaGen).HasColumnType("datetime");

                entity.Property(e => e.IdEnvio)
                    .HasColumnName("ID_Envio")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblEvento>(entity =>
            {
                entity.HasKey(e => e.IdEvento);

                entity.ToTable("Tbl_Evento");

                entity.HasIndex(e => e.CodTipo)
                    .HasName("Idx_EventoTipo");

                entity.HasIndex(e => e.FechaEvento)
                    .HasName("Idx_EventoFechaEv");

                entity.HasIndex(e => e.Status)
                    .HasName("Idx_EventoSt");

                entity.HasIndex(e => new { e.CodTipo, e.CodUbicacion })
                    .HasName("<Cod_Tipo,Cod_Ubicacion>");

                entity.HasIndex(e => new { e.IdEvento, e.CodTipo })
                    .HasName("CodTipo_IdEvento");

                entity.Property(e => e.IdEvento)
                    .HasColumnName("Id_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.AcreditaPuntos)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodArea).HasColumnName("Cod_Area");

                entity.Property(e => e.CodAreaMo).HasColumnName("Cod_AreaMo");

                entity.Property(e => e.CodDepartamento).HasColumnName("Cod_Departamento");

                entity.Property(e => e.CodDepartamentoMo).HasColumnName("Cod_DepartamentoMo");

                entity.Property(e => e.CodMunicipio).HasColumnName("Cod_Municipio");

                entity.Property(e => e.CodMunicipioMo).HasColumnName("Cod_MunicipioMo");

                entity.Property(e => e.CodPais)
                    .HasColumnName("Cod_Pais")
                    .HasMaxLength(5);

                entity.Property(e => e.CodPaisMo)
                    .HasColumnName("Cod_PaisMo")
                    .HasMaxLength(5);

                entity.Property(e => e.CodTiendaLiq)
                    .HasColumnName("Cod_TiendaLiq")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTipoLista).HasColumnName("Cod_TipoLista");

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasColumnName("Cod_Ubicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.CodUbicacionEnt)
                    .HasColumnName("Cod_UbicacionEnt")
                    .HasMaxLength(10);

                entity.Property(e => e.CodUbicacionEntMo)
                    .HasColumnName("Cod_UbicacionEntMo")
                    .HasMaxLength(10);

                entity.Property(e => e.CodUbicacionLista)
                    .IsRequired()
                    .HasColumnName("Cod_UbicacionLista")
                    .HasMaxLength(10);

                entity.Property(e => e.ColorMo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'BLANCA')");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.DireccionMo).HasMaxLength(100);

                entity.Property(e => e.DireccionPostBoda)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.Ecologico)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaEvento).HasColumnType("datetime");

                entity.Property(e => e.FechaLiq).HasColumnType("datetime");

                entity.Property(e => e.FechaLista).HasColumnType("datetime");

                entity.Property(e => e.FechaMonia).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.GeoRefXmo).HasColumnName("GeoRefXMo");

                entity.Property(e => e.GeoRefYmo).HasColumnName("GeoRefYMo");

                entity.Property(e => e.IdPersonal)
                    .IsRequired()
                    .HasColumnName("Id_Personal")
                    .HasMaxLength(50);

                entity.Property(e => e.IdPersonalLiq)
                    .HasColumnName("ID_PersonalLiq")
                    .HasMaxLength(40);

                entity.Property(e => e.IdPersonalRec)
                    .HasColumnName("ID_PersonalRec")
                    .HasMaxLength(40);

                entity.Property(e => e.Pwdinternet)
                    .IsRequired()
                    .HasColumnName("PWDInternet")
                    .HasMaxLength(50);

                entity.Property(e => e.Referencias).HasMaxLength(100);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StatusMonia)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TarjetaPrivilegio)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoMo).HasMaxLength(50);

                entity.Property(e => e.TelefonoPostBoda)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TipoLentrega).HasColumnName("Tipo_LEntrega");

                entity.Property(e => e.TipoLentregaMo).HasColumnName("Tipo_LEntregaMo");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Zona).HasMaxLength(50);

                entity.Property(e => e.ZonaMo).HasMaxLength(50);
            });

            modelBuilder.Entity<TblEvento2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Evento2");

                entity.Property(e => e.AcreditaPuntos)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodArea).HasColumnName("Cod_Area");

                entity.Property(e => e.CodAreaMo).HasColumnName("Cod_AreaMo");

                entity.Property(e => e.CodDepartamento).HasColumnName("Cod_Departamento");

                entity.Property(e => e.CodDepartamentoMo).HasColumnName("Cod_DepartamentoMo");

                entity.Property(e => e.CodMunicipio).HasColumnName("Cod_Municipio");

                entity.Property(e => e.CodMunicipioMo).HasColumnName("Cod_MunicipioMo");

                entity.Property(e => e.CodPais)
                    .HasColumnName("Cod_Pais")
                    .HasMaxLength(5);

                entity.Property(e => e.CodPaisMo)
                    .HasColumnName("Cod_PaisMo")
                    .HasMaxLength(5);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTipoLista).HasColumnName("Cod_TipoLista");

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasColumnName("Cod_Ubicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.CodUbicacionEnt)
                    .HasColumnName("Cod_UbicacionEnt")
                    .HasMaxLength(10);

                entity.Property(e => e.CodUbicacionEntMo)
                    .HasColumnName("Cod_UbicacionEntMo")
                    .HasMaxLength(10);

                entity.Property(e => e.CodUbicacionLista)
                    .IsRequired()
                    .HasColumnName("Cod_UbicacionLista")
                    .HasMaxLength(10);

                entity.Property(e => e.ColorMo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.DireccionMo).HasMaxLength(500);

                entity.Property(e => e.DireccionPostBoda)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.FechaEvento).HasColumnType("datetime");

                entity.Property(e => e.FechaLista).HasColumnType("datetime");

                entity.Property(e => e.FechaMonia).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.GeoRefXmo).HasColumnName("GeoRefXMo");

                entity.Property(e => e.GeoRefYmo).HasColumnName("GeoRefYMo");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("Id_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.IdPersonal)
                    .IsRequired()
                    .HasColumnName("Id_Personal")
                    .HasMaxLength(50);

                entity.Property(e => e.Pwdinternet)
                    .IsRequired()
                    .HasColumnName("PWDInternet")
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StatusMonia)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TarjetaPrivilegio)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoMo).HasMaxLength(50);

                entity.Property(e => e.TelefonoPostBoda)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TipoLentrega).HasColumnName("Tipo_LEntrega");

                entity.Property(e => e.TipoLentregaMo).HasColumnName("Tipo_LEntregaMo");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Zona).HasMaxLength(50);

                entity.Property(e => e.ZonaMo).HasMaxLength(50);
            });

            modelBuilder.Entity<TblEventoActualizado>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_EventoActualizado");

                entity.Property(e => e.EmailAnt).HasMaxLength(100);

                entity.Property(e => e.EmailNuevo).HasMaxLength(100);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Host).HasMaxLength(100);

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("ID_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.Origen)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoAct)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsrDb)
                    .HasColumnName("UsrDB")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblEventoAlerta>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_EventoAlerta");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FinAlerta).HasColumnType("datetime");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("ID_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.IdUsuarioFin)
                    .HasColumnName("ID_UsuarioFin")
                    .HasMaxLength(40);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblEventoCancelado>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_EventoCancelado");

                entity.Property(e => e.CanceladoPor)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("ID_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<TblEventoCertRegalo>(entity =>
            {
                entity.HasKey(e => e.IdEvento);

                entity.ToTable("Tbl_EventoCertRegalo");

                entity.HasIndex(e => e.Certificado)
                    .HasName("Idx_Tbl_EventoCertRegalo_01");

                entity.Property(e => e.IdEvento)
                    .HasColumnName("ID_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.Certificado).HasMaxLength(50);

                entity.Property(e => e.CertificadoBenef).HasMaxLength(50);

                entity.Property(e => e.CodBeneficioC)
                    .HasColumnName("Cod_BeneficioC")
                    .HasMaxLength(10);

                entity.Property(e => e.CodBeneficioH)
                    .HasColumnName("Cod_BeneficioH")
                    .HasMaxLength(10);

                entity.Property(e => e.CodUbicacionEnt)
                    .HasColumnName("Cod_UbicacionEnt")
                    .HasMaxLength(10);

                entity.Property(e => e.CodUbicacionLiq)
                    .HasColumnName("Cod_UbicacionLiq")
                    .HasMaxLength(10);

                entity.Property(e => e.CuponC).HasMaxLength(25);

                entity.Property(e => e.CuponH).HasMaxLength(25);

                entity.Property(e => e.FechaCerfBenef).HasColumnType("datetime");

                entity.Property(e => e.FechaEntrega).HasColumnType("datetime");

                entity.Property(e => e.FechaLiq).HasColumnType("datetime");

                entity.Property(e => e.IdCajaLiq)
                    .HasColumnName("ID_CajaLiq")
                    .HasMaxLength(10);

                entity.Property(e => e.IdUsuarioCertBenef)
                    .HasColumnName("ID_UsuarioCertBenef")
                    .HasMaxLength(40);

                entity.Property(e => e.IdUsuarioEnt)
                    .HasColumnName("ID_UsuarioEnt")
                    .HasMaxLength(40);

                entity.Property(e => e.IdUsuarioLiq)
                    .HasColumnName("ID_UsuarioLiq")
                    .HasMaxLength(40);

                entity.Property(e => e.Nitnc)
                    .IsRequired()
                    .HasColumnName("NITNC")
                    .HasMaxLength(15);

                entity.Property(e => e.NombreNc)
                    .IsRequired()
                    .HasColumnName("NombreNC")
                    .HasMaxLength(50);

                entity.Property(e => e.TotalRegalos).HasColumnType("money");
            });

            modelBuilder.Entity<TblEventoExpo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_EventoEXPO");

                entity.Property(e => e.AcreditaPuntos)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodArea).HasColumnName("Cod_Area");

                entity.Property(e => e.CodAreaMo).HasColumnName("Cod_AreaMo");

                entity.Property(e => e.CodDepartamento).HasColumnName("Cod_Departamento");

                entity.Property(e => e.CodDepartamentoMo).HasColumnName("Cod_DepartamentoMo");

                entity.Property(e => e.CodMunicipio).HasColumnName("Cod_Municipio");

                entity.Property(e => e.CodMunicipioMo).HasColumnName("Cod_MunicipioMo");

                entity.Property(e => e.CodPais)
                    .HasColumnName("Cod_Pais")
                    .HasMaxLength(5);

                entity.Property(e => e.CodPaisMo)
                    .HasColumnName("Cod_PaisMo")
                    .HasMaxLength(5);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTipoLista).HasColumnName("Cod_TipoLista");

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasColumnName("Cod_Ubicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.CodUbicacionEnt)
                    .HasColumnName("Cod_UbicacionEnt")
                    .HasMaxLength(10);

                entity.Property(e => e.CodUbicacionEntMo)
                    .HasColumnName("Cod_UbicacionEntMo")
                    .HasMaxLength(10);

                entity.Property(e => e.CodUbicacionLista)
                    .IsRequired()
                    .HasColumnName("Cod_UbicacionLista")
                    .HasMaxLength(10);

                entity.Property(e => e.ColorMo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.DireccionMo).HasMaxLength(100);

                entity.Property(e => e.DireccionPostBoda)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.FechaEvento).HasColumnType("datetime");

                entity.Property(e => e.FechaLista).HasColumnType("datetime");

                entity.Property(e => e.FechaMonia).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.GeoRefXmo).HasColumnName("GeoRefXMo");

                entity.Property(e => e.GeoRefYmo).HasColumnName("GeoRefYMo");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("Id_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.IdPersonal)
                    .IsRequired()
                    .HasColumnName("Id_Personal")
                    .HasMaxLength(50);

                entity.Property(e => e.Pwdinternet)
                    .IsRequired()
                    .HasColumnName("PWDInternet")
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StatusMonia)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TarjetaPrivilegio)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoMo).HasMaxLength(50);

                entity.Property(e => e.TelefonoPostBoda)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TipoLentrega).HasColumnName("Tipo_LEntrega");

                entity.Property(e => e.TipoLentregaMo).HasColumnName("Tipo_LEntregaMo");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Zona).HasMaxLength(50);

                entity.Property(e => e.ZonaMo).HasMaxLength(50);
            });

            modelBuilder.Entity<TblEventoMail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_EventoMail");

                entity.Property(e => e.EMail)
                    .IsRequired()
                    .HasColumnName("eMail")
                    .HasMaxLength(100);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("ID_Evento")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblEventoModif>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_EventoModif");

                entity.Property(e => e.AcreditaPuntos)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodArea).HasColumnName("Cod_Area");

                entity.Property(e => e.CodAreaMo).HasColumnName("Cod_AreaMo");

                entity.Property(e => e.CodDepartamento).HasColumnName("Cod_Departamento");

                entity.Property(e => e.CodDepartamentoMo).HasColumnName("Cod_DepartamentoMo");

                entity.Property(e => e.CodMunicipio).HasColumnName("Cod_Municipio");

                entity.Property(e => e.CodMunicipioMo).HasColumnName("Cod_MunicipioMo");

                entity.Property(e => e.CodPais)
                    .HasColumnName("Cod_Pais")
                    .HasMaxLength(5);

                entity.Property(e => e.CodPaisMo)
                    .HasColumnName("Cod_PaisMo")
                    .HasMaxLength(5);

                entity.Property(e => e.CodTiendaLiq)
                    .HasColumnName("Cod_TiendaLiq")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTipoLista).HasColumnName("Cod_TipoLista");

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasColumnName("Cod_Ubicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.CodUbicacionEnt)
                    .HasColumnName("Cod_UbicacionEnt")
                    .HasMaxLength(10);

                entity.Property(e => e.CodUbicacionEntMo)
                    .HasColumnName("Cod_UbicacionEntMo")
                    .HasMaxLength(10);

                entity.Property(e => e.CodUbicacionLista)
                    .IsRequired()
                    .HasColumnName("Cod_UbicacionLista")
                    .HasMaxLength(10);

                entity.Property(e => e.ColorMo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.DireccionMo).HasMaxLength(100);

                entity.Property(e => e.DireccionPostBoda)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.Ecologico)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaEvento).HasColumnType("datetime");

                entity.Property(e => e.FechaLiq).HasColumnType("datetime");

                entity.Property(e => e.FechaLista).HasColumnType("datetime");

                entity.Property(e => e.FechaModif).HasColumnType("datetime");

                entity.Property(e => e.FechaMonia).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.GeoRefXmo).HasColumnName("GeoRefXMo");

                entity.Property(e => e.GeoRefYmo).HasColumnName("GeoRefYMo");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("Id_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.IdPersonal)
                    .IsRequired()
                    .HasColumnName("Id_Personal")
                    .HasMaxLength(50);

                entity.Property(e => e.IdPersonalLiq)
                    .HasColumnName("ID_PersonalLiq")
                    .HasMaxLength(40);

                entity.Property(e => e.IdPersonalRec)
                    .HasColumnName("ID_PersonalRec")
                    .HasMaxLength(40);

                entity.Property(e => e.Pwdinternet)
                    .IsRequired()
                    .HasColumnName("PWDInternet")
                    .HasMaxLength(50);

                entity.Property(e => e.Referencia).HasMaxLength(100);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StatusMonia)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TarjetaPrivilegio)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoMo).HasMaxLength(50);

                entity.Property(e => e.TelefonoPostBoda)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TipoLentrega).HasColumnName("Tipo_LEntrega");

                entity.Property(e => e.TipoLentregaMo).HasColumnName("Tipo_LEntregaMo");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Zona).HasMaxLength(50);

                entity.Property(e => e.ZonaMo).HasMaxLength(50);
            });

            modelBuilder.Entity<TblEventoPrivi>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_EventoPrivi");

                entity.HasIndex(e => new { e.IdEvento, e.NumDocumento })
                    .HasName("Idx_Tbl_EventoPrivi_CL2")
                    .IsClustered();

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.IdAsociado)
                    .HasColumnName("ID_Asociado")
                    .HasMaxLength(25);

                entity.Property(e => e.IdAutorizador)
                    .HasColumnName("ID_Autorizador")
                    .HasMaxLength(40);

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("Id_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.NumDocumento)
                    .HasColumnName("Num_Documento")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblEventoRef>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_EventoRef");

                entity.Property(e => e.FechaAcum).HasColumnType("datetime");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("ID_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.IdEventoRef)
                    .IsRequired()
                    .HasColumnName("ID_EventoRef")
                    .HasMaxLength(25);

                entity.Property(e => e.NumDocPuntos)
                    .HasColumnName("Num_DocPuntos")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblEventoTdaLiq>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_EventoTdaLiq");

                entity.Property(e => e.CodTiendaD)
                    .IsRequired()
                    .HasColumnName("Cod_TiendaD")
                    .HasMaxLength(25);

                entity.Property(e => e.CodTiendaO)
                    .IsRequired()
                    .HasColumnName("Cod_TiendaO")
                    .HasMaxLength(10);

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("ID_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.Motivo)
                    .IsRequired()
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<TblExistencia>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Existencia");

                entity.HasIndex(e => e.CodUbicacion)
                    .HasName("Idx_ExistenciaTda");

                entity.HasIndex(e => e.Sku)
                    .HasName("Idx_Existencia");

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasColumnName("Cod_Ubicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblGrupoArticulo>(entity =>
            {
                entity.HasKey(e => e.CodGrupo);

                entity.ToTable("Tbl_GrupoArticulo");

                entity.HasIndex(e => new { e.CodGrupo, e.Nombre })
                    .HasName("Idx_GrupoArt");

                entity.Property(e => e.CodGrupo)
                    .HasColumnName("Cod_Grupo")
                    .HasMaxLength(20);

                entity.Property(e => e.CodPadre)
                    .HasColumnName("Cod_Padre")
                    .HasMaxLength(20);

                entity.Property(e => e.Nombre).HasMaxLength(100);
            });

            modelBuilder.Entity<TblGrupoArticuloNOld>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_GrupoArticuloN_Old");

                entity.Property(e => e.CodGrupo)
                    .IsRequired()
                    .HasColumnName("Cod_Grupo")
                    .HasMaxLength(20);

                entity.Property(e => e.CodPadre)
                    .HasColumnName("Cod_Padre")
                    .HasMaxLength(20);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.Nombre).HasMaxLength(100);
            });

            modelBuilder.Entity<TblImgDocumentoDig>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblImg_DocumentoDig");

                entity.Property(e => e.Archivo)
                    .IsRequired()
                    .HasColumnType("image");

                entity.Property(e => e.IdDocumento)
                    .IsRequired()
                    .HasColumnName("Id_Documento")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblListaRegalos>(entity =>
            {
                entity.HasKey(e => e.IdLista)
                    .HasName("PK_Tbl_ListaRegalos1");

                entity.ToTable("Tbl_ListaRegalos");

                entity.HasIndex(e => e.IdEvento)
                    .HasName("Idx_ListaRegEvento");

                entity.Property(e => e.IdLista)
                    .HasColumnName("Id_Lista")
                    .HasMaxLength(25);

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasColumnName("Cod_Ubicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.FechaRecorrido).HasColumnType("datetime");

                entity.Property(e => e.IdEvento)
                    .HasColumnName("Id_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.IdPersonal)
                    .IsRequired()
                    .HasColumnName("Id_Personal")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblLogMailEvento>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblLog_MailEvento");

                entity.HasIndex(e => new { e.IdEvento, e.CodTipo })
                    .HasName("Idx_TblLog_MailEvento_CL2");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.Destinatario).HasMaxLength(100);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdEvento)
                    .HasColumnName("ID_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblLogTrasladoCentral>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblLog_TrasladoCentral");

                entity.Property(e => e.DataLog).HasColumnType("text");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdTraslado)
                    .IsRequired()
                    .HasColumnName("ID_Traslado")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblLoginTemporal>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__Tbl_Logi__63C76BE228BB3603");

                entity.ToTable("Tbl_LoginTemporal");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("Id_Usuario")
                    .HasMaxLength(32);

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(8000);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<TblMarca>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Marca");

                entity.Property(e => e.Marca)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblMarcaVehiculo>(entity =>
            {
                entity.HasKey(e => e.CodMarca);

                entity.ToTable("Tbl_MarcaVehiculo");

                entity.Property(e => e.CodMarca)
                    .HasColumnName("Cod_Marca")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(70);
            });

            modelBuilder.Entity<TblMedida>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Medida");

                entity.Property(e => e.CodMedida).HasColumnName("Cod_Medida");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(70);
            });

            modelBuilder.Entity<TblMunicipio>(entity =>
            {
                entity.HasKey(e => new { e.CodPais, e.CodDepartamento, e.CodMunicipio });

                entity.ToTable("Tbl_Municipio");

                entity.Property(e => e.CodPais)
                    .HasColumnName("Cod_Pais")
                    .HasMaxLength(5);

                entity.Property(e => e.CodDepartamento).HasColumnName("Cod_Departamento");

                entity.Property(e => e.CodMunicipio).HasColumnName("Cod_Municipio");

                entity.Property(e => e.NomCorto)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblObsEvento>(entity =>
            {
                entity.HasKey(e => new { e.IdEvento, e.Ind });

                entity.ToTable("TblObs_Evento");

                entity.Property(e => e.IdEvento)
                    .HasColumnName("ID_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("Id_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.Imprimible)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<TblObsEventoExpo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblObs_EventoEXPO");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("ID_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("Id_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.Imprimible)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<TblObsPedido>(entity =>
            {
                entity.HasKey(e => new { e.IdPedido, e.Ind });

                entity.ToTable("TblObs_Pedido");

                entity.Property(e => e.IdPedido)
                    .HasColumnName("ID_Pedido")
                    .HasMaxLength(25);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("Id_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<TblOferta>(entity =>
            {
                entity.HasKey(e => new { e.Sku, e.CodLista, e.Desde, e.Hasta });

                entity.ToTable("Tbl_Oferta");

                entity.HasIndex(e => e.Sku)
                    .HasName("idx_Oferta");

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

                entity.Property(e => e.Descuento).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NumPromocion)
                    .HasColumnName("Num_Promocion")
                    .HasMaxLength(15);

                entity.Property(e => e.Precio).HasColumnType("money");
            });

            modelBuilder.Entity<TblOrdenMant>(entity =>
            {
                entity.HasKey(e => e.NumOrden);

                entity.ToTable("Tbl_OrdenMant");

                entity.Property(e => e.NumOrden)
                    .HasColumnName("Num_Orden")
                    .HasMaxLength(15);

                entity.Property(e => e.CodProveedor)
                    .IsRequired()
                    .HasColumnName("Cod_Proveedor")
                    .HasMaxLength(15);

                entity.Property(e => e.Fallas)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdPersonal)
                    .IsRequired()
                    .HasColumnName("Id_Personal")
                    .HasMaxLength(25);

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("Id_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.NumVehiculo)
                    .IsRequired()
                    .HasColumnName("Num_Vehiculo")
                    .HasMaxLength(15);

                entity.Property(e => e.OutAl).HasColumnType("datetime");

                entity.Property(e => e.OutDel).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblPais>(entity =>
            {
                entity.HasKey(e => e.CodPais);

                entity.ToTable("Tbl_Pais");

                entity.Property(e => e.CodPais)
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

                entity.Property(e => e.Valor)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblPedido>(entity =>
            {
                entity.HasKey(e => e.IdPedido);

                entity.ToTable("Tbl_Pedido");

                entity.Property(e => e.IdPedido)
                    .HasColumnName("Id_Pedido")
                    .HasMaxLength(25);

                entity.Property(e => e.CodCliente)
                    .HasColumnName("Cod_Cliente")
                    .HasMaxLength(10);

                entity.Property(e => e.CodDepartamento).HasColumnName("Cod_Departamento");

                entity.Property(e => e.CodMunicipio).HasColumnName("Cod_Municipio");

                entity.Property(e => e.CodPais)
                    .IsRequired()
                    .HasColumnName("Cod_Pais")
                    .HasMaxLength(5);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasColumnName("Cod_Ubicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FechaEntrega).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.IdEnvio)
                    .HasColumnName("Id_Envio")
                    .HasMaxLength(25);

                entity.Property(e => e.IdPersonal)
                    .IsRequired()
                    .HasColumnName("Id_Personal")
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TarjetaPrivilegio)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Zona)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblPerfil>(entity =>
            {
                entity.HasKey(e => e.CodPerfil);

                entity.ToTable("Tbl_Perfil");

                entity.Property(e => e.CodPerfil)
                    .HasColumnName("Cod_Perfil")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblPermiso>(entity =>
            {
                entity.HasKey(e => new { e.CodPerfil, e.CodAplicacion });

                entity.ToTable("Tbl_Permiso");

                entity.Property(e => e.CodPerfil).HasColumnName("Cod_Perfil");

                entity.Property(e => e.CodAplicacion)
                    .HasColumnName("Cod_Aplicacion")
                    .HasMaxLength(10);

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

                entity.Property(e => e.Ejecutar)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblPersonaEvento>(entity =>
            {
                entity.HasKey(e => new { e.IdEvento, e.Idx, e.TipoContacto });

                entity.ToTable("Tbl_PersonaEvento");

                entity.HasIndex(e => new { e.IdEvento, e.TipoContacto, e.CodTipoIdent })
                    .HasName("idEvento_TipoContacto_Codtipocont");

                entity.HasIndex(e => new { e.Nombre1, e.Nombre2, e.IdEvento, e.Apellido1, e.Apellido2, e.TipoContacto })
                    .HasName("Idx_Tbl_PersonaEvento_CL1");

                entity.HasIndex(e => new { e.Apellido2, e.Apellido1, e.Nombre1, e.Nombre2, e.IdEvento, e.Idx, e.TipoContacto })
                    .HasName("Idx_Tbl_PersonaEvento_01");

                entity.Property(e => e.IdEvento)
                    .HasColumnName("Id_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.Apellido1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Apellido2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Celular)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CodTipoCont).HasColumnName("Cod_TipoCont");

                entity.Property(e => e.CodTipoIdent).HasColumnName("Cod_TipoIdent");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMail")
                    .HasMaxLength(100);

                entity.Property(e => e.Fax)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FechaNac).HasColumnType("datetime");

                entity.Property(e => e.Nombre1)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Nombre2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NumeroId)
                    .IsRequired()
                    .HasColumnName("NumeroID")
                    .HasMaxLength(100);

                entity.Property(e => e.RecMonia)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RecRegalos)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SerieId)
                    .IsRequired()
                    .HasColumnName("SerieID")
                    .HasMaxLength(10);

                entity.Property(e => e.TelOficina)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblPersonaEventoExpo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_PersonaEventoEXPO");

                entity.Property(e => e.Apellido1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Apellido2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Celular)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CodTipoCont).HasColumnName("Cod_TipoCont");

                entity.Property(e => e.CodTipoIdent).HasColumnName("Cod_TipoIdent");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMail")
                    .HasMaxLength(100);

                entity.Property(e => e.Fax)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("Id_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.Nombre1)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Nombre2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NumeroId)
                    .IsRequired()
                    .HasColumnName("NumeroID")
                    .HasMaxLength(100);

                entity.Property(e => e.RecMonia)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RecRegalos)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SerieId)
                    .IsRequired()
                    .HasColumnName("SerieID")
                    .HasMaxLength(10);

                entity.Property(e => e.TelOficina)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblPersonal>(entity =>
            {
                entity.HasKey(e => e.IdPersonal);

                entity.ToTable("Tbl_Personal");

                entity.Property(e => e.IdPersonal)
                    .HasColumnName("Id_Personal")
                    .HasMaxLength(25);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Fax)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.NomImpresion).HasMaxLength(100);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Puesto)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblPrecioNormal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_PrecioNormal");

                entity.Property(e => e.CodLista).HasColumnName("Cod_Lista");

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TblProveedor>(entity =>
            {
                entity.HasKey(e => e.CodProveedor);

                entity.ToTable("Tbl_Proveedor");

                entity.Property(e => e.CodProveedor)
                    .HasColumnName("Cod_Proveedor")
                    .HasMaxLength(25);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblPuntosArranque>(entity =>
            {
                entity.HasKey(e => e.CodPunto);

                entity.ToTable("Tbl_PuntosArranque");

                entity.Property(e => e.CodPunto)
                    .HasColumnName("Cod_Punto")
                    .ValueGeneratedNever();

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasColumnName("Cod_Ubicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.GruposCompra)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblRefGeografica>(entity =>
            {
                entity.HasKey(e => new { e.CodPais, e.CodDepartamento, e.CodMunicipio, e.CodReferencia });

                entity.ToTable("Tbl_RefGeografica");

                entity.Property(e => e.CodPais)
                    .HasColumnName("Cod_Pais")
                    .HasMaxLength(5);

                entity.Property(e => e.CodDepartamento).HasColumnName("Cod_Departamento");

                entity.Property(e => e.CodMunicipio).HasColumnName("Cod_Municipio");

                entity.Property(e => e.CodReferencia).HasColumnName("Cod_Referencia");

                entity.Property(e => e.Icono)
                    .IsRequired()
                    .HasColumnType("image");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblRepDinamico>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_RepDinamico");

                entity.Property(e => e.CodAplicacion)
                    .HasColumnName("Cod_Aplicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.CodReporte).HasColumnName("Cod_Reporte");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Query)
                    .IsRequired()
                    .HasColumnType("text");
            });

            modelBuilder.Entity<TblReservaRegalo>(entity =>
            {
                entity.HasKey(e => e.IdReserva);

                entity.ToTable("Tbl_ReservaRegalo");

                entity.HasIndex(e => new { e.IdReserva, e.Fecha, e.Transaccion, e.Comprador, e.CodUbicacion, e.Caja, e.IdEvento, e.Status })
                    .HasName("Idx_Tbl_ReservaRegalo_CL1");

                entity.Property(e => e.IdReserva)
                    .HasColumnName("ID_Reserva")
                    .HasMaxLength(25);

                entity.Property(e => e.Caja).HasMaxLength(5);

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasColumnName("Cod_Ubicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.Comprador)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaFin).HasColumnType("datetime");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("ID_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.IdPersonal)
                    .IsRequired()
                    .HasColumnName("Id_Personal")
                    .HasMaxLength(25);

                entity.Property(e => e.IdPersonalFin)
                    .HasColumnName("Id_PersonalFin")
                    .HasMaxLength(25);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Transaccion).HasMaxLength(25);
            });

            modelBuilder.Entity<TblRuta>(entity =>
            {
                entity.HasKey(e => e.IdRuta);

                entity.ToTable("Tbl_Ruta");

                entity.HasIndex(e => new { e.IdRuta, e.IdUsuario, e.Tipo, e.Status, e.NumVehiculo, e.IdPersonal, e.Fecha, e.MedicionFin, e.MedicionIni, e.CodCentroDist })
                    .HasName("Idx_Tbl_Ruta_CL1");

                entity.Property(e => e.IdRuta)
                    .HasColumnName("ID_Ruta")
                    .HasMaxLength(20);

                entity.Property(e => e.CodCentroDist)
                    .HasColumnName("Cod_CentroDist")
                    .HasMaxLength(10);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdPersonal)
                    .IsRequired()
                    .HasColumnName("Id_Personal")
                    .HasMaxLength(25);

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("Id_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.NumVehiculo)
                    .IsRequired()
                    .HasColumnName("Num_Vehiculo")
                    .HasMaxLength(15);

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
            });

            modelBuilder.Entity<TblRutaDisatel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_RutaDisatel");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdRuta)
                    .IsRequired()
                    .HasColumnName("ID_Ruta")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblSeguimiento>(entity =>
            {
                entity.HasKey(e => e.IdSeguimiento);

                entity.ToTable("Tbl_Seguimiento");

                entity.HasIndex(e => e.IdEvento)
                    .HasName("Idx_Tbl_Seguimiento_CL1");

                entity.Property(e => e.IdSeguimiento)
                    .HasColumnName("Id_Seguimiento")
                    .ValueGeneratedNever();

                entity.Property(e => e.DatosAct)
                    .IsRequired()
                    .HasColumnType("image");

                entity.Property(e => e.Destinatarios)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaConf).HasColumnType("datetime");

                entity.Property(e => e.FechaEnvio).HasColumnType("datetime");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("Id_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("Id_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.IdUsuarioConf)
                    .HasColumnName("Id_UsuarioConf")
                    .HasMaxLength(40);

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
            });

            modelBuilder.Entity<TblSeguimientoExpo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_SeguimientoEXPO");

                entity.Property(e => e.DatosAct)
                    .IsRequired()
                    .HasColumnType("image");

                entity.Property(e => e.Destinatarios)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaConf).HasColumnType("datetime");

                entity.Property(e => e.FechaEnvio).HasColumnType("datetime");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("Id_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.IdSeguimiento).HasColumnName("Id_Seguimiento");

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("Id_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.IdUsuarioConf)
                    .HasColumnName("Id_UsuarioConf")
                    .HasMaxLength(40);

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
            });

            modelBuilder.Entity<TblServRep>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_ServRep");

                entity.Property(e => e.Aplicacion)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodMedida).HasColumnName("Cod_Medida");

                entity.Property(e => e.CodServRep).HasColumnName("Cod_ServRep");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(70);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblSkuSuplemento>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_SkuSuplemento");

                entity.Property(e => e.Sku)
                    .HasColumnName("sku")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblSobre>(entity =>
            {
                entity.HasKey(e => new { e.IdEnvio, e.Sobre });

                entity.ToTable("Tbl_Sobre");

                entity.HasIndex(e => e.IdTraslado)
                    .HasName("Idx_ID_Traslado");

                entity.Property(e => e.IdEnvio)
                    .HasColumnName("ID_Envio")
                    .HasMaxLength(25);

                entity.Property(e => e.Sobre).HasMaxLength(25);

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasColumnName("Cod_Ubicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.IdTraslado)
                    .HasColumnName("ID_Traslado")
                    .HasMaxLength(25)
                    .HasDefaultValueSql("(1)");
            });

            modelBuilder.Entity<TblTamanoProducto>(entity =>
            {
                entity.HasKey(e => e.CodTamano);

                entity.ToTable("Tbl_TamanoProducto");

                entity.Property(e => e.CodTamano)
                    .HasColumnName("Cod_Tamano")
                    .ValueGeneratedNever();

                entity.Property(e => e.Ccmax).HasColumnName("CCMax");

                entity.Property(e => e.Ccmin).HasColumnName("CCMin");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblTiendaDespLec>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_TiendaDespLec");

                entity.Property(e => e.CodTienda)
                    .HasColumnName("Cod_Tienda")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<TblTiendaPerfil>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_TiendaPerfil");

                entity.Property(e => e.CodTienda)
                    .IsRequired()
                    .HasColumnName("Cod_Tienda")
                    .HasMaxLength(10);

                entity.Property(e => e.ColorBase)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Iconos)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Perfil)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Reportes)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblTiendaPerfilMala>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_TiendaPerfilMala", "DOMINO\\itdeleon");

                entity.Property(e => e.CodTienda)
                    .IsRequired()
                    .HasColumnName("Cod_Tienda")
                    .HasMaxLength(10);

                entity.Property(e => e.ColorBase)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Iconos)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Perfil)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Reportes)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblTipoAlerta>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_TipoAlerta");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblTipoAnfitrion>(entity =>
            {
                entity.HasKey(e => new { e.CodTipo, e.CodTanfitrion })
                    .HasName("PK_Tbl_TipoContacto");

                entity.ToTable("Tbl_TipoAnfitrion");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTanfitrion).HasColumnName("Cod_TAnfitrion");

                entity.Property(e => e.BaseTit)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Duplicable)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Obligatorio)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ReqDataCont)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblTipoContacto>(entity =>
            {
                entity.HasKey(e => e.CodTipo)
                    .HasName("PK_Tbl_TipoContacto_1");

                entity.ToTable("Tbl_TipoContacto");

                entity.Property(e => e.CodTipo)
                    .HasColumnName("Cod_Tipo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblTipoCupon>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_TipoCupon");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblTipoDocumento>(entity =>
            {
                entity.HasKey(e => e.CodTipo)
                    .HasName("PK_Tipo_Docento");

                entity.ToTable("Tbl_Tipo_Documento");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.Accion)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CorrelActual).HasColumnName("Correl_Actual");

                entity.Property(e => e.IncluyeIva)
                    .IsRequired()
                    .HasColumnName("IncluyeIVA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomCorto)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Serie).HasMaxLength(5);
            });

            modelBuilder.Entity<TblTipoEmpaque>(entity =>
            {
                entity.HasKey(e => e.CodTipo);

                entity.ToTable("Tbl_TipoEmpaque");

                entity.Property(e => e.CodTipo)
                    .HasColumnName("Cod_Tipo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblTipoEvento>(entity =>
            {
                entity.HasKey(e => e.CodTipo);

                entity.ToTable("Tbl_TipoEvento");

                entity.Property(e => e.CodTipo)
                    .HasColumnName("Cod_Tipo")
                    .ValueGeneratedNever();

                entity.Property(e => e.CodTipoEmp)
                    .HasColumnName("Cod_TipoEmp")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.MensajePie).HasColumnType("text");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PriviAnfitrion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RepContrato).HasMaxLength(100);

                entity.Property(e => e.ReqPrivilegio)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblTipoEventoLv>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_TipoEvento_LV");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTipoLista).HasColumnName("Cod_TipoLista");
            });

            modelBuilder.Entity<TblTipoIdentificacion>(entity =>
            {
                entity.HasKey(e => e.CodTipo);

                entity.ToTable("Tbl_TipoIdentificacion");

                entity.Property(e => e.CodTipo)
                    .HasColumnName("Cod_Tipo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Obligatorio)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Series)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<TblTipoLista>(entity =>
            {
                entity.HasKey(e => e.CodTipo);

                entity.ToTable("Tbl_TipoLista");

                entity.Property(e => e.CodTipo)
                    .HasColumnName("Cod_Tipo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Certificado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descriptivo).HasMaxLength(500);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RegaloLibre)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ReqTiendaRec)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblTipoMail>(entity =>
            {
                entity.HasKey(e => e.CodTipo);

                entity.ToTable("Tbl_TipoMail");

                entity.Property(e => e.CodTipo)
                    .HasColumnName("Cod_Tipo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Automatico)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodTipoEvento).HasColumnName("Cod_TipoEvento");

                entity.Property(e => e.Default)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PuertoSmtp)
                    .HasColumnName("Puerto_SMTP")
                    .HasMaxLength(50);

                entity.Property(e => e.PwdRemitente).HasMaxLength(50);

                entity.Property(e => e.Remitente).HasMaxLength(50);

                entity.Property(e => e.RemitenteReal).HasMaxLength(50);

                entity.Property(e => e.ServidorSmtp)
                    .HasColumnName("Servidor_SMTP")
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblTipoPago>(entity =>
            {
                entity.HasKey(e => e.CodTipo);

                entity.ToTable("Tbl_TipoPago");

                entity.Property(e => e.CodTipo)
                    .HasColumnName("Cod_Tipo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ReqPago)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblTipoPedido>(entity =>
            {
                entity.HasKey(e => e.CodTipo);

                entity.ToTable("Tbl_TipoPedido");

                entity.Property(e => e.CodTipo)
                    .HasColumnName("Cod_Tipo")
                    .ValueGeneratedNever();

                entity.Property(e => e.CodTipoPago).HasColumnName("Cod_TipoPago");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblTipoProducto>(entity =>
            {
                entity.HasKey(e => e.CodTipo);

                entity.ToTable("Tbl_TipoProducto");

                entity.Property(e => e.CodTipo)
                    .HasColumnName("Cod_Tipo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblTipoUbicFisica>(entity =>
            {
                entity.HasKey(e => e.CodTipo);

                entity.ToTable("Tbl_TipoUbicFisica");

                entity.Property(e => e.CodTipo)
                    .HasColumnName("Cod_Tipo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblTipoUbicTev>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_TipoUbic_TEV");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTipoEvento).HasColumnName("Cod_TipoEvento");
            });

            modelBuilder.Entity<TblTipoVehiculo>(entity =>
            {
                entity.HasKey(e => e.CodTipo);

                entity.ToTable("Tbl_TipoVehiculo");

                entity.Property(e => e.CodTipo)
                    .HasColumnName("Cod_Tipo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(70);
            });

            modelBuilder.Entity<TblTipoZonaRoja>(entity =>
            {
                entity.HasKey(e => e.CodTipo)
                    .HasName("PK_TipoZonaRoja");

                entity.ToTable("Tbl_TipoZonaRoja");

                entity.Property(e => e.CodTipo)
                    .HasColumnName("Cod_Tipo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblTrasladoCentral>(entity =>
            {
                entity.HasKey(e => e.IdTraslado);

                entity.ToTable("Tbl_TrasladoCentral");

                entity.HasIndex(e => e.Status)
                    .HasName("Idx_Status");

                entity.Property(e => e.IdTraslado)
                    .HasColumnName("ID_Traslado")
                    .HasMaxLength(25);

                entity.Property(e => e.CodCentroDist)
                    .HasColumnName("Cod_CentroDist")
                    .HasMaxLength(10);

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasColumnName("Cod_Ubicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaRecep).HasColumnType("datetime");

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.IdUsuarioRec)
                    .HasColumnName("ID_UsuarioRec")
                    .HasMaxLength(40);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblUbicFisica>(entity =>
            {
                entity.HasKey(e => e.CodUbicacion)
                    .HasName("PK_Tbl_UbicFisica_1");

                entity.ToTable("Tbl_UbicFisica");

                entity.Property(e => e.CodUbicacion)
                    .HasColumnName("Cod_Ubicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.CodDepartamento).HasColumnName("Cod_Departamento");

                entity.Property(e => e.CodMunicipio).HasColumnName("Cod_Municipio");

                entity.Property(e => e.CodPais)
                    .IsRequired()
                    .HasColumnName("Cod_Pais")
                    .HasMaxLength(5);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.Db)
                    .HasColumnName("DB")
                    .HasMaxLength(50);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.MailIntercambio).HasMaxLength(100);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PermRecorrido)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PermiteEnvioBoda)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PermiteEnvioBodaReg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PermiteEnvioCs)
                    .HasColumnName("PermiteEnvioCS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PermiteEnvioDom)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PwdDb)
                    .HasColumnName("PwdDB")
                    .HasMaxLength(250);

                entity.Property(e => e.ServidorDb)
                    .HasColumnName("ServidorDB")
                    .HasMaxLength(50);

                entity.Property(e => e.Telefonos)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UsrDb)
                    .HasColumnName("UsrDB")
                    .HasMaxLength(50);

                entity.Property(e => e.ValDesp)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Zona)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblUbicFisicaLec>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_UbicFisicaLEC");

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasColumnName("Cod_Ubicacion")
                    .HasMaxLength(25);

                entity.Property(e => e.Factivacion)
                    .HasColumnName("FActivacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblUbicFisicaMala>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_UbicFisicaMala", "DOMINO\\itdeleon");

                entity.Property(e => e.CodDepartamento).HasColumnName("Cod_Departamento");

                entity.Property(e => e.CodMunicipio).HasColumnName("Cod_Municipio");

                entity.Property(e => e.CodPais)
                    .IsRequired()
                    .HasColumnName("Cod_Pais")
                    .HasMaxLength(5);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasColumnName("Cod_Ubicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.Db)
                    .HasColumnName("DB")
                    .HasMaxLength(50);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PermRecorrido)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PermiteEnvioBoda)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PermiteEnvioBodaReg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PermiteEnvioCs)
                    .HasColumnName("PermiteEnvioCS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PermiteEnvioDom)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PwdDb)
                    .HasColumnName("PwdDB")
                    .HasMaxLength(250);

                entity.Property(e => e.ServidorDb)
                    .HasColumnName("ServidorDB")
                    .HasMaxLength(50);

                entity.Property(e => e.Telefonos)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UsrDb)
                    .HasColumnName("UsrDB")
                    .HasMaxLength(50);

                entity.Property(e => e.ValDesp)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Zona)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblUsuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.ToTable("Tbl_Usuario");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("Id_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.CodPerfil).HasColumnName("Cod_Perfil");

                entity.Property(e => e.Mail).HasMaxLength(50);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(70);

                entity.Property(e => e.Password).HasMaxLength(250);

                entity.Property(e => e.ReqCambPwd)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UltimaModif).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblUsuarioTmp>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.ToTable("Tbl_UsuarioTmp");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("Id_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.CodPerfil).HasColumnName("Cod_Perfil");

                entity.Property(e => e.Mail).HasMaxLength(50);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(70);

                entity.Property(e => e.Password).HasMaxLength(250);

                entity.Property(e => e.ReqCambPwd)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UltimaModif).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblValeComb>(entity =>
            {
                entity.HasKey(e => e.NumVale);

                entity.ToTable("Tbl_ValeComb");

                entity.Property(e => e.NumVale)
                    .HasColumnName("Num_Vale")
                    .HasMaxLength(15);

                entity.Property(e => e.CodProveedor)
                    .IsRequired()
                    .HasColumnName("Cod_Proveedor")
                    .HasMaxLength(15);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdPersonal)
                    .IsRequired()
                    .HasColumnName("Id_Personal")
                    .HasMaxLength(25);

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("Id_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.NumVehiculo)
                    .IsRequired()
                    .HasColumnName("Num_Vehiculo")
                    .HasMaxLength(15);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Total).HasColumnType("money");
            });

            modelBuilder.Entity<TblVehiculo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Vehiculo");

                entity.Property(e => e.Cc).HasColumnName("CC");

                entity.Property(e => e.Chasis)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.CodCombustible).HasColumnName("Cod_Combustible");

                entity.Property(e => e.CodMarca).HasColumnName("Cod_Marca");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Linea)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Motor)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.NumVehiculo)
                    .IsRequired()
                    .HasColumnName("Num_Vehiculo")
                    .HasMaxLength(15);

                entity.Property(e => e.Placa)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Poliza)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Serie)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tacumulado)
                    .IsRequired()
                    .HasColumnName("TAcumulado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblZona>(entity =>
            {
                entity.HasKey(e => new { e.CodPais, e.CodDepartamento, e.CodMunicipio, e.Zona });

                entity.ToTable("Tbl_Zona");

                entity.Property(e => e.CodPais)
                    .HasColumnName("Cod_Pais")
                    .HasMaxLength(5);

                entity.Property(e => e.CodDepartamento).HasColumnName("Cod_Departamento");

                entity.Property(e => e.CodMunicipio).HasColumnName("Cod_Municipio");

                entity.Property(e => e.Zona).HasMaxLength(50);
            });

            modelBuilder.Entity<TblZonaRoja>(entity =>
            {
                entity.HasKey(e => new { e.CodPais, e.CodDepartamento, e.CodMunicipio, e.CodZona });

                entity.ToTable("Tbl_ZonaRoja");

                entity.Property(e => e.CodPais)
                    .HasColumnName("Cod_Pais")
                    .HasMaxLength(5);

                entity.Property(e => e.CodDepartamento).HasColumnName("Cod_Departamento");

                entity.Property(e => e.CodMunicipio).HasColumnName("Cod_Municipio");

                entity.Property(e => e.CodZona).HasColumnName("Cod_Zona");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Puntos).HasMaxLength(4000);

                entity.Property(e => e.Puntos2).HasMaxLength(4000);
            });

            modelBuilder.Entity<TbldetListaregalosAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbldet_listaregalos_all");

                entity.Property(e => e.Ambiente)
                    .IsRequired()
                    .HasColumnName("ambiente")
                    .HasMaxLength(50);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("sku")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TempDetEnvio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TempDet_Envio");

                entity.HasIndex(e => new { e.NumConex, e.Sku, e.Color })
                    .HasName("Idx_TempDet_Envio_CL1")
                    .IsClustered();

                entity.Property(e => e.Ambiente)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CodTamano).HasColumnName("Cod_Tamano");

                entity.Property(e => e.CodTipoEmpaque).HasColumnName("Cod_TipoEmpaque");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Danado).HasMaxLength(1);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(350);

                entity.Property(e => e.EmpOriginal).HasMaxLength(1);

                entity.Property(e => e.EmpaqTienda)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Etiqueta).HasMaxLength(25);

                entity.Property(e => e.Exhibido).HasMaxLength(1);

                entity.Property(e => e.NumConex).HasColumnName("Num_Conex");

                entity.Property(e => e.Origen).HasMaxLength(10);

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.ReqArmado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TempDetListaRegalos>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TempDet_ListaRegalos");

                entity.HasIndex(e => e.NumConex)
                    .HasName("Idx_TmpDet_ListaRegalos")
                    .IsClustered();

                entity.Property(e => e.Ambiente)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Ean)
                    .IsRequired()
                    .HasColumnName("EAN")
                    .HasMaxLength(50);

                entity.Property(e => e.Marca)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NumConex).HasColumnName("Num_Conex");

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(50);

                entity.Property(e => e.UnidMed)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TempDetOrdenMant>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TempDet_OrdenMant");

                entity.Property(e => e.CodMedida).HasColumnName("Cod_Medida");

                entity.Property(e => e.CodServRep).HasColumnName("Cod_ServRep");

                entity.Property(e => e.NomMedida)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NumConex).HasColumnName("Num_Conex");

                entity.Property(e => e.Precio).HasColumnType("money");
            });

            modelBuilder.Entity<TempDetReserva>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TempDet_Reserva");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NumConex).HasColumnName("Num_Conex");

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TempDetRuta>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TempDet_Ruta");

                entity.HasIndex(e => e.NumConex)
                    .HasName("Idx_TempDet_Ruta_CL2");

                entity.HasIndex(e => new { e.IdEnvio, e.NumConex })
                    .HasName("Idx_TempDet_Ruta");

                entity.Property(e => e.FechaConfirmacion).HasColumnType("datetime");

                entity.Property(e => e.FechaEntrega).HasColumnType("datetime");

                entity.Property(e => e.Firma).HasColumnType("text");

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("ID_Envio")
                    .HasMaxLength(25);

                entity.Property(e => e.NumConex).HasColumnName("Num_Conex");

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

            modelBuilder.Entity<TempEventos>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_Eventos");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("id_evento")
                    .HasMaxLength(25);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempOferta>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_Oferta");

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

            modelBuilder.Entity<TempPersonaEvento>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_PersonaEvento");

                entity.HasIndex(e => new { e.NumConex, e.TipoContacto })
                    .HasName("Idx_Temp_PersonaEvento_CL1");

                entity.Property(e => e.Apellido1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Apellido2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Celular)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CodTipoCont).HasColumnName("Cod_TipoCont");

                entity.Property(e => e.CodTipoIdent).HasColumnName("Cod_TipoIdent");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMail")
                    .HasMaxLength(100);

                entity.Property(e => e.Fax)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FechaNac).HasColumnType("datetime");

                entity.Property(e => e.NomTipoCont)
                    .IsRequired()
                    .HasColumnName("Nom_TipoCont")
                    .HasMaxLength(50);

                entity.Property(e => e.Nombre1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Nombre2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NumConex).HasColumnName("Num_Conex");

                entity.Property(e => e.NumeroId)
                    .IsRequired()
                    .HasColumnName("NumeroID")
                    .HasMaxLength(25);

                entity.Property(e => e.RecMonia)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RecRegalos)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SerieId)
                    .IsRequired()
                    .HasColumnName("SerieID")
                    .HasMaxLength(10);

                entity.Property(e => e.TelOficina)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TempTipoAnfitrion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_TipoAnfitrion");

                entity.Property(e => e.CodTanfitrion).HasColumnName("Cod_TAnfitrion");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NumConex).HasColumnName("Num_Conex");
            });

            modelBuilder.Entity<TmpEcommerceSkuListasNoCreados>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmp_Ecommerce_SkuListasNoCreados");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdEventoLista)
                    .HasColumnName("Id_EventoLista")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("sku")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TmpListadosBodas220417>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmpListadosBodas220417");

                entity.Property(e => e.IdEvento)
                    .HasColumnName("id_evento")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("sku")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TmpMailEnvioBodasErroneo030517>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmpMailEnvioBodasErroneo030517");

                entity.Property(e => e.EMailNovia)
                    .HasColumnName("e_mail_novia")
                    .HasMaxLength(100);

                entity.Property(e => e.EMailNovio)
                    .HasColumnName("e_mail_novio")
                    .HasMaxLength(100);

                entity.Property(e => e.FechaEvento).HasColumnType("datetime");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("Id_Evento")
                    .HasMaxLength(25);
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

            modelBuilder.Entity<Upc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UPC");

                entity.Property(e => e.Codpro)
                    .IsRequired()
                    .HasColumnName("CODPRO")
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Principal)
                    .IsRequired()
                    .HasColumnName("PRINCIPAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Unimed)
                    .IsRequired()
                    .HasColumnName("UNIMED")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Upc1)
                    .IsRequired()
                    .HasColumnName("UPC")
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ViwAcumulacionRegalo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Viw_AcumulacionRegalo");

                entity.Property(e => e.CantXprecio10)
                    .HasColumnName("CantXPrecio10")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.CantidadXprecio)
                    .HasColumnName("CantidadXPrecio")
                    .HasColumnType("money");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("id_evento")
                    .HasMaxLength(25);

                entity.Property(e => e.NoEnvio)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.NombreEvento)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("sku")
                    .HasMaxLength(25);

                entity.Property(e => e.Tienda)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<ViwAnalisisBodas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Viw_AnalisisBodas");

                entity.Property(e => e.CantInvitados).HasColumnName("Cant_Invitados");

                entity.Property(e => e.FechaEvento)
                    .HasColumnName("Fecha_Evento")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("Id_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViwAnalisisLiquidacionesBodasBorrar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Viw_AnalisisLiquidacionesBodas_BORRAR");

                entity.Property(e => e.CantidadEnvios).HasColumnName("cantidad_envios");

                entity.Property(e => e.DiasParaLiquidar)
                    .HasColumnName("Dias_Para_Liquidar")
                    .HasColumnType("numeric(20, 0)");

                entity.Property(e => e.FechaEvento)
                    .HasColumnName("Fecha_Evento")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaLiquidacion)
                    .HasColumnName("Fecha_Liquidacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("id_evento")
                    .HasMaxLength(25);

                entity.Property(e => e.MontoEnvios)
                    .HasColumnName("monto_envios")
                    .HasColumnType("money");

                entity.Property(e => e.MontoTarjetaLiquidacion)
                    .HasColumnName("Monto_Tarjeta_Liquidacion")
                    .HasColumnType("money");

                entity.Property(e => e.NombreEvento)
                    .IsRequired()
                    .HasColumnName("Nombre_Evento")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TarjetaLiquidacion)
                    .IsRequired()
                    .HasColumnName("Tarjeta_Liquidacion")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TiendaEvento)
                    .IsRequired()
                    .HasColumnName("Tienda_Evento")
                    .HasMaxLength(10);

                entity.Property(e => e.TiendaLiquidacion)
                    .HasColumnName("Tienda_Liquidacion")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<ViwAnfitrion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Viw_Anfitrion");

                entity.Property(e => e.Anfitrion).HasMaxLength(4000);

                entity.Property(e => e.CodTipoident).HasColumnName("cod_tipoident");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("id_evento")
                    .HasMaxLength(25);

                entity.Property(e => e.Numeroid)
                    .IsRequired()
                    .HasColumnName("numeroid")
                    .HasMaxLength(25);

                entity.Property(e => e.Serieid)
                    .IsRequired()
                    .HasColumnName("serieid")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<ViwAniversarioBodas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Viw_AniversarioBodas");

                entity.Property(e => e.ApellidoNovia1)
                    .HasColumnName("Apellido_Novia1")
                    .HasMaxLength(50);

                entity.Property(e => e.ApellidoNovia2)
                    .HasColumnName("Apellido_Novia2")
                    .HasMaxLength(50);

                entity.Property(e => e.ApellidoNovio1)
                    .HasColumnName("Apellido_Novio1")
                    .HasMaxLength(50);

                entity.Property(e => e.ApellidoNovio2)
                    .HasColumnName("Apellido_Novio2")
                    .HasMaxLength(50);

                entity.Property(e => e.CelNovia)
                    .HasColumnName("Cel_novia")
                    .HasMaxLength(50);

                entity.Property(e => e.CelNovio)
                    .HasColumnName("Cel_novio")
                    .HasMaxLength(50);

                entity.Property(e => e.Departamento)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DireccionFisica)
                    .IsRequired()
                    .HasColumnName("DIRECCION_FISICA")
                    .HasMaxLength(250);

                entity.Property(e => e.DireccionNovia).HasMaxLength(250);

                entity.Property(e => e.DireccionNovio).HasMaxLength(250);

                entity.Property(e => e.EMailNovia)
                    .HasColumnName("e_mail_novia")
                    .HasMaxLength(100);

                entity.Property(e => e.EMailNovio)
                    .HasColumnName("e_mail_novio")
                    .HasMaxLength(100);

                entity.Property(e => e.Evento)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEvento).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.Municipio)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NombreNovia1)
                    .HasColumnName("Nombre_Novia1")
                    .HasMaxLength(100);

                entity.Property(e => e.NombreNovia2)
                    .HasColumnName("Nombre_Novia2")
                    .HasMaxLength(50);

                entity.Property(e => e.NombreNovio1)
                    .HasColumnName("Nombre_Novio1")
                    .HasMaxLength(100);

                entity.Property(e => e.NombreNovio2)
                    .HasColumnName("Nombre_Novio2")
                    .HasMaxLength(50);

                entity.Property(e => e.OrdenH)
                    .HasColumnName("ordenH")
                    .HasMaxLength(10);

                entity.Property(e => e.OrdenM)
                    .HasColumnName("ordenM")
                    .HasMaxLength(10);

                entity.Property(e => e.RegistroH)
                    .HasColumnName("registroH")
                    .HasMaxLength(100);

                entity.Property(e => e.RegistroM)
                    .HasColumnName("registroM")
                    .HasMaxLength(100);

                entity.Property(e => e.TarjetaPrivilegio)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoNovia)
                    .HasColumnName("telefono_novia")
                    .HasMaxLength(50);

                entity.Property(e => e.TelefonoNovio)
                    .HasColumnName("telefono_novio")
                    .HasMaxLength(50);

                entity.Property(e => e.TelefonoOfiNovia)
                    .HasColumnName("telefono_ofi_novia")
                    .HasMaxLength(50);

                entity.Property(e => e.TelefonoOfiNovio)
                    .HasColumnName("telefono_ofi_novio")
                    .HasMaxLength(50);

                entity.Property(e => e.Tienda)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.TiendaRecorrido)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.TiendaRetener)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.UbicacionPredefinida)
                    .IsRequired()
                    .HasColumnName("UBICACION_PREDEFINIDA")
                    .HasMaxLength(250);

                entity.Property(e => e.Zona)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ViwAniversarioBodasCompras>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Viw_AniversarioBodasCompras");

                entity.Property(e => e.ApellidoNovia1)
                    .HasColumnName("Apellido_Novia1")
                    .HasMaxLength(50);

                entity.Property(e => e.ApellidoNovia2)
                    .HasColumnName("Apellido_Novia2")
                    .HasMaxLength(50);

                entity.Property(e => e.ApellidoNovio1)
                    .HasColumnName("Apellido_Novio1")
                    .HasMaxLength(50);

                entity.Property(e => e.ApellidoNovio2)
                    .HasColumnName("Apellido_Novio2")
                    .HasMaxLength(50);

                entity.Property(e => e.CantidadXPrecio)
                    .HasColumnName("Cantidad_x_Precio")
                    .HasColumnType("money");

                entity.Property(e => e.CelNovia)
                    .HasColumnName("Cel_novia")
                    .HasMaxLength(50);

                entity.Property(e => e.CelNovio)
                    .HasColumnName("Cel_novio")
                    .HasMaxLength(50);

                entity.Property(e => e.Departamento).HasMaxLength(100);

                entity.Property(e => e.DescripcionLista).HasMaxLength(50);

                entity.Property(e => e.Dirección).HasMaxLength(100);

                entity.Property(e => e.EMailNovia)
                    .HasColumnName("e_mail_novia")
                    .HasMaxLength(100);

                entity.Property(e => e.EMailNovio)
                    .HasColumnName("e_mail_novio")
                    .HasMaxLength(100);

                entity.Property(e => e.Evento)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEvento).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("Id_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.Municipio).HasMaxLength(50);

                entity.Property(e => e.NombreNovia1)
                    .HasColumnName("Nombre_Novia1")
                    .HasMaxLength(100);

                entity.Property(e => e.NombreNovia2)
                    .HasColumnName("Nombre_Novia2")
                    .HasMaxLength(50);

                entity.Property(e => e.NombreNovio1)
                    .HasColumnName("Nombre_Novio1")
                    .HasMaxLength(100);

                entity.Property(e => e.NombreNovio2)
                    .HasColumnName("Nombre_Novio2")
                    .HasMaxLength(50);

                entity.Property(e => e.OrdenH)
                    .HasColumnName("ordenH")
                    .HasMaxLength(10);

                entity.Property(e => e.OrdenM)
                    .HasColumnName("ordenM")
                    .HasMaxLength(10);

                entity.Property(e => e.RegistroH)
                    .HasColumnName("registroH")
                    .HasMaxLength(100);

                entity.Property(e => e.RegistroM)
                    .HasColumnName("registroM")
                    .HasMaxLength(100);

                entity.Property(e => e.TarjetaPrivilegio)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoNovia)
                    .HasColumnName("telefono_novia")
                    .HasMaxLength(50);

                entity.Property(e => e.TelefonoNovio)
                    .HasColumnName("telefono_novio")
                    .HasMaxLength(50);

                entity.Property(e => e.TelefonoOfiNovia)
                    .HasColumnName("telefono_ofi_novia")
                    .HasMaxLength(50);

                entity.Property(e => e.TelefonoOfiNovio)
                    .HasColumnName("telefono_ofi_novio")
                    .HasMaxLength(50);

                entity.Property(e => e.Tienda)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.TiendaRecorrido)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.TipoEntrega)
                    .HasColumnName("Tipo_Entrega")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Zona).HasMaxLength(50);
            });

            modelBuilder.Entity<ViwAniversarioBodasComprasDespuesDeLiquidacion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Viw_AniversarioBodasComprasDespuesDeLiquidacion");

                entity.Property(e => e.ApellidoNovia1)
                    .HasColumnName("Apellido_Novia1")
                    .HasMaxLength(50);

                entity.Property(e => e.ApellidoNovia2)
                    .HasColumnName("Apellido_Novia2")
                    .HasMaxLength(50);

                entity.Property(e => e.ApellidoNovio1)
                    .HasColumnName("Apellido_Novio1")
                    .HasMaxLength(50);

                entity.Property(e => e.ApellidoNovio2)
                    .HasColumnName("Apellido_Novio2")
                    .HasMaxLength(50);

                entity.Property(e => e.CantidadXPrecio)
                    .HasColumnName("Cantidad_x_Precio")
                    .HasColumnType("money");

                entity.Property(e => e.CelNovia)
                    .HasColumnName("Cel_novia")
                    .HasMaxLength(50);

                entity.Property(e => e.CelNovio)
                    .HasColumnName("Cel_novio")
                    .HasMaxLength(50);

                entity.Property(e => e.Departamento).HasMaxLength(100);

                entity.Property(e => e.DescripcionLista).HasMaxLength(50);

                entity.Property(e => e.Dirección).HasMaxLength(100);

                entity.Property(e => e.EMailNovia)
                    .HasColumnName("e_mail_novia")
                    .HasMaxLength(100);

                entity.Property(e => e.EMailNovio)
                    .HasColumnName("e_mail_novio")
                    .HasMaxLength(100);

                entity.Property(e => e.Evento)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEvento).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("Id_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.Municipio).HasMaxLength(50);

                entity.Property(e => e.NombreNovia1)
                    .HasColumnName("Nombre_Novia1")
                    .HasMaxLength(100);

                entity.Property(e => e.NombreNovia2)
                    .HasColumnName("Nombre_Novia2")
                    .HasMaxLength(50);

                entity.Property(e => e.NombreNovio1)
                    .HasColumnName("Nombre_Novio1")
                    .HasMaxLength(100);

                entity.Property(e => e.NombreNovio2)
                    .HasColumnName("Nombre_Novio2")
                    .HasMaxLength(50);

                entity.Property(e => e.OrdenH)
                    .HasColumnName("ordenH")
                    .HasMaxLength(10);

                entity.Property(e => e.OrdenM)
                    .HasColumnName("ordenM")
                    .HasMaxLength(10);

                entity.Property(e => e.RegistroH)
                    .HasColumnName("registroH")
                    .HasMaxLength(100);

                entity.Property(e => e.RegistroM)
                    .HasColumnName("registroM")
                    .HasMaxLength(100);

                entity.Property(e => e.TarjetaPrivilegio)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoNovia)
                    .HasColumnName("telefono_novia")
                    .HasMaxLength(50);

                entity.Property(e => e.TelefonoNovio)
                    .HasColumnName("telefono_novio")
                    .HasMaxLength(50);

                entity.Property(e => e.TelefonoOfiNovia)
                    .HasColumnName("telefono_ofi_novia")
                    .HasMaxLength(50);

                entity.Property(e => e.TelefonoOfiNovio)
                    .HasColumnName("telefono_ofi_novio")
                    .HasMaxLength(50);

                entity.Property(e => e.Tienda)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.TiendaRecorrido)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.TipoEntrega)
                    .HasColumnName("Tipo_Entrega")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Zona).HasMaxLength(50);
            });

            modelBuilder.Entity<ViwAniversarioBodasExpo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Viw_AniversarioBodasExpo");

                entity.Property(e => e.ApellidoNovia1)
                    .HasColumnName("Apellido_Novia1")
                    .HasMaxLength(50);

                entity.Property(e => e.ApellidoNovia2)
                    .HasColumnName("Apellido_Novia2")
                    .HasMaxLength(50);

                entity.Property(e => e.ApellidoNovio1)
                    .HasColumnName("Apellido_Novio1")
                    .HasMaxLength(50);

                entity.Property(e => e.ApellidoNovio2)
                    .HasColumnName("Apellido_Novio2")
                    .HasMaxLength(50);

                entity.Property(e => e.CelNovia)
                    .HasColumnName("Cel_novia")
                    .HasMaxLength(50);

                entity.Property(e => e.CelNovio)
                    .HasColumnName("Cel_novio")
                    .HasMaxLength(50);

                entity.Property(e => e.Departamento).HasMaxLength(100);

                entity.Property(e => e.DireccionNovia)
                    .HasColumnName("Direccion_Novia")
                    .HasMaxLength(250);

                entity.Property(e => e.DireccionNovio)
                    .HasColumnName("Direccion_Novio")
                    .HasMaxLength(250);

                entity.Property(e => e.Dirección).HasMaxLength(100);

                entity.Property(e => e.EMailNovia)
                    .HasColumnName("e_mail_novia")
                    .HasMaxLength(100);

                entity.Property(e => e.EMailNovio)
                    .HasColumnName("e_mail_novio")
                    .HasMaxLength(100);

                entity.Property(e => e.Evento)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEvento).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.Municipio).HasMaxLength(50);

                entity.Property(e => e.NombreNovia1)
                    .HasColumnName("Nombre_Novia1")
                    .HasMaxLength(100);

                entity.Property(e => e.NombreNovia2)
                    .HasColumnName("Nombre_Novia2")
                    .HasMaxLength(50);

                entity.Property(e => e.NombreNovio1)
                    .HasColumnName("Nombre_Novio1")
                    .HasMaxLength(100);

                entity.Property(e => e.NombreNovio2)
                    .HasColumnName("Nombre_Novio2")
                    .HasMaxLength(50);

                entity.Property(e => e.OrdenH)
                    .HasColumnName("ordenH")
                    .HasMaxLength(10);

                entity.Property(e => e.OrdenM)
                    .HasColumnName("ordenM")
                    .HasMaxLength(10);

                entity.Property(e => e.RegistroH)
                    .HasColumnName("registroH")
                    .HasMaxLength(100);

                entity.Property(e => e.RegistroM)
                    .HasColumnName("registroM")
                    .HasMaxLength(100);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoNovia)
                    .HasColumnName("telefono_novia")
                    .HasMaxLength(50);

                entity.Property(e => e.TelefonoNovio)
                    .HasColumnName("telefono_novio")
                    .HasMaxLength(50);

                entity.Property(e => e.TelefonoOfiNovia)
                    .HasColumnName("telefono_ofi_novia")
                    .HasMaxLength(50);

                entity.Property(e => e.TelefonoOfiNovio)
                    .HasColumnName("telefono_ofi_novio")
                    .HasMaxLength(50);

                entity.Property(e => e.Tienda)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.TiendaRecorrido)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Zona).HasMaxLength(50);
            });

            modelBuilder.Entity<ViwAniversarioBodasSinCompras>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Viw_AniversarioBodasSinCompras");

                entity.Property(e => e.ApellidoNovia1)
                    .HasColumnName("Apellido_Novia1")
                    .HasMaxLength(50);

                entity.Property(e => e.ApellidoNovia2)
                    .HasColumnName("Apellido_Novia2")
                    .HasMaxLength(50);

                entity.Property(e => e.ApellidoNovio1)
                    .HasColumnName("Apellido_Novio1")
                    .HasMaxLength(50);

                entity.Property(e => e.ApellidoNovio2)
                    .HasColumnName("Apellido_Novio2")
                    .HasMaxLength(50);

                entity.Property(e => e.CelNovia)
                    .HasColumnName("Cel_novia")
                    .HasMaxLength(50);

                entity.Property(e => e.CelNovio)
                    .HasColumnName("Cel_novio")
                    .HasMaxLength(50);

                entity.Property(e => e.Departamento).HasMaxLength(100);

                entity.Property(e => e.DescripcionLista).HasMaxLength(50);

                entity.Property(e => e.Dirección).HasMaxLength(100);

                entity.Property(e => e.EMailNovia)
                    .HasColumnName("e_mail_novia")
                    .HasMaxLength(100);

                entity.Property(e => e.EMailNovio)
                    .HasColumnName("e_mail_novio")
                    .HasMaxLength(100);

                entity.Property(e => e.Evento)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEvento).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("Id_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.Municipio).HasMaxLength(50);

                entity.Property(e => e.NombreNovia1)
                    .HasColumnName("Nombre_Novia1")
                    .HasMaxLength(100);

                entity.Property(e => e.NombreNovia2)
                    .HasColumnName("Nombre_Novia2")
                    .HasMaxLength(50);

                entity.Property(e => e.NombreNovio1)
                    .HasColumnName("Nombre_Novio1")
                    .HasMaxLength(100);

                entity.Property(e => e.NombreNovio2)
                    .HasColumnName("Nombre_Novio2")
                    .HasMaxLength(50);

                entity.Property(e => e.OrdenH)
                    .HasColumnName("ordenH")
                    .HasMaxLength(10);

                entity.Property(e => e.OrdenM)
                    .HasColumnName("ordenM")
                    .HasMaxLength(10);

                entity.Property(e => e.RegistroH)
                    .HasColumnName("registroH")
                    .HasMaxLength(100);

                entity.Property(e => e.RegistroM)
                    .HasColumnName("registroM")
                    .HasMaxLength(100);

                entity.Property(e => e.TarjetaPrivilegio)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoNovia)
                    .HasColumnName("telefono_novia")
                    .HasMaxLength(50);

                entity.Property(e => e.TelefonoNovio)
                    .HasColumnName("telefono_novio")
                    .HasMaxLength(50);

                entity.Property(e => e.TelefonoOfiNovia)
                    .HasColumnName("telefono_ofi_novia")
                    .HasMaxLength(50);

                entity.Property(e => e.TelefonoOfiNovio)
                    .HasColumnName("telefono_ofi_novio")
                    .HasMaxLength(50);

                entity.Property(e => e.Tienda)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Zona).HasMaxLength(50);
            });

            modelBuilder.Entity<ViwAniversariobodascompraslistascompletas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIW_ANIVERSARIOBODASCOMPRASLISTASCOMPLETAS");

                entity.Property(e => e.ApellidoNovia1)
                    .HasColumnName("Apellido_Novia1")
                    .HasMaxLength(50);

                entity.Property(e => e.ApellidoNovia2)
                    .HasColumnName("Apellido_Novia2")
                    .HasMaxLength(50);

                entity.Property(e => e.ApellidoNovio1)
                    .HasColumnName("Apellido_Novio1")
                    .HasMaxLength(50);

                entity.Property(e => e.ApellidoNovio2)
                    .HasColumnName("Apellido_Novio2")
                    .HasMaxLength(50);

                entity.Property(e => e.CantidadXPrecio)
                    .HasColumnName("Cantidad_x_Precio")
                    .HasColumnType("money");

                entity.Property(e => e.CelNovia)
                    .HasColumnName("Cel_novia")
                    .HasMaxLength(50);

                entity.Property(e => e.CelNovio)
                    .HasColumnName("Cel_novio")
                    .HasMaxLength(50);

                entity.Property(e => e.Certificado)
                    .HasColumnName("certificado")
                    .HasMaxLength(50);

                entity.Property(e => e.Departamento).HasMaxLength(100);

                entity.Property(e => e.DescripcionLista).HasMaxLength(50);

                entity.Property(e => e.Dirección).HasMaxLength(100);

                entity.Property(e => e.EMailNovia)
                    .HasColumnName("e_mail_novia")
                    .HasMaxLength(100);

                entity.Property(e => e.EMailNovio)
                    .HasColumnName("e_mail_novio")
                    .HasMaxLength(100);

                entity.Property(e => e.Evento)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEvento).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.Fechaliq)
                    .HasColumnName("fechaliq")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("Id_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.Municipio).HasMaxLength(50);

                entity.Property(e => e.NombreNovia1)
                    .HasColumnName("Nombre_Novia1")
                    .HasMaxLength(100);

                entity.Property(e => e.NombreNovia2)
                    .HasColumnName("Nombre_Novia2")
                    .HasMaxLength(50);

                entity.Property(e => e.NombreNovio1)
                    .HasColumnName("Nombre_Novio1")
                    .HasMaxLength(100);

                entity.Property(e => e.NombreNovio2)
                    .HasColumnName("Nombre_Novio2")
                    .HasMaxLength(50);

                entity.Property(e => e.OrdenH)
                    .HasColumnName("ordenH")
                    .HasMaxLength(10);

                entity.Property(e => e.OrdenM)
                    .HasColumnName("ordenM")
                    .HasMaxLength(10);

                entity.Property(e => e.RegistroH)
                    .HasColumnName("registroH")
                    .HasMaxLength(100);

                entity.Property(e => e.RegistroM)
                    .HasColumnName("registroM")
                    .HasMaxLength(100);

                entity.Property(e => e.TarjetaPrivilegio)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoNovia)
                    .HasColumnName("telefono_novia")
                    .HasMaxLength(50);

                entity.Property(e => e.TelefonoNovio)
                    .HasColumnName("telefono_novio")
                    .HasMaxLength(50);

                entity.Property(e => e.TelefonoOfiNovia)
                    .HasColumnName("telefono_ofi_novia")
                    .HasMaxLength(50);

                entity.Property(e => e.TelefonoOfiNovio)
                    .HasColumnName("telefono_ofi_novio")
                    .HasMaxLength(50);

                entity.Property(e => e.Tienda)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.TiendaRecorrido)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.TipoEntrega)
                    .HasColumnName("Tipo_Entrega")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Zona).HasMaxLength(50);
            });

            modelBuilder.Entity<ViwArea>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Viw_Area");

                entity.Property(e => e.CodArea).HasColumnName("cod_Area");

                entity.Property(e => e.CodCentroDist)
                    .IsRequired()
                    .HasColumnName("Cod_CentroDist")
                    .HasMaxLength(10);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ViwAreaBodas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Viw_AreaBodas");

                entity.Property(e => e.CodArea).HasColumnName("cod_Area");

                entity.Property(e => e.CodCentroDist)
                    .IsRequired()
                    .HasColumnName("Cod_CentroDist")
                    .HasMaxLength(10);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ViwAreaCs>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Viw_AreaCS");

                entity.Property(e => e.CodArea).HasColumnName("cod_Area");

                entity.Property(e => e.CodCentroDist)
                    .IsRequired()
                    .HasColumnName("Cod_CentroDist")
                    .HasMaxLength(10);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ViwAreaDom>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Viw_AreaDom");

                entity.Property(e => e.CodArea).HasColumnName("cod_Area");

                entity.Property(e => e.CodCentroDist)
                    .IsRequired()
                    .HasColumnName("Cod_CentroDist")
                    .HasMaxLength(10);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ViwArticuloGrupo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Viw_ArticuloGrupo");

                entity.Property(e => e.CodGrupo)
                    .IsRequired()
                    .HasColumnName("cod_grupo")
                    .HasMaxLength(20);

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(6);
            });

            modelBuilder.Entity<ViwArticulos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Viw_Articulos");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sku)
                    .HasColumnName("sku")
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViwBodasCompras>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIW_BODAS_COMPRAS");

                entity.Property(e => e.CantidadXPrecio)
                    .HasColumnName("Cantidad_x_Precio")
                    .HasColumnType("money");

                entity.Property(e => e.FechaEvento).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.NombreDelEvento)
                    .HasColumnName("Nombre_del_Evento")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.TipoLista)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ViwBodasComprasCall>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIW_BODAS_COMPRAS_CALL");

                entity.Property(e => e.ApellidoNovia1)
                    .HasColumnName("Apellido_Novia1")
                    .HasMaxLength(50);

                entity.Property(e => e.ApellidoNovia2)
                    .HasColumnName("Apellido_Novia2")
                    .HasMaxLength(50);

                entity.Property(e => e.ApellidoNovio1)
                    .HasColumnName("Apellido_Novio1")
                    .HasMaxLength(50);

                entity.Property(e => e.ApellidoNovio2)
                    .HasColumnName("Apellido_Novio2")
                    .HasMaxLength(50);

                entity.Property(e => e.CantidadXPrecio)
                    .HasColumnName("Cantidad_x_Precio")
                    .HasColumnType("money");

                entity.Property(e => e.CelNovia)
                    .HasColumnName("Cel_novia")
                    .HasMaxLength(50);

                entity.Property(e => e.CelNovio)
                    .HasColumnName("Cel_novio")
                    .HasMaxLength(50);

                entity.Property(e => e.EMailNovia)
                    .HasColumnName("e_mail_novia")
                    .HasMaxLength(100);

                entity.Property(e => e.EMailNovio)
                    .HasColumnName("e_mail_novio")
                    .HasMaxLength(100);

                entity.Property(e => e.Evento)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEvento).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.NombreNovia1)
                    .HasColumnName("Nombre_Novia1")
                    .HasMaxLength(100);

                entity.Property(e => e.NombreNovia2)
                    .HasColumnName("Nombre_Novia2")
                    .HasMaxLength(50);

                entity.Property(e => e.NombreNovio1)
                    .HasColumnName("Nombre_Novio1")
                    .HasMaxLength(100);

                entity.Property(e => e.NombreNovio2)
                    .HasColumnName("Nombre_Novio2")
                    .HasMaxLength(50);

                entity.Property(e => e.TelefonoNovia)
                    .HasColumnName("telefono_novia")
                    .HasMaxLength(50);

                entity.Property(e => e.TelefonoNovio)
                    .HasColumnName("telefono_novio")
                    .HasMaxLength(50);

                entity.Property(e => e.TelefonoOfiNovia)
                    .HasColumnName("telefono_ofi_novia")
                    .HasMaxLength(50);

                entity.Property(e => e.TelefonoOfiNovio)
                    .HasColumnName("telefono_ofi_novio")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ViwBodasComprasCallDir>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIW_BODAS_COMPRAS_CALL_DIR");

                entity.Property(e => e.ApellidoNovia1)
                    .HasColumnName("Apellido_Novia1")
                    .HasMaxLength(50);

                entity.Property(e => e.ApellidoNovia2)
                    .HasColumnName("Apellido_Novia2")
                    .HasMaxLength(50);

                entity.Property(e => e.ApellidoNovio1)
                    .HasColumnName("Apellido_Novio1")
                    .HasMaxLength(50);

                entity.Property(e => e.ApellidoNovio2)
                    .HasColumnName("Apellido_Novio2")
                    .HasMaxLength(50);

                entity.Property(e => e.CelNovia)
                    .HasColumnName("Cel_novia")
                    .HasMaxLength(50);

                entity.Property(e => e.CelNovio)
                    .HasColumnName("Cel_novio")
                    .HasMaxLength(50);

                entity.Property(e => e.DirecNovia)
                    .HasColumnName("Direc_Novia")
                    .HasMaxLength(250);

                entity.Property(e => e.DirecNovio)
                    .HasColumnName("Direc_Novio")
                    .HasMaxLength(250);

                entity.Property(e => e.EMailNovia)
                    .HasColumnName("e_mail_novia")
                    .HasMaxLength(100);

                entity.Property(e => e.EMailNovio)
                    .HasColumnName("e_mail_novio")
                    .HasMaxLength(100);

                entity.Property(e => e.Evento)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEvento).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.NombreNovia1)
                    .HasColumnName("Nombre_Novia1")
                    .HasMaxLength(100);

                entity.Property(e => e.NombreNovia2)
                    .HasColumnName("Nombre_Novia2")
                    .HasMaxLength(50);

                entity.Property(e => e.NombreNovio1)
                    .HasColumnName("Nombre_Novio1")
                    .HasMaxLength(100);

                entity.Property(e => e.NombreNovio2)
                    .HasColumnName("Nombre_Novio2")
                    .HasMaxLength(50);

                entity.Property(e => e.TarjetaPrivilegio)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TelefonoNovia)
                    .HasColumnName("telefono_novia")
                    .HasMaxLength(50);

                entity.Property(e => e.TelefonoNovio)
                    .HasColumnName("telefono_novio")
                    .HasMaxLength(50);

                entity.Property(e => e.TelefonoOfiNovia)
                    .HasColumnName("telefono_ofi_novia")
                    .HasMaxLength(50);

                entity.Property(e => e.TelefonoOfiNovio)
                    .HasColumnName("telefono_ofi_novio")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ViwBodasComprasSku>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIW_BODAS_COMPRAS_SKU");

                entity.Property(e => e.CantidadXPrecio)
                    .HasColumnName("Cantidad_x_Precio")
                    .HasColumnType("money");

                entity.Property(e => e.CostoUnitario)
                    .HasColumnName("Costo_Unitario")
                    .HasColumnType("numeric(38, 14)");

                entity.Property(e => e.FechaEvento).HasColumnType("datetime");

                entity.Property(e => e.NombreDelEvento)
                    .HasColumnName("Nombre_del_Evento")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<ViwBodasComprasXela>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIW_BODAS_COMPRAS_XELA");

                entity.Property(e => e.CantidadXPrecio)
                    .HasColumnName("Cantidad_x_Precio")
                    .HasColumnType("money");

                entity.Property(e => e.FechaEvento).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.NombreDelEvento)
                    .HasColumnName("Nombre_del_Evento")
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViwBodasComprasXelaSku>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIW_BODAS_COMPRAS_XELA_SKU");

                entity.Property(e => e.CantidadXPrecio)
                    .HasColumnName("Cantidad_x_Precio")
                    .HasColumnType("money");

                entity.Property(e => e.CostoUnitario)
                    .HasColumnName("Costo_Unitario")
                    .HasColumnType("numeric(38, 14)");

                entity.Property(e => e.FechaEvento).HasColumnType("datetime");

                entity.Property(e => e.NombreDelEvento)
                    .HasColumnName("Nombre_del_Evento")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<ViwBodasIntercambio>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Viw_BodasIntercambio");

                entity.Property(e => e.CantidadXPrecio)
                    .HasColumnName("cantidad_X_precio")
                    .HasColumnType("money");

                entity.Property(e => e.CodUbicacionLista)
                    .IsRequired()
                    .HasColumnName("Cod_UbicacionLista")
                    .HasMaxLength(10);

                entity.Property(e => e.FechaEvento).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.NombreEvento)
                    .HasColumnName("Nombre_Evento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoLista)
                    .IsRequired()
                    .HasColumnName("Tipo_Lista")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ViwBodasLiquidadas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Viw_BodasLiquidadas");

                entity.Property(e => e.ApellidoNovia1)
                    .HasColumnName("Apellido_Novia1")
                    .HasMaxLength(50);

                entity.Property(e => e.ApellidoNovia2)
                    .HasColumnName("Apellido_Novia2")
                    .HasMaxLength(50);

                entity.Property(e => e.ApellidoNovio1)
                    .HasColumnName("Apellido_Novio1")
                    .HasMaxLength(50);

                entity.Property(e => e.ApellidoNovio2)
                    .HasColumnName("Apellido_Novio2")
                    .HasMaxLength(50);

                entity.Property(e => e.CantidadXPrecio)
                    .HasColumnName("Cantidad_x_Precio")
                    .HasColumnType("money");

                entity.Property(e => e.CelNovia)
                    .HasColumnName("Cel_novia")
                    .HasMaxLength(50);

                entity.Property(e => e.CelNovio)
                    .HasColumnName("Cel_novio")
                    .HasMaxLength(50);

                entity.Property(e => e.CodUbicacionLiq)
                    .IsRequired()
                    .HasColumnName("Cod_UbicacionLiq")
                    .HasMaxLength(10);

                entity.Property(e => e.Departamento).HasMaxLength(100);

                entity.Property(e => e.Dirección).HasMaxLength(100);

                entity.Property(e => e.EMailNovia)
                    .HasColumnName("e_mail_novia")
                    .HasMaxLength(100);

                entity.Property(e => e.EMailNovio)
                    .HasColumnName("e_mail_novio")
                    .HasMaxLength(100);

                entity.Property(e => e.Evento)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEvento).HasColumnType("datetime");

                entity.Property(e => e.FechaLiquidacion).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("Id_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.Municipio).HasMaxLength(50);

                entity.Property(e => e.NombreNovia1)
                    .HasColumnName("Nombre_Novia1")
                    .HasMaxLength(100);

                entity.Property(e => e.NombreNovia2)
                    .HasColumnName("Nombre_Novia2")
                    .HasMaxLength(50);

                entity.Property(e => e.NombreNovio1)
                    .HasColumnName("Nombre_Novio1")
                    .HasMaxLength(100);

                entity.Property(e => e.NombreNovio2)
                    .HasColumnName("Nombre_Novio2")
                    .HasMaxLength(50);

                entity.Property(e => e.OrdenH)
                    .HasColumnName("ordenH")
                    .HasMaxLength(10);

                entity.Property(e => e.OrdenM)
                    .HasColumnName("ordenM")
                    .HasMaxLength(10);

                entity.Property(e => e.PuntosAcreditosBodasInscrip).HasColumnType("money");

                entity.Property(e => e.RegistroH)
                    .HasColumnName("registroH")
                    .HasMaxLength(100);

                entity.Property(e => e.RegistroM)
                    .HasColumnName("registroM")
                    .HasMaxLength(100);

                entity.Property(e => e.TarjetaPrivilegio)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoNovia)
                    .HasColumnName("telefono_novia")
                    .HasMaxLength(50);

                entity.Property(e => e.TelefonoNovio)
                    .HasColumnName("telefono_novio")
                    .HasMaxLength(50);

                entity.Property(e => e.TelefonoOfiNovia)
                    .HasColumnName("telefono_ofi_novia")
                    .HasMaxLength(50);

                entity.Property(e => e.TelefonoOfiNovio)
                    .HasColumnName("telefono_ofi_novio")
                    .HasMaxLength(50);

                entity.Property(e => e.Tienda)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.TipoLista).HasMaxLength(50);

                entity.Property(e => e.Zona).HasMaxLength(50);
            });

            modelBuilder.Entity<ViwBodasNoviosConPrivilegio>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Viw_Bodas_Novios_Con_Privilegio");

                entity.Property(e => e.Apellido1Novia)
                    .HasColumnName("Apellido1NOVIA")
                    .HasMaxLength(50);

                entity.Property(e => e.Apellido1Novio)
                    .HasColumnName("Apellido1NOVIO")
                    .HasMaxLength(50);

                entity.Property(e => e.Apellido2Novia)
                    .HasColumnName("Apellido2NOVIA")
                    .HasMaxLength(50);

                entity.Property(e => e.Apellido2Novio)
                    .HasColumnName("Apellido2NOVIO")
                    .HasMaxLength(50);

                entity.Property(e => e.ApellidosPrivi)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Celular).HasMaxLength(50);

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasColumnName("Cod_Ubicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.CodUbicacionLista)
                    .IsRequired()
                    .HasColumnName("Cod_UbicacionLista")
                    .HasMaxLength(10);

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(100);

                entity.Property(e => e.Expr1).HasMaxLength(100);

                entity.Property(e => e.Expr2).HasMaxLength(50);

                entity.Property(e => e.Expr3).HasMaxLength(50);

                entity.Property(e => e.Expr4).HasMaxLength(50);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.FechaEvento).HasColumnType("datetime");

                entity.Property(e => e.FechaLista).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.IdAsociado)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("Id_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.Nombre1Novia)
                    .HasColumnName("Nombre1NOVIA")
                    .HasMaxLength(100);

                entity.Property(e => e.Nombre1Novio)
                    .HasColumnName("Nombre1NOVIO")
                    .HasMaxLength(100);

                entity.Property(e => e.Nombre2Novia)
                    .HasColumnName("Nombre2NOVIA")
                    .HasMaxLength(50);

                entity.Property(e => e.Nombre2Novio)
                    .HasColumnName("Nombre2NOVIO")
                    .HasMaxLength(50);

                entity.Property(e => e.NombreTarjetaPrivi)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NombresPrivi)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TarjetaPrivilegio)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TelOficina).HasMaxLength(50);

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViwBodasRegistradasXela>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIW_BODAS_REGISTRADAS_XELA");

                entity.Property(e => e.FechaEvento).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.NombreDelEvento)
                    .HasColumnName("Nombre_del_Evento")
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViwBodasTipoLista>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Viw_BodasTipoLista");

                entity.Property(e => e.CantidadXPrecio)
                    .HasColumnName("cantidad_X_precio")
                    .HasColumnType("money");

                entity.Property(e => e.CodUbicacionLista)
                    .IsRequired()
                    .HasColumnName("Cod_UbicacionLista")
                    .HasMaxLength(10);

                entity.Property(e => e.FechaEvento).HasColumnType("datetime");

                entity.Property(e => e.NombreEvento)
                    .HasColumnName("Nombre_Evento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoLista)
                    .IsRequired()
                    .HasColumnName("Tipo_Lista")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ViwCantidadBodas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIW_Cantidad_Bodas");

                entity.Property(e => e.CantidadDeBodas).HasColumnName("cantidad_de_bodas");
            });

            modelBuilder.Entity<ViwCantidadBodasCertificados>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIW_CANTIDAD_BODAS_CERTIFICADOS");

                entity.Property(e => e.CantidadCertificados).HasColumnName("Cantidad_Certificados");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaEvento).HasColumnType("datetime");

                entity.Property(e => e.MontoCertificados)
                    .HasColumnName("Monto_Certificados")
                    .HasColumnType("money");

                entity.Property(e => e.NombreDelEvento)
                    .HasColumnName("Nombre_del_Evento")
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViwCantidadDeBodasTipo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIW_Cantidad_de_Bodas_Tipo");

                entity.Property(e => e.CantidadDeBodas).HasColumnName("Cantidad_de_bodas");

                entity.Property(e => e.CodTipoLista).HasColumnName("Cod_TipoLista");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ViwConsultaExistenciaTiendas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Viw_ConsultaExistencia_TIENDAS");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Tienda)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<ViwDetApartado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViwDet_Apartado");

                entity.Property(e => e.Ambiente).HasMaxLength(50);

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("ID_Envio")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<ViwDetEnvioLib>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViwDet_EnvioLib");

                entity.Property(e => e.Ambiente)
                    .IsRequired()
                    .HasColumnName("ambiente")
                    .HasMaxLength(50);

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasColumnName("color")
                    .HasMaxLength(100);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(50);

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("id_envio")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("sku")
                    .HasMaxLength(25);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ViwDetListaRegalos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViwDet_ListaRegalos");

                entity.Property(e => e.Ambiente)
                    .IsRequired()
                    .HasColumnName("ambiente")
                    .HasMaxLength(50);

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasColumnName("color")
                    .HasMaxLength(100);

                entity.Property(e => e.Comprado).HasColumnName("comprado");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(350);

                entity.Property(e => e.Ean)
                    .IsRequired()
                    .HasColumnName("ean")
                    .HasMaxLength(50);

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("ID_Envio")
                    .HasMaxLength(25);

                entity.Property(e => e.IdEvento)
                    .HasColumnName("id_evento")
                    .HasMaxLength(25);

                entity.Property(e => e.Marca)
                    .IsRequired()
                    .HasColumnName("marca")
                    .HasMaxLength(100);

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasColumnName("modelo")
                    .HasMaxLength(100);

                entity.Property(e => e.Precio)
                    .HasColumnName("precio")
                    .HasColumnType("money");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("sku")
                    .HasMaxLength(50);

                entity.Property(e => e.Solicitado).HasColumnName("solicitado");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Unidmed)
                    .IsRequired()
                    .HasColumnName("unidmed")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ViwDetListaRegalosAct>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViwDet_ListaRegalosAct");

                entity.Property(e => e.Ambiente)
                    .HasColumnName("ambiente")
                    .HasMaxLength(50);

                entity.Property(e => e.Color)
                    .HasColumnName("color")
                    .HasMaxLength(100);

                entity.Property(e => e.Comprado).HasColumnName("comprado");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(50);

                entity.Property(e => e.Ean)
                    .HasColumnName("ean")
                    .HasMaxLength(50);

                entity.Property(e => e.IdEvento)
                    .HasColumnName("id_evento")
                    .HasMaxLength(25);

                entity.Property(e => e.Marca)
                    .HasColumnName("marca")
                    .HasMaxLength(100);

                entity.Property(e => e.Modelo)
                    .HasColumnName("modelo")
                    .HasMaxLength(100);

                entity.Property(e => e.Precio)
                    .HasColumnName("precio")
                    .HasColumnType("money");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("sku")
                    .HasMaxLength(50);

                entity.Property(e => e.Solicitado).HasColumnName("solicitado");

                entity.Property(e => e.Unidmed)
                    .HasColumnName("unidmed")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ViwDetRegalosComprados>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViwDet_RegalosComprados");

                entity.Property(e => e.Comprador)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(350);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdEvento)
                    .HasColumnName("ID_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.Mail).HasMaxLength(50);

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Telefono).HasMaxLength(50);

                entity.Property(e => e.Tienda)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<ViwDetRequerimiento>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViwDet_Requerimiento");

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasColumnName("Cod_Ubicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Descripcion).HasMaxLength(350);

                entity.Property(e => e.FechaConf).HasColumnType("datetime");

                entity.Property(e => e.FechaGen).HasColumnType("datetime");

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("ID_Envio")
                    .HasMaxLength(25);

                entity.Property(e => e.IdTraslado)
                    .HasColumnName("ID_Traslado")
                    .HasMaxLength(25);

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.Localizacion).HasMaxLength(15);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoLoc).HasMaxLength(10);
            });

            modelBuilder.Entity<ViwDetTraslado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViwDet_Traslado");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Descripcion).HasMaxLength(350);

                entity.Property(e => e.FechaRecep).HasColumnType("datetime");

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("ID_Envio")
                    .HasMaxLength(25);

                entity.Property(e => e.IdTraslado)
                    .IsRequired()
                    .HasColumnName("ID_Traslado")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<ViwDetalleBodasTipo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIW_Detalle_Bodas_Tipo");

                entity.Property(e => e.CodTipoLista).HasColumnName("Cod_TipoLista");

                entity.Property(e => e.CodUbicacionLista)
                    .IsRequired()
                    .HasColumnName("Cod_UbicacionLista")
                    .HasMaxLength(10);

                entity.Property(e => e.Descripción)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FechaEvento).HasColumnType("datetime");

                entity.Property(e => e.NombreDelEvento)
                    .HasColumnName("Nombre_del_Evento")
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViwDirEnvio>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Viw_DirEnvio");

                entity.Property(e => e.CodDepartamento).HasColumnName("Cod_Departamento");

                entity.Property(e => e.CodMunicipio).HasColumnName("Cod_Municipio");

                entity.Property(e => e.CodPais)
                    .HasColumnName("Cod_Pais")
                    .HasMaxLength(5);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("Id_Envio")
                    .HasMaxLength(25);

                entity.Property(e => e.IdEvento)
                    .HasColumnName("Id_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Zona).HasMaxLength(50);
            });

            modelBuilder.Entity<ViwDirEvento>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Viw_DirEvento");

                entity.Property(e => e.CodDepartamento).HasColumnName("cod_departamento");

                entity.Property(e => e.CodMunicipio).HasColumnName("cod_municipio");

                entity.Property(e => e.CodPais)
                    .HasColumnName("Cod_pais")
                    .HasMaxLength(5);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasColumnName("direccion")
                    .HasMaxLength(250);

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("id_evento")
                    .HasMaxLength(25);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasColumnName("telefono")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Zona)
                    .HasColumnName("zona")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ViwEnvioEnt>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Viw_EnvioEnt");

                entity.Property(e => e.Caja)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.CodArea).HasColumnName("Cod_Area");

                entity.Property(e => e.CodTipoPago).HasColumnName("Cod_TipoPago");

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasColumnName("Cod_Ubicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.Comprador)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("ID_Envio")
                    .HasMaxLength(25);

                entity.Property(e => e.IdEvento)
                    .HasColumnName("ID_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.IdPersonal)
                    .IsRequired()
                    .HasColumnName("Id_Personal")
                    .HasMaxLength(25);

                entity.Property(e => e.MailEntrega).HasMaxLength(50);

                entity.Property(e => e.Observaciones).HasMaxLength(1000);

                entity.Property(e => e.Sobre).HasMaxLength(25);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TelEntrega).HasMaxLength(50);

                entity.Property(e => e.Transaccion)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<ViwEnviosPosterioresBodasLiquidadas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Viw_EnviosPosterioresBodasLiquidadas");

                entity.Property(e => e.ApellidoNovia1)
                    .HasColumnName("Apellido_Novia1")
                    .HasMaxLength(50);

                entity.Property(e => e.ApellidoNovia2)
                    .HasColumnName("Apellido_Novia2")
                    .HasMaxLength(50);

                entity.Property(e => e.ApellidoNovio1)
                    .HasColumnName("Apellido_Novio1")
                    .HasMaxLength(50);

                entity.Property(e => e.ApellidoNovio2)
                    .HasColumnName("Apellido_Novio2")
                    .HasMaxLength(50);

                entity.Property(e => e.CantidadXPrecio)
                    .HasColumnName("Cantidad_x_Precio")
                    .HasColumnType("money");

                entity.Property(e => e.CelNovia)
                    .HasColumnName("Cel_novia")
                    .HasMaxLength(50);

                entity.Property(e => e.CelNovio)
                    .HasColumnName("Cel_novio")
                    .HasMaxLength(50);

                entity.Property(e => e.CodUbicacionLiq)
                    .IsRequired()
                    .HasColumnName("Cod_UbicacionLiq")
                    .HasMaxLength(10);

                entity.Property(e => e.Departamento).HasMaxLength(100);

                entity.Property(e => e.Dirección).HasMaxLength(100);

                entity.Property(e => e.EMailNovia)
                    .HasColumnName("e_mail_novia")
                    .HasMaxLength(100);

                entity.Property(e => e.EMailNovio)
                    .HasColumnName("e_mail_novio")
                    .HasMaxLength(100);

                entity.Property(e => e.Evento)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEvento).HasColumnType("datetime");

                entity.Property(e => e.FechaLiquidacion).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("Id_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.Municipio).HasMaxLength(50);

                entity.Property(e => e.NombreNovia1)
                    .HasColumnName("Nombre_Novia1")
                    .HasMaxLength(100);

                entity.Property(e => e.NombreNovia2)
                    .HasColumnName("Nombre_Novia2")
                    .HasMaxLength(50);

                entity.Property(e => e.NombreNovio1)
                    .HasColumnName("Nombre_Novio1")
                    .HasMaxLength(100);

                entity.Property(e => e.NombreNovio2)
                    .HasColumnName("Nombre_Novio2")
                    .HasMaxLength(50);

                entity.Property(e => e.OrdenH)
                    .HasColumnName("ordenH")
                    .HasMaxLength(10);

                entity.Property(e => e.OrdenM)
                    .HasColumnName("ordenM")
                    .HasMaxLength(10);

                entity.Property(e => e.PuntosAcreditosBodasInscrip).HasColumnType("money");

                entity.Property(e => e.RegistroH)
                    .HasColumnName("registroH")
                    .HasMaxLength(100);

                entity.Property(e => e.RegistroM)
                    .HasColumnName("registroM")
                    .HasMaxLength(100);

                entity.Property(e => e.TarjetaPrivilegio)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoNovia)
                    .HasColumnName("telefono_novia")
                    .HasMaxLength(50);

                entity.Property(e => e.TelefonoNovio)
                    .HasColumnName("telefono_novio")
                    .HasMaxLength(50);

                entity.Property(e => e.TelefonoOfiNovia)
                    .HasColumnName("telefono_ofi_novia")
                    .HasMaxLength(50);

                entity.Property(e => e.TelefonoOfiNovio)
                    .HasColumnName("telefono_ofi_novio")
                    .HasMaxLength(50);

                entity.Property(e => e.Tienda)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.TipoLista).HasMaxLength(50);

                entity.Property(e => e.Zona).HasMaxLength(50);
            });

            modelBuilder.Entity<ViwEnviosporEmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Viw_EnviosporEmp");

                entity.Property(e => e.CodArea).HasColumnName("Cod_Area");

                entity.Property(e => e.CodCentroDist)
                    .IsRequired()
                    .HasColumnName("Cod_CentroDist")
                    .HasMaxLength(10);

                entity.Property(e => e.Comprador)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Empacable)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("ID_Envio")
                    .HasMaxLength(25);

                entity.Property(e => e.IdEvento)
                    .HasColumnName("Id_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.NomStatus)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones).HasMaxLength(1000);

                entity.Property(e => e.Sobre).HasMaxLength(25);

                entity.Property(e => e.Titulo)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViwEstatusDeRegalos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIW_Estatus_de_Regalos");

                entity.Property(e => e.Comprador)
                    .IsRequired()
                    .HasColumnName("comprador")
                    .HasMaxLength(100);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(50);

                entity.Property(e => e.Estatus)
                    .IsRequired()
                    .HasColumnName("estatus")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Fechaevento)
                    .HasColumnName("fechaevento")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("id_envio")
                    .HasMaxLength(25);

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("id_evento")
                    .HasMaxLength(25);

                entity.Property(e => e.NombreEvento)
                    .HasColumnName("Nombre_Evento")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("sku")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<ViwEventoBeneficio>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Viw_EventoBeneficio");

                entity.Property(e => e.Acumulado).HasColumnType("money");

                entity.Property(e => e.Asesora)
                    .IsRequired()
                    .HasMaxLength(70);

                entity.Property(e => e.Beneficios)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cena)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Certificado)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Entrega).HasColumnType("datetime");

                entity.Property(e => e.FechaEvento).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.Hotel)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("ID_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.Property(e => e.NomStatus)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Novia).HasMaxLength(253);

                entity.Property(e => e.Novio).HasMaxLength(253);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tienda)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViwExistencias>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Viw_Existencias");

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasColumnName("cod_ubicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.Existencia).HasColumnName("existencia");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("sku")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ViwExistencias2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Viw_Existencias2");

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasColumnName("cod_ubicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.Existencia).HasColumnName("existencia");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("sku")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ViwExpoBodas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Viw_ExpoBodas");

                entity.Property(e => e.Apellido1).HasMaxLength(50);

                entity.Property(e => e.Apellido2).HasMaxLength(50);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.FechaEvento).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Nombre1).HasMaxLength(100);

                entity.Property(e => e.Nombre2).HasMaxLength(50);

                entity.Property(e => e.NombreEvento)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PasswordInternet)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TarjetaPrivilegio)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TiendaRegistro)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<ViwInscripcionAsesoras>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Viw_InscripcionAsesoras");

                entity.Property(e => e.IdAsesora)
                    .IsRequired()
                    .HasColumnName("Id_Asesora")
                    .HasMaxLength(50);

                entity.Property(e => e.NombreAsesora)
                    .IsRequired()
                    .HasMaxLength(70);

                entity.Property(e => e.Tienda)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<ViwNoRecorridos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Viw_NoRecorridos");

                entity.Property(e => e.CantidadDeRecorridos).HasColumnName("Cantidad_De_Recorridos");

                entity.Property(e => e.Mes)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Tienda)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<ViwNovios>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Viw_Novios");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("id_evento")
                    .HasMaxLength(25);

                entity.Property(e => e.NombreNovia).HasMaxLength(151);

                entity.Property(e => e.NombreNovio).HasMaxLength(151);
            });

            modelBuilder.Entity<ViwNovios2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Viw_Novios2");

                entity.Property(e => e.ApellidoNovia).HasMaxLength(101);

                entity.Property(e => e.ApellidoNovio).HasMaxLength(101);

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("id_evento")
                    .HasMaxLength(25);

                entity.Property(e => e.NombreNovia).HasMaxLength(151);

                entity.Property(e => e.NombreNovio).HasMaxLength(151);
            });

            modelBuilder.Entity<ViwRegaloComprado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Viw_Regalo_Comprado");

                entity.Property(e => e.Caja).HasMaxLength(5);

                entity.Property(e => e.Correlativo).HasColumnType("numeric(12, 0)");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(30);

                entity.Property(e => e.Enviado)
                    .IsRequired()
                    .HasColumnName("enviado")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCompra)
                    .HasColumnName("Fecha_Compra")
                    .HasColumnType("datetime");

                entity.Property(e => e.NoRegLta).HasColumnName("no_Reg_lta");

                entity.Property(e => e.NoTracking).HasColumnName("No_Tracking");

                entity.Property(e => e.NombreComprador)
                    .IsRequired()
                    .HasColumnName("Nombre_Comprador")
                    .HasMaxLength(100);

                entity.Property(e => e.Notx).HasColumnName("NOTX");

                entity.Property(e => e.NumeroRegalo)
                    .IsRequired()
                    .HasColumnName("Numero_Regalo")
                    .HasMaxLength(25);

                entity.Property(e => e.PrecioCompra)
                    .HasColumnName("Precio_Compra")
                    .HasColumnType("money");

                entity.Property(e => e.ProcesoActual)
                    .IsRequired()
                    .HasColumnName("Proceso_Actual")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RegaloComprado).HasColumnName("regalo_comprado");

                entity.Property(e => e.Responsable)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(18);

                entity.Property(e => e.TelefonoComprador)
                    .HasColumnName("Telefono_Comprador")
                    .HasMaxLength(50);

                entity.Property(e => e.Tienda)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.TiendaEvento)
                    .IsRequired()
                    .HasColumnName("tienda_evento")
                    .HasMaxLength(10);

                entity.Property(e => e.TipoEvento)
                    .IsRequired()
                    .HasColumnName("Tipo_Evento")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.TipoPrecio)
                    .IsRequired()
                    .HasColumnName("tipo_precio")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Unimed)
                    .IsRequired()
                    .HasColumnName("unimed")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViwRegalosComprados>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Viw_RegalosComprados");

                entity.Property(e => e.CantXPrecio)
                    .HasColumnName("Cant_X_Precio")
                    .HasColumnType("money");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.Comprador)
                    .IsRequired()
                    .HasColumnName("comprador")
                    .HasMaxLength(100);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(350);

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("id_envio")
                    .HasMaxLength(25);

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("id_evento")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("sku")
                    .HasMaxLength(25);

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasColumnName("titulo")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViwTiempoEntrega>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Viw_TiempoEntrega");

                entity.Property(e => e.Comprador)
                    .IsRequired()
                    .HasColumnName("comprador")
                    .HasMaxLength(100);

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fechaentrega)
                    .HasColumnName("fechaentrega")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("id_envio")
                    .HasMaxLength(25);

                entity.Property(e => e.IdEvento)
                    .HasColumnName("ID_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.MailEntrega).HasMaxLength(50);

                entity.Property(e => e.Tiempo).HasColumnName("tiempo");
            });

            modelBuilder.Entity<ViwTrasladoEnvio>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Viw_TrasladoEnvio");

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("ID_Envio")
                    .HasMaxLength(25);

                entity.Property(e => e.IdTraslado)
                    .HasColumnName("ID_Traslado")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<ViwTrasladoPendiente>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Viw_TrasladoPendiente");

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasColumnName("Cod_Ubicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaRecep).HasColumnType("datetime");

                entity.Property(e => e.IdTraslado)
                    .IsRequired()
                    .HasColumnName("ID_Traslado")
                    .HasMaxLength(25);

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.IdUsuarioRec)
                    .HasColumnName("ID_UsuarioRec")
                    .HasMaxLength(40);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ViwVentasTienda>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Viw_VentasTienda");

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.Property(e => e.Tienda)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<VwBodasTotalCompras>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Bodas_Total_Compras");

                entity.Property(e => e.ArtComprados).HasColumnName("Art. Comprados");

                entity.Property(e => e.CompraTotal)
                    .HasColumnName("Compra Total")
                    .HasColumnType("money");

                entity.Property(e => e.Evento)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("ID_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.TiendaInscripcion)
                    .IsRequired()
                    .HasColumnName("Tienda Inscripcion")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<VwEventosPorFechaEventoReporteDinamico>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_eventos_por_fecha_evento_reporte_dinamico");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FechaEvento)
                    .HasColumnName("Fecha_evento")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaInscripcion)
                    .HasColumnName("Fecha_inscripcion")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasColumnName("ID")
                    .HasMaxLength(25);

                entity.Property(e => e.NombreEvento)
                    .IsRequired()
                    .HasColumnName("Nombre_evento")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NombreNovia)
                    .HasColumnName("Nombre_novia")
                    .HasMaxLength(253);

                entity.Property(e => e.Telefonos).HasMaxLength(103);

                entity.Property(e => e.Tienda)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<VwFormularioEntrega>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vw_formulario_entrega");

                entity.Property(e => e.Comentario)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdGuia)
                    .HasColumnName("ID_Guia")
                    .HasMaxLength(261);

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Serie)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Status1)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwFormularioLogisticaVerificarNoPedido>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_FormularioLogistica_verificar_no_pedido");

                entity.Property(e => e.Envio)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwInscripcionesBebe>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_Inscripciones_BEBE");

                entity.Property(e => e.CantListas).HasColumnName("Cant. Listas");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.Fecha).HasMaxLength(30);

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("Id_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.NombreDelEvento)
                    .IsRequired()
                    .HasColumnName("Nombre Del Evento")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TiendaInscripcion)
                    .IsRequired()
                    .HasColumnName("Tienda_Inscripcion")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<VwInscripcionesClubBebe>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Inscripciones_Club_Bebe");

                entity.Property(e => e.CodTienda)
                    .IsRequired()
                    .HasColumnName("Cod_Tienda")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<VwInscripcionesEventosReporteDinamico>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_inscripciones_eventos_reporte_dinamico");

                entity.Property(e => e.EmailNovia)
                    .IsRequired()
                    .HasColumnName("Email_novia")
                    .HasMaxLength(100);

                entity.Property(e => e.EmailNovio)
                    .HasColumnName("Email_novio")
                    .HasMaxLength(100);

                entity.Property(e => e.FechaEvento)
                    .HasColumnName("Fecha_evento")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaInscripcion)
                    .HasColumnName("Fecha_inscripcion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaLista)
                    .HasColumnName("Fecha_lista")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdAsesora)
                    .IsRequired()
                    .HasColumnName("ID_asesora")
                    .HasMaxLength(50);

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("Id_evento")
                    .HasMaxLength(25);

                entity.Property(e => e.Lista)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NombreAsesora)
                    .HasColumnName("Nombre_asesora")
                    .HasMaxLength(100);

                entity.Property(e => e.NombreNovia)
                    .IsRequired()
                    .HasColumnName("Nombre_novia")
                    .HasMaxLength(253);

                entity.Property(e => e.NombreNovio)
                    .HasColumnName("Nombre_novio")
                    .HasMaxLength(253);

                entity.Property(e => e.TelefonoNovia)
                    .IsRequired()
                    .HasColumnName("Telefono_novia")
                    .HasMaxLength(103);

                entity.Property(e => e.TelefonoNovio)
                    .HasColumnName("Telefono_novio")
                    .HasMaxLength(103);

                entity.Property(e => e.TiendaEventoInscripcion)
                    .IsRequired()
                    .HasColumnName("Tienda/Evento_Inscripcion")
                    .HasMaxLength(10);

                entity.Property(e => e.TiendaLiquidacion)
                    .HasColumnName("Tienda_liquidacion")
                    .HasMaxLength(10);

                entity.Property(e => e.TiendaRecorrido)
                    .IsRequired()
                    .HasColumnName("Tienda_recorrido")
                    .HasMaxLength(10);

                entity.Property(e => e.TipoAsesora)
                    .IsRequired()
                    .HasColumnName("Tipo_asesora")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.TipoEvento)
                    .IsRequired()
                    .HasColumnName("Tipo_evento")
                    .HasMaxLength(100);

                entity.Property(e => e.TipoLista)
                    .HasColumnName("Tipo_lista")
                    .HasMaxLength(50);

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwInscripcionesSinRecoridoBebe>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_Inscripciones_Sin_Recorido_BEBE");

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.Fecha).HasMaxLength(30);

                entity.Property(e => e.Inscripcion).HasColumnName("# Inscripcion");

                entity.Property(e => e.NombreMes)
                    .HasColumnName("Nombre Mes")
                    .HasMaxLength(30);

                entity.Property(e => e.TiendaInscripcion)
                    .IsRequired()
                    .HasColumnName("Tienda_Inscripcion")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<VwRecorridoEventoAdultosReporteDinamico>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_recorrido_evento_adultos_reporte_dinamico");

                entity.Property(e => e.FechaEvento)
                    .HasColumnName("Fecha_evento")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaEvento1)
                    .HasColumnName("FechaEvento")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRecorrido)
                    .HasColumnName("Fecha_recorrido")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdAsesora)
                    .IsRequired()
                    .HasColumnName("Id_Asesora")
                    .HasMaxLength(25);

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("Id_evento")
                    .HasMaxLength(25);

                entity.Property(e => e.Inscripcion).HasColumnType("datetime");

                entity.Property(e => e.NombreAsesora)
                    .IsRequired()
                    .HasColumnName("Nombre_asesora")
                    .HasMaxLength(100);

                entity.Property(e => e.NombreNovia)
                    .HasColumnName("Nombre_novia")
                    .HasMaxLength(253);

                entity.Property(e => e.NombreNovio)
                    .HasColumnName("Nombre_novio")
                    .HasMaxLength(253);

                entity.Property(e => e.NoviaEmail)
                    .HasColumnName("Novia_email")
                    .HasMaxLength(100);

                entity.Property(e => e.NoviaTelefonos)
                    .HasColumnName("Novia_telefonos")
                    .HasMaxLength(156);

                entity.Property(e => e.NovioEmail)
                    .HasColumnName("Novio_email")
                    .HasMaxLength(100);

                entity.Property(e => e.NovioTelefonos)
                    .HasColumnName("Novio_telefonos")
                    .HasMaxLength(156);

                entity.Property(e => e.RealizaRecorrido)
                    .IsRequired()
                    .HasColumnName("Realiza_recorrido")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Tiempo)
                    .IsRequired()
                    .HasMaxLength(22)
                    .IsUnicode(false);

                entity.Property(e => e.TiendaInscripcion)
                    .IsRequired()
                    .HasColumnName("Tienda_inscripcion")
                    .HasMaxLength(10);

                entity.Property(e => e.TiendaRecorrido)
                    .HasColumnName("Tienda_recorrido")
                    .HasMaxLength(10);

                entity.Property(e => e.TieneRecorrido)
                    .IsRequired()
                    .HasColumnName("Tiene_recorrido")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TipoAsesora)
                    .IsRequired()
                    .HasColumnName("Tipo_asesora")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Titulo)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwRecorridosClubBebe>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Recorridos_Club_Bebe");

                entity.Property(e => e.CodTienda)
                    .IsRequired()
                    .HasColumnName("Cod_Tienda")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<VwVentasporEvento1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_ventasporEvento1");

                entity.Property(e => e.Anioventa).HasColumnName("ANIOVENTA");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.Fechabusqueda)
                    .HasColumnName("FECHABUSQUEDA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fechaevento)
                    .HasColumnName("FECHAEVENTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fecharegistro)
                    .HasColumnName("FECHAREGISTRO")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdAsesora)
                    .HasColumnName("ID_ASESORA")
                    .HasMaxLength(25);

                entity.Property(e => e.IdCaja)
                    .HasColumnName("ID_CAJA")
                    .HasMaxLength(5);

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("ID_EVENTO")
                    .HasMaxLength(25);

                entity.Property(e => e.Mesventa).HasColumnName("MESVENTA");

                entity.Property(e => e.Nombreasesora)
                    .HasColumnName("NOMBREASESORA")
                    .HasMaxLength(100);

                entity.Property(e => e.Precionormal)
                    .HasColumnName("PRECIONORMAL")
                    .HasColumnType("money");

                entity.Property(e => e.Reserva)
                    .IsRequired()
                    .HasColumnName("RESERVA")
                    .HasMaxLength(25);

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Tiendainscripcion)
                    .IsRequired()
                    .HasColumnName("TIENDAINSCRIPCION")
                    .HasMaxLength(10);

                entity.Property(e => e.Tiendaventa)
                    .IsRequired()
                    .HasColumnName("TIENDAVENTA")
                    .HasMaxLength(10);

                entity.Property(e => e.TipoAsesora)
                    .HasColumnName("TIPO_ASESORA")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Tipoventa)
                    .IsRequired()
                    .HasColumnName("TIPOVENTA")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasColumnName("TITULO")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Transaccion)
                    .HasColumnName("TRANSACCION")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<VwVentasporEvento2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_ventasporEvento2");

                entity.Property(e => e.IdCaja)
                    .IsRequired()
                    .HasColumnName("ID_CAJA")
                    .HasMaxLength(10);

                entity.Property(e => e.Preciodesc)
                    .HasColumnName("PRECIODESC")
                    .HasColumnType("money");

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Transaccion).HasColumnName("TRANSACCION");
            });

            modelBuilder.Entity<VwZreporteCallCenterLista>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_ZReporte_CallCenter_Lista");

                entity.Property(e => e.Celular)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FechaEvento).HasColumnType("date");

                entity.Property(e => e.FechaRegistro).HasColumnType("date");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("Id_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.Lista1)
                    .IsRequired()
                    .HasColumnName("Lista 1")
                    .HasMaxLength(25);

                entity.Property(e => e.Lista2)
                    .IsRequired()
                    .HasColumnName("Lista 2")
                    .HasMaxLength(25);

                entity.Property(e => e.Lista3)
                    .IsRequired()
                    .HasColumnName("Lista 3")
                    .HasMaxLength(25);

                entity.Property(e => e.Lista4)
                    .IsRequired()
                    .HasColumnName("Lista 4")
                    .HasMaxLength(25);

                entity.Property(e => e.Lista5)
                    .IsRequired()
                    .HasColumnName("Lista 5")
                    .HasMaxLength(25);

                entity.Property(e => e.NombreDeLaMama)
                    .IsRequired()
                    .HasColumnName("Nombre de la MAMA")
                    .HasMaxLength(4000);

                entity.Property(e => e.NombreDelBebe)
                    .IsRequired()
                    .HasColumnName("Nombre del BEBE")
                    .HasMaxLength(4000);

                entity.Property(e => e.NombreDelPapa)
                    .IsRequired()
                    .HasColumnName("Nombre del PAPA")
                    .HasMaxLength(4000);

                entity.Property(e => e.NombreTarjeta)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TarjetaPrivilegio)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TiendaInscrita)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<VwZreporteTotalVentasClubBebe>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_ZReporte_Total_Ventas_Club_Bebe");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("Id_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.TiendaDeVenta)
                    .IsRequired()
                    .HasColumnName("Tienda de Venta")
                    .HasMaxLength(10);

                entity.Property(e => e.TiendaInscrita)
                    .IsRequired()
                    .HasColumnName("Tienda Inscrita")
                    .HasMaxLength(10);

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.VentaTotal)
                    .HasColumnName("Venta Total")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<VwZreporteVentasClubBebe>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_ZReporte_Ventas_Club_Bebe");

                entity.Property(e => e.ApCasada)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Apellido1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Apellido2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ArtComprados).HasColumnName("Art. Comprados");

                entity.Property(e => e.ArticulosSoliciatos).HasColumnName("Articulos Soliciatos");

                entity.Property(e => e.CodTipoCont).HasColumnName("Cod_TipoCont");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMail")
                    .HasMaxLength(100);

                entity.Property(e => e.FechaEvento).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("Id_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Nombre1)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Nombre2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NombreEvento)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TarjetaPrivilegio)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TiendaRegistro)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.TotalDeVentas)
                    .HasColumnName("Total de Ventas")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<ZBorrarEvenoBebe>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Z_BORRAR_EVENO_BEBE");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnName("FECHA_REGISTRO")
                    .HasColumnType("datetime");

                entity.Property(e => e.TarjetaPrivilegio)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZDashboardecActivoevento>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_ACTIVOEVENTO");

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(18);
            });

            modelBuilder.Entity<ZDashboardecBodasActivas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_BODAS_ACTIVAS");

                entity.Property(e => e.FechaEvento).HasColumnType("datetime");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("Id_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.TipoBoda).HasMaxLength(50);
            });

            modelBuilder.Entity<ZDashboardecEventosConRegalo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_EVENTOS_CON_REGALO");

                entity.Property(e => e.CantidadEventos).HasColumnName("CANTIDAD_EVENTOS");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.TipoEvento)
                    .IsRequired()
                    .HasColumnName("TIPO_EVENTO")
                    .HasMaxLength(100);

                entity.Property(e => e.UnidadesPorEvento)
                    .HasColumnName("UNIDADES_POR_EVENTO")
                    .HasColumnType("numeric(29, 15)");
            });

            modelBuilder.Entity<ZDashboardecEventosConRegaloCm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_EVENTOS_CON_REGALO_CM");

                entity.Property(e => e.CantidadEventos).HasColumnName("CANTIDAD_EVENTOS");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TipoEvento)
                    .IsRequired()
                    .HasColumnName("TIPO_EVENTO")
                    .HasMaxLength(100);

                entity.Property(e => e.UnidadesPorEvento).HasColumnName("UNIDADES_POR_EVENTO");
            });

            modelBuilder.Entity<ZDashboardecEventosRegaloT0ec>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_EVENTOS_REGALO_T0EC");

                entity.Property(e => e.CantidadEventos).HasColumnName("CANTIDAD_EVENTOS");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.TipoEvento)
                    .IsRequired()
                    .HasColumnName("TIPO_EVENTO")
                    .HasMaxLength(100);

                entity.Property(e => e.TipoLista)
                    .IsRequired()
                    .HasColumnName("TIPO_LISTA")
                    .HasMaxLength(50);

                entity.Property(e => e.UnidadesPorEvento)
                    .HasColumnName("UNIDADES_POR_EVENTO")
                    .HasColumnType("numeric(29, 15)");
            });

            modelBuilder.Entity<ZDashboardecEventosRegaloT0ecCm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_EVENTOS_REGALO_T0EC_CM");

                entity.Property(e => e.CantidadEventos).HasColumnName("CANTIDAD_EVENTOS");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TipoEvento)
                    .IsRequired()
                    .HasColumnName("TIPO_EVENTO")
                    .HasMaxLength(100);

                entity.Property(e => e.TipoLista)
                    .IsRequired()
                    .HasColumnName("TIPO_LISTA")
                    .HasMaxLength(50);

                entity.Property(e => e.UnidadesPorEvento).HasColumnName("UNIDADES_POR_EVENTO");
            });

            modelBuilder.Entity<ZDashboardecEventosregistrados>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_EVENTOSREGISTRADOS");

                entity.Property(e => e.EventosRegistrados).HasColumnName("EVENTOS_REGISTRADOS");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.TipoEvento)
                    .IsRequired()
                    .HasColumnName("TIPO_EVENTO")
                    .HasMaxLength(100);

                entity.Property(e => e.TipoLista)
                    .IsRequired()
                    .HasColumnName("TIPO_LISTA")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ZDashboardecEventosregistradosCm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_EVENTOSREGISTRADOS_CM");

                entity.Property(e => e.EventosRegistrados).HasColumnName("EVENTOS_REGISTRADOS");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TipoEvento)
                    .IsRequired()
                    .HasColumnName("TIPO_EVENTO")
                    .HasMaxLength(100);

                entity.Property(e => e.TipoLista)
                    .IsRequired()
                    .HasColumnName("TIPO_LISTA")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ZDashboardecTopskuCm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_TOPSKU_CM");

                entity.Property(e => e.Departamento)
                    .HasColumnName("DEPARTAMENTO")
                    .HasMaxLength(100);

                entity.Property(e => e.Expr1)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NombreSku)
                    .IsRequired()
                    .HasColumnName("NOMBRE_SKU")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Unidades).HasColumnName("UNIDADES");
            });

            modelBuilder.Entity<ZDashboardecTopskuLmtd>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_TOPSKU_LMTD");

                entity.Property(e => e.Departamento)
                    .HasColumnName("DEPARTAMENTO")
                    .HasMaxLength(100);

                entity.Property(e => e.Expr1)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.NombreSku)
                    .IsRequired()
                    .HasColumnName("NOMBRE_SKU")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Unidades).HasColumnName("UNIDADES");
            });

            modelBuilder.Entity<ZDashboardecTopskuLw>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_TOPSKU_LW");

                entity.Property(e => e.Departamento)
                    .HasColumnName("DEPARTAMENTO")
                    .HasMaxLength(100);

                entity.Property(e => e.Expr1)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NombreSku)
                    .IsRequired()
                    .HasColumnName("NOMBRE_SKU")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Unidades).HasColumnName("UNIDADES");
            });

            modelBuilder.Entity<ZDashboardecTopskuLymtd>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_TOPSKU_LYMTD");

                entity.Property(e => e.Departamento)
                    .HasColumnName("DEPARTAMENTO")
                    .HasMaxLength(100);

                entity.Property(e => e.Expr1)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.NombreSku)
                    .IsRequired()
                    .HasColumnName("NOMBRE_SKU")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Unidades).HasColumnName("UNIDADES");
            });

            modelBuilder.Entity<ZDashboardecTopskuMtd>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_TOPSKU_MTD");

                entity.Property(e => e.Departamento)
                    .HasColumnName("DEPARTAMENTO")
                    .HasMaxLength(100);

                entity.Property(e => e.Expr1)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.NombreSku)
                    .IsRequired()
                    .HasColumnName("NOMBRE_SKU")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Unidades).HasColumnName("UNIDADES");
            });

            modelBuilder.Entity<ZDashboardecVentasTiendaInternet>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_VENTAS_TIENDA_INTERNET");

                entity.Property(e => e.Monto)
                    .HasColumnName("MONTO")
                    .HasColumnType("money");

                entity.Property(e => e.Origen)
                    .IsRequired()
                    .HasColumnName("ORIGEN")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Pedidos).HasColumnName("PEDIDOS");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZDashboardecVentasTiendaInternetCm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_DASHBOARDEC_VENTAS_TIENDA_INTERNET_CM");

                entity.Property(e => e.Monto)
                    .HasColumnName("MONTO")
                    .HasColumnType("money");

                entity.Property(e => e.Origen)
                    .IsRequired()
                    .HasColumnName("ORIGEN")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Pedidos).HasColumnName("PEDIDOS");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("PERIODO")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZEncabezadoEnvio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Z_ENCABEZADO_ENVIO");

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("ID_Envio")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<ZEventoBebe>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_EVENTO_BEBE");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnName("FECHA_REGISTRO")
                    .HasColumnType("datetime");

                entity.Property(e => e.TarjetaPrivilegio)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZEventosBdBodas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_EVENTOS_BD_BODAS");

                entity.Property(e => e.Apellidonovia1)
                    .IsRequired()
                    .HasColumnName("APELLIDONOVIA1")
                    .HasMaxLength(50);

                entity.Property(e => e.Apellidonovia2)
                    .IsRequired()
                    .HasColumnName("APELLIDONOVIA2")
                    .HasMaxLength(50);

                entity.Property(e => e.Apellidonovio1)
                    .IsRequired()
                    .HasColumnName("APELLIDONOVIO1")
                    .HasMaxLength(50);

                entity.Property(e => e.Apellidonovio2)
                    .IsRequired()
                    .HasColumnName("APELLIDONOVIO2")
                    .HasMaxLength(50);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(250);

                entity.Property(e => e.Emailnovia)
                    .IsRequired()
                    .HasColumnName("EMAILNOVIA")
                    .HasMaxLength(100);

                entity.Property(e => e.Emailnovio)
                    .IsRequired()
                    .HasColumnName("EMAILNOVIO")
                    .HasMaxLength(100);

                entity.Property(e => e.Evento)
                    .IsRequired()
                    .HasColumnName("EVENTO")
                    .HasMaxLength(25);

                entity.Property(e => e.FechaEvento)
                    .HasColumnName("FECHA_EVENTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnName("FECHA_REGISTRO")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nombrenovia1)
                    .IsRequired()
                    .HasColumnName("NOMBRENOVIA1")
                    .HasMaxLength(100);

                entity.Property(e => e.Nombrenovia2)
                    .IsRequired()
                    .HasColumnName("NOMBRENOVIA2")
                    .HasMaxLength(50);

                entity.Property(e => e.Nombrenovio1)
                    .IsRequired()
                    .HasColumnName("NOMBRENOVIO1")
                    .HasMaxLength(100);

                entity.Property(e => e.Nombrenovio2)
                    .IsRequired()
                    .HasColumnName("NOMBRENOVIO2")
                    .HasMaxLength(50);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasColumnName("TELEFONO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TiendaRegistro)
                    .IsRequired()
                    .HasColumnName("TIENDA_REGISTRO")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<ZTblEmailEnvio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("z_tbl_email_envio");

                entity.HasIndex(e => new { e.IdEnvio, e.IdRuta })
                    .HasName("IX_z_tbl_email_envio");

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("ID_Envio")
                    .HasMaxLength(50);

                entity.Property(e => e.IdRuta)
                    .HasColumnName("ID_Ruta")
                    .HasMaxLength(40)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ZVwBwEventos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_VW_BW_EVENTOS");

                entity.Property(e => e.FechaDeInscripción)
                    .HasColumnName("FECHA DE INSCRIPCIÓN")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FechaLista)
                    .HasColumnName("FECHA LISTA")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdAsesora)
                    .HasColumnName("ID ASESORA")
                    .HasMaxLength(50);

                entity.Property(e => e.IdAsociado)
                    .HasColumnName("ID_asociado")
                    .HasMaxLength(25);

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("ID EVENTO")
                    .HasMaxLength(25);

                entity.Property(e => e.Lista)
                    .IsRequired()
                    .HasColumnName("LISTA")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TiendaRegistro)
                    .IsRequired()
                    .HasColumnName("TIENDA REGISTRO")
                    .HasMaxLength(10);

                entity.Property(e => e.TipoAsesora)
                    .IsRequired()
                    .HasColumnName("TIPO ASESORA")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.TipoEvento).HasColumnName("TIPO EVENTO");

                entity.Property(e => e.TipoLista)
                    .HasColumnName("TIPO LISTA")
                    .HasMaxLength(50);

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasColumnName("TITULO")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZtblAnalisisDatos2018>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ztbl_analisis_datos_2018");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("id_evento")
                    .HasMaxLength(25);

                entity.Property(e => e.MontoTotal).HasColumnType("money");

                entity.Property(e => e.Precio)
                    .HasColumnName("precio")
                    .HasColumnType("money");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("sku")
                    .HasMaxLength(25);

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasColumnName("titulo")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZtblAnalisisDatos2019>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ztbl_analisis_datos_2019");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("id_evento")
                    .HasMaxLength(25);

                entity.Property(e => e.MontoTotal).HasColumnType("money");

                entity.Property(e => e.Precio)
                    .HasColumnName("precio")
                    .HasColumnType("money");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("sku")
                    .HasMaxLength(25);

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasColumnName("titulo")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZtblBeneficiosbodas>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ztbl_beneficiosbodas");

                entity.Property(e => e.CodTipo).HasColumnName("cod_tipo");

                entity.Property(e => e.IdAsociado)
                    .IsRequired()
                    .HasColumnName("id_asociado")
                    .HasMaxLength(25);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50);

                entity.Property(e => e.NumTarjeta)
                    .HasColumnName("num_tarjeta")
                    .HasMaxLength(13);

                entity.Property(e => e.Puntos).HasColumnType("money");
            });

            modelBuilder.Entity<ZtblBkTblUbicfisicaCl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZTBL_BK_TBL_UBICFISICA_CL");

                entity.Property(e => e.CodDepartamento).HasColumnName("Cod_Departamento");

                entity.Property(e => e.CodMunicipio).HasColumnName("Cod_Municipio");

                entity.Property(e => e.CodPais)
                    .IsRequired()
                    .HasColumnName("Cod_Pais")
                    .HasMaxLength(5);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasColumnName("Cod_Ubicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.Db)
                    .HasColumnName("DB")
                    .HasMaxLength(50);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.FechaBorrado)
                    .HasColumnName("Fecha_borrado")
                    .HasColumnType("datetime");

                entity.Property(e => e.MailIntercambio).HasMaxLength(100);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PermRecorrido)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PermiteEnvioBoda)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PermiteEnvioBodaReg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PermiteEnvioCs)
                    .HasColumnName("PermiteEnvioCS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PermiteEnvioDom)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PwdDb)
                    .HasColumnName("PwdDB")
                    .HasMaxLength(250);

                entity.Property(e => e.ServidorDb)
                    .HasColumnName("ServidorDB")
                    .HasMaxLength(50);

                entity.Property(e => e.Telefonos)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UsrDb)
                    .HasColumnName("UsrDB")
                    .HasMaxLength(50);

                entity.Property(e => e.ValDesp)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Zona)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ZtblCorrigeprecio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ztbl_corrigeprecio");

                entity.Property(e => e.Caja)
                    .IsRequired()
                    .HasColumnName("caja")
                    .HasMaxLength(5);

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasColumnName("cod_ubicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.Comprador)
                    .IsRequired()
                    .HasColumnName("comprador")
                    .HasMaxLength(100);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(350);

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("id_envio")
                    .HasMaxLength(25);

                entity.Property(e => e.Precio)
                    .HasColumnName("precio")
                    .HasColumnType("money");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("sku")
                    .HasMaxLength(25);

                entity.Property(e => e.Transaccion)
                    .IsRequired()
                    .HasColumnName("transaccion")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<ZtblCorrigeprecio1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ztbl_corrigeprecio1");

                entity.Property(e => e.Caja)
                    .IsRequired()
                    .HasColumnName("caja")
                    .HasMaxLength(5);

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("id_envio")
                    .HasMaxLength(25);

                entity.Property(e => e.Idtributario)
                    .IsRequired()
                    .HasColumnName("idtributario")
                    .HasMaxLength(15);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(100);

                entity.Property(e => e.Preciodesc)
                    .HasColumnName("preciodesc")
                    .HasColumnType("money");

                entity.Property(e => e.Sku)
                    .HasColumnName("sku")
                    .HasMaxLength(25);

                entity.Property(e => e.StatusDet)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StatusFact)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Transaccion)
                    .IsRequired()
                    .HasColumnName("transaccion")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<ZtblEncVentasAcumuladas>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZTBL_ENC_VentasAcumuladas");

                entity.Property(e => e.Caja).HasMaxLength(5);

                entity.Property(e => e.CodTienda)
                    .HasColumnName("Cod_Tienda")
                    .HasMaxLength(10);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.IdEvento)
                    .HasColumnName("ID_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.Transaccion).HasMaxLength(25);
            });

            modelBuilder.Entity<ZtblEnvio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ztbl_envio");

                entity.Property(e => e.Caja)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.CodArea).HasColumnName("Cod_Area");

                entity.Property(e => e.CodTipoPago).HasColumnName("Cod_TipoPago");

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasColumnName("Cod_Ubicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.Comprador)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("ID_Envio")
                    .HasMaxLength(25);

                entity.Property(e => e.IdEvento)
                    .HasColumnName("ID_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.IdPersonal)
                    .IsRequired()
                    .HasColumnName("Id_Personal")
                    .HasMaxLength(25);

                entity.Property(e => e.MailEntrega).HasMaxLength(50);

                entity.Property(e => e.Observaciones).HasMaxLength(1000);

                entity.Property(e => e.PorInternet)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sobre).HasMaxLength(25);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TelEntrega).HasMaxLength(50);

                entity.Property(e => e.Transaccion)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<ZtblEnvioerrasociacionjra>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ztbl_envioerrasociacionjra");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("ID_Envio")
                    .HasMaxLength(25);

                entity.Property(e => e.Mensaje)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<ZtblEvento20160908>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZTBL_EVENTO20160908");

                entity.Property(e => e.AcreditaPuntos)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodArea).HasColumnName("Cod_Area");

                entity.Property(e => e.CodAreaMo).HasColumnName("Cod_AreaMo");

                entity.Property(e => e.CodDepartamento).HasColumnName("Cod_Departamento");

                entity.Property(e => e.CodDepartamentoMo).HasColumnName("Cod_DepartamentoMo");

                entity.Property(e => e.CodMunicipio).HasColumnName("Cod_Municipio");

                entity.Property(e => e.CodMunicipioMo).HasColumnName("Cod_MunicipioMo");

                entity.Property(e => e.CodPais)
                    .HasColumnName("Cod_Pais")
                    .HasMaxLength(5);

                entity.Property(e => e.CodPaisMo)
                    .HasColumnName("Cod_PaisMo")
                    .HasMaxLength(5);

                entity.Property(e => e.CodTiendaLiq)
                    .HasColumnName("Cod_TiendaLiq")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTipoLista).HasColumnName("Cod_TipoLista");

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasColumnName("Cod_Ubicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.CodUbicacionEnt)
                    .HasColumnName("Cod_UbicacionEnt")
                    .HasMaxLength(10);

                entity.Property(e => e.CodUbicacionEntMo)
                    .HasColumnName("Cod_UbicacionEntMo")
                    .HasMaxLength(10);

                entity.Property(e => e.CodUbicacionLista)
                    .IsRequired()
                    .HasColumnName("Cod_UbicacionLista")
                    .HasMaxLength(10);

                entity.Property(e => e.ColorMo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.DireccionMo).HasMaxLength(100);

                entity.Property(e => e.DireccionPostBoda)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.Ecologico)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaEvento).HasColumnType("datetime");

                entity.Property(e => e.FechaLista).HasColumnType("datetime");

                entity.Property(e => e.FechaMonia).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.GeoRefXmo).HasColumnName("GeoRefXMo");

                entity.Property(e => e.GeoRefYmo).HasColumnName("GeoRefYMo");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("Id_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.IdPersonal)
                    .IsRequired()
                    .HasColumnName("Id_Personal")
                    .HasMaxLength(50);

                entity.Property(e => e.Pwdinternet)
                    .IsRequired()
                    .HasColumnName("PWDInternet")
                    .HasMaxLength(50);

                entity.Property(e => e.Referencias).HasMaxLength(100);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StatusMonia)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TarjetaPrivilegio)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoMo).HasMaxLength(50);

                entity.Property(e => e.TelefonoPostBoda)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TipoLentrega).HasColumnName("Tipo_LEntrega");

                entity.Property(e => e.TipoLentregaMo).HasColumnName("Tipo_LEntregaMo");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Zona).HasMaxLength(50);

                entity.Property(e => e.ZonaMo).HasMaxLength(50);
            });

            modelBuilder.Entity<ZtblEvento2017090093>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ztbl_evento_201709_0093");

                entity.Property(e => e.AcreditaPuntos)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodArea).HasColumnName("Cod_Area");

                entity.Property(e => e.CodAreaMo).HasColumnName("Cod_AreaMo");

                entity.Property(e => e.CodDepartamento).HasColumnName("Cod_Departamento");

                entity.Property(e => e.CodDepartamentoMo).HasColumnName("Cod_DepartamentoMo");

                entity.Property(e => e.CodMunicipio).HasColumnName("Cod_Municipio");

                entity.Property(e => e.CodMunicipioMo).HasColumnName("Cod_MunicipioMo");

                entity.Property(e => e.CodPais)
                    .HasColumnName("Cod_Pais")
                    .HasMaxLength(5);

                entity.Property(e => e.CodPaisMo)
                    .HasColumnName("Cod_PaisMo")
                    .HasMaxLength(5);

                entity.Property(e => e.CodTiendaLiq)
                    .HasColumnName("Cod_TiendaLiq")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTipoLista).HasColumnName("Cod_TipoLista");

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasColumnName("Cod_Ubicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.CodUbicacionEnt)
                    .HasColumnName("Cod_UbicacionEnt")
                    .HasMaxLength(10);

                entity.Property(e => e.CodUbicacionEntMo)
                    .HasColumnName("Cod_UbicacionEntMo")
                    .HasMaxLength(10);

                entity.Property(e => e.CodUbicacionLista)
                    .IsRequired()
                    .HasColumnName("Cod_UbicacionLista")
                    .HasMaxLength(10);

                entity.Property(e => e.ColorMo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.DireccionMo).HasMaxLength(100);

                entity.Property(e => e.DireccionPostBoda)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.Ecologico)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaEvento).HasColumnType("datetime");

                entity.Property(e => e.FechaLiq).HasColumnType("datetime");

                entity.Property(e => e.FechaLista).HasColumnType("datetime");

                entity.Property(e => e.FechaMonia).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.GeoRefXmo).HasColumnName("GeoRefXMo");

                entity.Property(e => e.GeoRefYmo).HasColumnName("GeoRefYMo");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("Id_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.IdPersonal)
                    .IsRequired()
                    .HasColumnName("Id_Personal")
                    .HasMaxLength(50);

                entity.Property(e => e.IdPersonalLiq)
                    .HasColumnName("ID_PersonalLiq")
                    .HasMaxLength(40);

                entity.Property(e => e.IdPersonalRec)
                    .HasColumnName("ID_PersonalRec")
                    .HasMaxLength(40);

                entity.Property(e => e.Pwdinternet)
                    .IsRequired()
                    .HasColumnName("PWDInternet")
                    .HasMaxLength(50);

                entity.Property(e => e.Referencias).HasMaxLength(100);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StatusMonia)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TarjetaPrivilegio)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoMo).HasMaxLength(50);

                entity.Property(e => e.TelefonoPostBoda)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TipoLentrega).HasColumnName("Tipo_LEntrega");

                entity.Property(e => e.TipoLentregaMo).HasColumnName("Tipo_LEntregaMo");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Zona).HasMaxLength(50);

                entity.Property(e => e.ZonaMo).HasMaxLength(50);
            });

            modelBuilder.Entity<ZtblEventocertregalo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ztbl_eventocertregalo");

                entity.Property(e => e.Certificado).HasMaxLength(50);

                entity.Property(e => e.CertificadoBenef).HasMaxLength(50);

                entity.Property(e => e.CodBeneficioC)
                    .HasColumnName("Cod_BeneficioC")
                    .HasMaxLength(10);

                entity.Property(e => e.CodBeneficioH)
                    .HasColumnName("Cod_BeneficioH")
                    .HasMaxLength(10);

                entity.Property(e => e.CodUbicacionEnt)
                    .HasColumnName("Cod_UbicacionEnt")
                    .HasMaxLength(10);

                entity.Property(e => e.CodUbicacionLiq)
                    .HasColumnName("Cod_UbicacionLiq")
                    .HasMaxLength(10);

                entity.Property(e => e.CuponC).HasMaxLength(25);

                entity.Property(e => e.CuponH).HasMaxLength(25);

                entity.Property(e => e.FechaCerfBenef).HasColumnType("datetime");

                entity.Property(e => e.FechaEntrega).HasColumnType("datetime");

                entity.Property(e => e.FechaLiq).HasColumnType("datetime");

                entity.Property(e => e.IdCajaLiq)
                    .HasColumnName("ID_CajaLiq")
                    .HasMaxLength(10);

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("ID_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.IdUsuarioCertBenef)
                    .HasColumnName("ID_UsuarioCertBenef")
                    .HasMaxLength(40);

                entity.Property(e => e.IdUsuarioEnt)
                    .HasColumnName("ID_UsuarioEnt")
                    .HasMaxLength(40);

                entity.Property(e => e.IdUsuarioLiq)
                    .HasColumnName("ID_UsuarioLiq")
                    .HasMaxLength(40);

                entity.Property(e => e.Nitnc)
                    .IsRequired()
                    .HasColumnName("NITNC")
                    .HasMaxLength(15);

                entity.Property(e => e.NombreNc)
                    .IsRequired()
                    .HasColumnName("NombreNC")
                    .HasMaxLength(50);

                entity.Property(e => e.TotalRegalos).HasColumnType("money");
            });

            modelBuilder.Entity<ZtblEventopruebas>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ztbl_eventopruebas");

                entity.Property(e => e.AcreditaPuntos)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodArea).HasColumnName("Cod_Area");

                entity.Property(e => e.CodAreaMo).HasColumnName("Cod_AreaMo");

                entity.Property(e => e.CodDepartamento).HasColumnName("Cod_Departamento");

                entity.Property(e => e.CodDepartamentoMo).HasColumnName("Cod_DepartamentoMo");

                entity.Property(e => e.CodMunicipio).HasColumnName("Cod_Municipio");

                entity.Property(e => e.CodMunicipioMo).HasColumnName("Cod_MunicipioMo");

                entity.Property(e => e.CodPais)
                    .HasColumnName("Cod_Pais")
                    .HasMaxLength(5);

                entity.Property(e => e.CodPaisMo)
                    .HasColumnName("Cod_PaisMo")
                    .HasMaxLength(5);

                entity.Property(e => e.CodTiendaLiq)
                    .HasColumnName("Cod_TiendaLiq")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTipoLista).HasColumnName("Cod_TipoLista");

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasColumnName("Cod_Ubicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.CodUbicacionEnt)
                    .HasColumnName("Cod_UbicacionEnt")
                    .HasMaxLength(10);

                entity.Property(e => e.CodUbicacionEntMo)
                    .HasColumnName("Cod_UbicacionEntMo")
                    .HasMaxLength(10);

                entity.Property(e => e.CodUbicacionLista)
                    .IsRequired()
                    .HasColumnName("Cod_UbicacionLista")
                    .HasMaxLength(10);

                entity.Property(e => e.ColorMo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.DireccionMo).HasMaxLength(100);

                entity.Property(e => e.DireccionPostBoda)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.Ecologico)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaEvento).HasColumnType("datetime");

                entity.Property(e => e.FechaLiq).HasColumnType("datetime");

                entity.Property(e => e.FechaLista).HasColumnType("datetime");

                entity.Property(e => e.FechaMonia).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.GeoRefXmo).HasColumnName("GeoRefXMo");

                entity.Property(e => e.GeoRefYmo).HasColumnName("GeoRefYMo");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("Id_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.IdPersonal)
                    .IsRequired()
                    .HasColumnName("Id_Personal")
                    .HasMaxLength(50);

                entity.Property(e => e.IdPersonalLiq)
                    .HasColumnName("ID_PersonalLiq")
                    .HasMaxLength(40);

                entity.Property(e => e.IdPersonalRec)
                    .HasColumnName("ID_PersonalRec")
                    .HasMaxLength(40);

                entity.Property(e => e.Pwdinternet)
                    .IsRequired()
                    .HasColumnName("PWDInternet")
                    .HasMaxLength(50);

                entity.Property(e => e.Referencias).HasMaxLength(100);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StatusMonia)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TarjetaPrivilegio)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoMo).HasMaxLength(50);

                entity.Property(e => e.TelefonoPostBoda)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TipoLentrega).HasColumnName("Tipo_LEntrega");

                entity.Property(e => e.TipoLentregaMo).HasColumnName("Tipo_LEntregaMo");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Zona).HasMaxLength(50);

                entity.Property(e => e.ZonaMo).HasMaxLength(50);
            });

            modelBuilder.Entity<ZtblEventosliquidados>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ztbl_eventosliquidados");

                entity.Property(e => e.Certificado)
                    .HasColumnName("certificado")
                    .HasMaxLength(50);

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("id_evento")
                    .HasMaxLength(25);

                entity.Property(e => e.MontoTarjeta).HasColumnType("money");
            });

            modelBuilder.Entity<ZtblPersonaevento2017090093>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ztbl_personaevento_201709_0093");

                entity.Property(e => e.Apellido1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Apellido2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Celular)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CodTipoCont).HasColumnName("Cod_TipoCont");

                entity.Property(e => e.CodTipoIdent).HasColumnName("Cod_TipoIdent");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMail")
                    .HasMaxLength(100);

                entity.Property(e => e.Fax)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FechaNac).HasColumnType("datetime");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("Id_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.Nombre1)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Nombre2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NumeroId)
                    .IsRequired()
                    .HasColumnName("NumeroID")
                    .HasMaxLength(100);

                entity.Property(e => e.RecMonia)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RecRegalos)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SerieId)
                    .IsRequired()
                    .HasColumnName("SerieID")
                    .HasMaxLength(10);

                entity.Property(e => e.TelOficina)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ZtblPersonalBk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ztbl_personal_BK");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Fax)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.IdPersonal)
                    .IsRequired()
                    .HasColumnName("Id_Personal")
                    .HasMaxLength(25);

                entity.Property(e => e.NomImpresion).HasMaxLength(100);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Puesto)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ZtblTeAgarre>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Ztbl_TeAgarre");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.Terminal)
                    .HasColumnName("terminal")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Usuario)
                    .HasColumnName("usuario")
                    .HasMaxLength(20)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ZtblVentasAcumuladas>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZTBL_VentasAcumuladas");

                entity.Property(e => e.ArticulosAbril).HasColumnName("Articulos Abril");

                entity.Property(e => e.ArticulosAcumulados).HasColumnName("Articulos Acumulados");

                entity.Property(e => e.ArticulosAgosto).HasColumnName("Articulos Agosto");

                entity.Property(e => e.ArticulosDiciembre).HasColumnName("Articulos Diciembre");

                entity.Property(e => e.ArticulosEnero).HasColumnName("Articulos Enero");

                entity.Property(e => e.ArticulosFebrero).HasColumnName("Articulos Febrero");

                entity.Property(e => e.ArticulosJulio).HasColumnName("Articulos Julio");

                entity.Property(e => e.ArticulosJunio).HasColumnName("Articulos Junio");

                entity.Property(e => e.ArticulosMarzo).HasColumnName("Articulos Marzo");

                entity.Property(e => e.ArticulosMayo).HasColumnName("Articulos Mayo");

                entity.Property(e => e.ArticulosNoviembre).HasColumnName("Articulos Noviembre");

                entity.Property(e => e.ArticulosOctubre).HasColumnName("Articulos Octubre");

                entity.Property(e => e.ArticulosSeptiembre).HasColumnName("Articulos Septiembre");

                entity.Property(e => e.CodTienda)
                    .IsRequired()
                    .HasColumnName("Cod_Tienda")
                    .HasMaxLength(10);

                entity.Property(e => e.FacturasAbril).HasColumnName("Facturas Abril");

                entity.Property(e => e.FacturasAcumuladas).HasColumnName("Facturas Acumuladas");

                entity.Property(e => e.FacturasAgosto).HasColumnName("Facturas Agosto");

                entity.Property(e => e.FacturasDiciembre).HasColumnName("Facturas Diciembre");

                entity.Property(e => e.FacturasEnero).HasColumnName("Facturas Enero");

                entity.Property(e => e.FacturasFebrero).HasColumnName("Facturas Febrero");

                entity.Property(e => e.FacturasJulio).HasColumnName("Facturas Julio");

                entity.Property(e => e.FacturasJunio).HasColumnName("Facturas Junio");

                entity.Property(e => e.FacturasMarzo).HasColumnName("Facturas Marzo");

                entity.Property(e => e.FacturasMayo).HasColumnName("Facturas Mayo");

                entity.Property(e => e.FacturasNoviembre).HasColumnName("Facturas Noviembre");

                entity.Property(e => e.FacturasOctubre).HasColumnName("Facturas Octubre");

                entity.Property(e => e.FacturasSeptiembre).HasColumnName("Facturas Septiembre");

                entity.Property(e => e.VentaAbril)
                    .HasColumnName("Venta Abril")
                    .HasColumnType("money");

                entity.Property(e => e.VentaAcumulada)
                    .HasColumnName("Venta Acumulada")
                    .HasColumnType("money");

                entity.Property(e => e.VentaAgosto)
                    .HasColumnName("Venta Agosto")
                    .HasColumnType("money");

                entity.Property(e => e.VentaDiciembre)
                    .HasColumnName("Venta Diciembre")
                    .HasColumnType("money");

                entity.Property(e => e.VentaEnero)
                    .HasColumnName("Venta Enero")
                    .HasColumnType("money");

                entity.Property(e => e.VentaFebrero)
                    .HasColumnName("Venta Febrero")
                    .HasColumnType("money");

                entity.Property(e => e.VentaJulio)
                    .HasColumnName("Venta Julio")
                    .HasColumnType("money");

                entity.Property(e => e.VentaJunio)
                    .HasColumnName("Venta Junio")
                    .HasColumnType("money");

                entity.Property(e => e.VentaMarzo)
                    .HasColumnName("Venta Marzo")
                    .HasColumnType("money");

                entity.Property(e => e.VentaMayo)
                    .HasColumnName("Venta Mayo")
                    .HasColumnType("money");

                entity.Property(e => e.VentaNoviembre)
                    .HasColumnName("Venta Noviembre")
                    .HasColumnType("money");

                entity.Property(e => e.VentaOctubre)
                    .HasColumnName("Venta Octubre")
                    .HasColumnType("money");

                entity.Property(e => e.VentaSeptiembre)
                    .HasColumnName("Venta Septiembre")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<ZtmpBodasEcommNoEmail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ztmp_BodasEcommNoEmail");

                entity.Property(e => e.Fechaevento)
                    .HasColumnName("fechaevento")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("id_evento")
                    .HasMaxLength(25);

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<ZtmpBodasEcommerceCargadas>(entity =>
            {
                entity.HasKey(e => e.Correl);

                entity.ToTable("ztmp_BodasEcommerceCargadas");

                entity.Property(e => e.Correl)
                    .HasColumnName("correl")
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCarga)
                    .HasColumnName("fechaCarga")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdEvento)
                    .HasColumnName("id_evento")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<ZtmpBodasregalos20142015>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ztmp_bodasregalos_20142015");

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasColumnName("cod_ubicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.FechaEvento).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.Property(e => e.NombreDelEvento)
                    .HasColumnName("Nombre_del_Evento")
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZtmpConlista>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ztmp_conlista");

                entity.Property(e => e.ConLista)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("id_evento")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<ZtmpDetalleregalos2010Fecha>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ztmp_detalleregalos_2010_Fecha");

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(50);

                entity.Property(e => e.Fechaevento)
                    .HasColumnName("fechaevento")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("id_evento")
                    .HasMaxLength(25);

                entity.Property(e => e.NombreEvento)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Precio)
                    .HasColumnName("precio")
                    .HasColumnType("money");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("sku")
                    .HasMaxLength(50);

                entity.Property(e => e.Solicitado).HasColumnName("solicitado");
            });

            modelBuilder.Entity<ZtmpEcommerceDatosNovios>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ztmp_ecommerceDatosNovios");

                entity.Property(e => e.Fechaevento)
                    .HasColumnName("fechaevento")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("id_evento")
                    .HasMaxLength(25);

                entity.Property(e => e.Nombretarjeta)
                    .HasColumnName("nombretarjeta")
                    .HasMaxLength(50);

                entity.Property(e => e.Novia)
                    .HasColumnName("novia")
                    .HasMaxLength(253);

                entity.Property(e => e.Novio)
                    .HasColumnName("novio")
                    .HasMaxLength(253);

                entity.Property(e => e.Procesado)
                    .IsRequired()
                    .HasColumnName("procesado")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Tarjetaprivilegio)
                    .IsRequired()
                    .HasColumnName("tarjetaprivilegio")
                    .HasMaxLength(50);

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasColumnName("titulo")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZtmpEcommerceDatosNovios071119>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ztmp_ecommerceDatosNovios071119");

                entity.Property(e => e.Fechaevento)
                    .HasColumnName("fechaevento")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("id_evento")
                    .HasMaxLength(25);

                entity.Property(e => e.Nombretarjeta)
                    .HasColumnName("nombretarjeta")
                    .HasMaxLength(50);

                entity.Property(e => e.Novia)
                    .HasColumnName("novia")
                    .HasMaxLength(253);

                entity.Property(e => e.Novio)
                    .HasColumnName("novio")
                    .HasMaxLength(253);

                entity.Property(e => e.Procesado)
                    .IsRequired()
                    .HasColumnName("procesado")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Tarjetaprivilegio)
                    .IsRequired()
                    .HasColumnName("tarjetaprivilegio")
                    .HasMaxLength(50);

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasColumnName("titulo")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZtmpEcommerceNoviosEmail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ztmp_EcommerceNoviosEmail");

                entity.Property(e => e.CodTipoCont).HasColumnName("Cod_TipoCont");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100);

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("id_evento")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<ZtmpEcommerceNoviosEmail2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ztmp_EcommerceNoviosEmail2");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100);

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("id_evento")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<ZtmpEnvio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ztmp_envio");

                entity.Property(e => e.Caja)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.CodArea).HasColumnName("Cod_Area");

                entity.Property(e => e.CodTipoPago).HasColumnName("Cod_TipoPago");

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasColumnName("Cod_Ubicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.Comprador)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("ID_Envio")
                    .HasMaxLength(25);

                entity.Property(e => e.IdEvento)
                    .HasColumnName("ID_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.IdPersonal)
                    .IsRequired()
                    .HasColumnName("Id_Personal")
                    .HasMaxLength(25);

                entity.Property(e => e.MailEntrega).HasMaxLength(50);

                entity.Property(e => e.Observaciones).HasMaxLength(1000);

                entity.Property(e => e.PorInternet)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sobre).HasMaxLength(25);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TelEntrega).HasMaxLength(50);

                entity.Property(e => e.Transaccion)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<ZtmpEnvioCc07>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ztmp_envio_cc07");

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasColumnName("cod_ubicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("id_envio")
                    .HasMaxLength(25);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ZtmpEnvionc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ztmp_envionc");

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasColumnName("Cod_Ubicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaGrab).HasColumnType("datetime");

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("Id_Envio")
                    .HasMaxLength(25);

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("ID_Usuario")
                    .HasMaxLength(40);

                entity.Property(e => e.Nit)
                    .IsRequired()
                    .HasColumnName("NIT")
                    .HasMaxLength(15);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Nota)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<ZtmpEnviosLiquidacion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Ztmp_EnviosLiquidacion");

                entity.Property(e => e.CantidadEnvios).HasColumnName("Cantidad_Envios");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("id_evento")
                    .HasMaxLength(25);

                entity.Property(e => e.MontoEnvios)
                    .HasColumnName("Monto_Envios")
                    .HasColumnType("money");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasColumnName("titulo")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZtmpEventoBackupBabyshower>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ztmp_eventoBACKUP_BABYSHOWER");

                entity.Property(e => e.AcreditaPuntos)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodArea).HasColumnName("Cod_Area");

                entity.Property(e => e.CodAreaMo).HasColumnName("Cod_AreaMo");

                entity.Property(e => e.CodDepartamento).HasColumnName("Cod_Departamento");

                entity.Property(e => e.CodDepartamentoMo).HasColumnName("Cod_DepartamentoMo");

                entity.Property(e => e.CodMunicipio).HasColumnName("Cod_Municipio");

                entity.Property(e => e.CodMunicipioMo).HasColumnName("Cod_MunicipioMo");

                entity.Property(e => e.CodPais)
                    .HasColumnName("Cod_Pais")
                    .HasMaxLength(5);

                entity.Property(e => e.CodPaisMo)
                    .HasColumnName("Cod_PaisMo")
                    .HasMaxLength(5);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTipoLista).HasColumnName("Cod_TipoLista");

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasColumnName("Cod_Ubicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.CodUbicacionEnt)
                    .HasColumnName("Cod_UbicacionEnt")
                    .HasMaxLength(10);

                entity.Property(e => e.CodUbicacionEntMo)
                    .HasColumnName("Cod_UbicacionEntMo")
                    .HasMaxLength(10);

                entity.Property(e => e.CodUbicacionLista)
                    .IsRequired()
                    .HasColumnName("Cod_UbicacionLista")
                    .HasMaxLength(10);

                entity.Property(e => e.ColorMo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.DireccionMo).HasMaxLength(100);

                entity.Property(e => e.DireccionPostBoda)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.FechaEvento).HasColumnType("datetime");

                entity.Property(e => e.FechaLista).HasColumnType("datetime");

                entity.Property(e => e.FechaMonia).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.GeoRefXmo).HasColumnName("GeoRefXMo");

                entity.Property(e => e.GeoRefYmo).HasColumnName("GeoRefYMo");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("Id_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.IdPersonal)
                    .IsRequired()
                    .HasColumnName("Id_Personal")
                    .HasMaxLength(50);

                entity.Property(e => e.Pwdinternet)
                    .IsRequired()
                    .HasColumnName("PWDInternet")
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StatusMonia)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TarjetaPrivilegio)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoMo).HasMaxLength(50);

                entity.Property(e => e.TelefonoPostBoda)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TipoLentrega).HasColumnName("Tipo_LEntrega");

                entity.Property(e => e.TipoLentregaMo).HasColumnName("Tipo_LEntregaMo");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Zona).HasMaxLength(50);

                entity.Property(e => e.ZonaMo).HasMaxLength(50);
            });

            modelBuilder.Entity<ZtmpEventoHernandez>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ztmp_eventoHernandez");

                entity.Property(e => e.AcreditaPuntos)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodArea).HasColumnName("Cod_Area");

                entity.Property(e => e.CodAreaMo).HasColumnName("Cod_AreaMo");

                entity.Property(e => e.CodDepartamento).HasColumnName("Cod_Departamento");

                entity.Property(e => e.CodDepartamentoMo).HasColumnName("Cod_DepartamentoMo");

                entity.Property(e => e.CodMunicipio).HasColumnName("Cod_Municipio");

                entity.Property(e => e.CodMunicipioMo).HasColumnName("Cod_MunicipioMo");

                entity.Property(e => e.CodPais)
                    .HasColumnName("Cod_Pais")
                    .HasMaxLength(5);

                entity.Property(e => e.CodPaisMo)
                    .HasColumnName("Cod_PaisMo")
                    .HasMaxLength(5);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTipoLista).HasColumnName("Cod_TipoLista");

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasColumnName("Cod_Ubicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.CodUbicacionEnt)
                    .HasColumnName("Cod_UbicacionEnt")
                    .HasMaxLength(10);

                entity.Property(e => e.CodUbicacionEntMo)
                    .HasColumnName("Cod_UbicacionEntMo")
                    .HasMaxLength(10);

                entity.Property(e => e.CodUbicacionLista)
                    .IsRequired()
                    .HasColumnName("Cod_UbicacionLista")
                    .HasMaxLength(10);

                entity.Property(e => e.ColorMo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.DireccionMo).HasMaxLength(100);

                entity.Property(e => e.DireccionPostBoda)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.FechaEvento).HasColumnType("datetime");

                entity.Property(e => e.FechaLista).HasColumnType("datetime");

                entity.Property(e => e.FechaMonia).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.GeoRefXmo).HasColumnName("GeoRefXMo");

                entity.Property(e => e.GeoRefYmo).HasColumnName("GeoRefYMo");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("Id_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.IdPersonal)
                    .IsRequired()
                    .HasColumnName("Id_Personal")
                    .HasMaxLength(50);

                entity.Property(e => e.Pwdinternet)
                    .IsRequired()
                    .HasColumnName("PWDInternet")
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StatusMonia)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TarjetaPrivilegio)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoMo).HasMaxLength(50);

                entity.Property(e => e.TelefonoPostBoda)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TipoLentrega).HasColumnName("Tipo_LEntrega");

                entity.Property(e => e.TipoLentregaMo).HasColumnName("Tipo_LEntregaMo");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Zona).HasMaxLength(50);

                entity.Property(e => e.ZonaMo).HasMaxLength(50);
            });

            modelBuilder.Entity<ZtmpEventoPopaSacor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ztmp_evento_popa_sacor");

                entity.Property(e => e.AcreditaPuntos)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodArea).HasColumnName("Cod_Area");

                entity.Property(e => e.CodAreaMo).HasColumnName("Cod_AreaMo");

                entity.Property(e => e.CodDepartamento).HasColumnName("Cod_Departamento");

                entity.Property(e => e.CodDepartamentoMo).HasColumnName("Cod_DepartamentoMo");

                entity.Property(e => e.CodMunicipio).HasColumnName("Cod_Municipio");

                entity.Property(e => e.CodMunicipioMo).HasColumnName("Cod_MunicipioMo");

                entity.Property(e => e.CodPais)
                    .HasColumnName("Cod_Pais")
                    .HasMaxLength(5);

                entity.Property(e => e.CodPaisMo)
                    .HasColumnName("Cod_PaisMo")
                    .HasMaxLength(5);

                entity.Property(e => e.CodTiendaLiq)
                    .HasColumnName("Cod_TiendaLiq")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTipoLista).HasColumnName("Cod_TipoLista");

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasColumnName("Cod_Ubicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.CodUbicacionEnt)
                    .HasColumnName("Cod_UbicacionEnt")
                    .HasMaxLength(10);

                entity.Property(e => e.CodUbicacionEntMo)
                    .HasColumnName("Cod_UbicacionEntMo")
                    .HasMaxLength(10);

                entity.Property(e => e.CodUbicacionLista)
                    .IsRequired()
                    .HasColumnName("Cod_UbicacionLista")
                    .HasMaxLength(10);

                entity.Property(e => e.ColorMo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.DireccionMo).HasMaxLength(100);

                entity.Property(e => e.DireccionPostBoda)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.Ecologico)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaEvento).HasColumnType("datetime");

                entity.Property(e => e.FechaLista).HasColumnType("datetime");

                entity.Property(e => e.FechaMonia).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.GeoRefXmo).HasColumnName("GeoRefXMo");

                entity.Property(e => e.GeoRefYmo).HasColumnName("GeoRefYMo");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("Id_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.IdPersonal)
                    .IsRequired()
                    .HasColumnName("Id_Personal")
                    .HasMaxLength(50);

                entity.Property(e => e.Pwdinternet)
                    .IsRequired()
                    .HasColumnName("PWDInternet")
                    .HasMaxLength(50);

                entity.Property(e => e.Referencias).HasMaxLength(100);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StatusMonia)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TarjetaPrivilegio)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoMo).HasMaxLength(50);

                entity.Property(e => e.TelefonoPostBoda)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TipoLentrega).HasColumnName("Tipo_LEntrega");

                entity.Property(e => e.TipoLentregaMo).HasColumnName("Tipo_LEntregaMo");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Zona).HasMaxLength(50);

                entity.Property(e => e.ZonaMo).HasMaxLength(50);
            });

            modelBuilder.Entity<ZtmpEventoSaquilmer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ztmp_evento_saquilmer");

                entity.Property(e => e.AcreditaPuntos)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodArea).HasColumnName("Cod_Area");

                entity.Property(e => e.CodAreaMo).HasColumnName("Cod_AreaMo");

                entity.Property(e => e.CodDepartamento).HasColumnName("Cod_Departamento");

                entity.Property(e => e.CodDepartamentoMo).HasColumnName("Cod_DepartamentoMo");

                entity.Property(e => e.CodMunicipio).HasColumnName("Cod_Municipio");

                entity.Property(e => e.CodMunicipioMo).HasColumnName("Cod_MunicipioMo");

                entity.Property(e => e.CodPais)
                    .HasColumnName("Cod_Pais")
                    .HasMaxLength(5);

                entity.Property(e => e.CodPaisMo)
                    .HasColumnName("Cod_PaisMo")
                    .HasMaxLength(5);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTipoLista).HasColumnName("Cod_TipoLista");

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasColumnName("Cod_Ubicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.CodUbicacionEnt)
                    .HasColumnName("Cod_UbicacionEnt")
                    .HasMaxLength(10);

                entity.Property(e => e.CodUbicacionEntMo)
                    .HasColumnName("Cod_UbicacionEntMo")
                    .HasMaxLength(10);

                entity.Property(e => e.CodUbicacionLista)
                    .IsRequired()
                    .HasColumnName("Cod_UbicacionLista")
                    .HasMaxLength(10);

                entity.Property(e => e.ColorMo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.DireccionMo).HasMaxLength(100);

                entity.Property(e => e.DireccionPostBoda)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.FechaEvento).HasColumnType("datetime");

                entity.Property(e => e.FechaLista).HasColumnType("datetime");

                entity.Property(e => e.FechaMonia).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.GeoRefXmo).HasColumnName("GeoRefXMo");

                entity.Property(e => e.GeoRefYmo).HasColumnName("GeoRefYMo");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("Id_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.IdPersonal)
                    .IsRequired()
                    .HasColumnName("Id_Personal")
                    .HasMaxLength(50);

                entity.Property(e => e.Pwdinternet)
                    .IsRequired()
                    .HasColumnName("PWDInternet")
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StatusMonia)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TarjetaPrivilegio)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoMo).HasMaxLength(50);

                entity.Property(e => e.TelefonoPostBoda)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TipoLentrega).HasColumnName("Tipo_LEntrega");

                entity.Property(e => e.TipoLentregaMo).HasColumnName("Tipo_LEntregaMo");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Zona).HasMaxLength(50);

                entity.Property(e => e.ZonaMo).HasMaxLength(50);
            });

            modelBuilder.Entity<ZtmpEventoprueba>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ztmp_eventoprueba");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("id_evento")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<ZtmpEventos>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ztmp_eventos");

                entity.Property(e => e.Apellido1Novia)
                    .HasColumnName("Apellido1NOVIA")
                    .HasMaxLength(50);

                entity.Property(e => e.Apellido1Novio)
                    .HasColumnName("Apellido1NOVIO")
                    .HasMaxLength(50);

                entity.Property(e => e.Apellido2Novia)
                    .HasColumnName("Apellido2NOVIA")
                    .HasMaxLength(50);

                entity.Property(e => e.Apellido2Novio)
                    .HasColumnName("Apellido2NOVIO")
                    .HasMaxLength(50);

                entity.Property(e => e.CelularNovia)
                    .HasColumnName("CelularNOVIA")
                    .HasMaxLength(50);

                entity.Property(e => e.CelularNovio)
                    .HasColumnName("CelularNOVIO")
                    .HasMaxLength(50);

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasColumnName("cod_ubicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.CodUbicacionlista)
                    .IsRequired()
                    .HasColumnName("cod_ubicacionlista")
                    .HasMaxLength(10);

                entity.Property(e => e.CorreoNovia)
                    .HasColumnName("CorreoNOVIA")
                    .HasMaxLength(100);

                entity.Property(e => e.CorreoNovio)
                    .HasColumnName("CorreoNOVIO")
                    .HasMaxLength(100);

                entity.Property(e => e.FaxNovia)
                    .HasColumnName("FaxNOVIA")
                    .HasMaxLength(50);

                entity.Property(e => e.FaxNovio)
                    .HasColumnName("FaxNOVIO")
                    .HasMaxLength(50);

                entity.Property(e => e.Fechaevento)
                    .HasColumnName("fechaevento")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fechalista)
                    .HasColumnName("fechalista")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fecharegistro)
                    .HasColumnName("fecharegistro")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("id_evento")
                    .HasMaxLength(25);

                entity.Property(e => e.Nombre1Novia)
                    .HasColumnName("Nombre1NOVIA")
                    .HasMaxLength(100);

                entity.Property(e => e.Nombre1Novio)
                    .HasColumnName("Nombre1NOVIO")
                    .HasMaxLength(100);

                entity.Property(e => e.Nombre2Novia)
                    .HasColumnName("Nombre2NOVIA")
                    .HasMaxLength(50);

                entity.Property(e => e.Nombre2Novio)
                    .HasColumnName("Nombre2NOVIO")
                    .HasMaxLength(50);

                entity.Property(e => e.TarjetaPrivilegio)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TelOficinaNovia)
                    .HasColumnName("TelOficinaNOVIA")
                    .HasMaxLength(50);

                entity.Property(e => e.TelOficinaNovio)
                    .HasColumnName("TelOficinaNOVIO")
                    .HasMaxLength(50);

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasColumnName("titulo")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZtmpEventossinpersonaevento>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ztmp_eventossinpersonaevento");

                entity.Property(e => e.AcreditaPuntos)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodArea).HasColumnName("Cod_Area");

                entity.Property(e => e.CodAreaMo).HasColumnName("Cod_AreaMo");

                entity.Property(e => e.CodDepartamento).HasColumnName("Cod_Departamento");

                entity.Property(e => e.CodDepartamentoMo).HasColumnName("Cod_DepartamentoMo");

                entity.Property(e => e.CodMunicipio).HasColumnName("Cod_Municipio");

                entity.Property(e => e.CodMunicipioMo).HasColumnName("Cod_MunicipioMo");

                entity.Property(e => e.CodPais)
                    .HasColumnName("Cod_Pais")
                    .HasMaxLength(5);

                entity.Property(e => e.CodPaisMo)
                    .HasColumnName("Cod_PaisMo")
                    .HasMaxLength(5);

                entity.Property(e => e.CodTiendaLiq)
                    .HasColumnName("Cod_TiendaLiq")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTipoLista).HasColumnName("Cod_TipoLista");

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasColumnName("Cod_Ubicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.CodUbicacionEnt)
                    .HasColumnName("Cod_UbicacionEnt")
                    .HasMaxLength(10);

                entity.Property(e => e.CodUbicacionEntMo)
                    .HasColumnName("Cod_UbicacionEntMo")
                    .HasMaxLength(10);

                entity.Property(e => e.CodUbicacionLista)
                    .IsRequired()
                    .HasColumnName("Cod_UbicacionLista")
                    .HasMaxLength(10);

                entity.Property(e => e.ColorMo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.DireccionMo).HasMaxLength(100);

                entity.Property(e => e.DireccionPostBoda)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.Ecologico)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaEvento).HasColumnType("datetime");

                entity.Property(e => e.FechaLiq).HasColumnType("datetime");

                entity.Property(e => e.FechaLista).HasColumnType("datetime");

                entity.Property(e => e.FechaMonia).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.GeoRefXmo).HasColumnName("GeoRefXMo");

                entity.Property(e => e.GeoRefYmo).HasColumnName("GeoRefYMo");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("Id_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.IdPersonal)
                    .IsRequired()
                    .HasColumnName("Id_Personal")
                    .HasMaxLength(50);

                entity.Property(e => e.IdPersonalLiq)
                    .HasColumnName("ID_PersonalLiq")
                    .HasMaxLength(40);

                entity.Property(e => e.IdPersonalRec)
                    .HasColumnName("ID_PersonalRec")
                    .HasMaxLength(40);

                entity.Property(e => e.Pwdinternet)
                    .IsRequired()
                    .HasColumnName("PWDInternet")
                    .HasMaxLength(50);

                entity.Property(e => e.Referencias).HasMaxLength(100);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StatusMonia)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TarjetaPrivilegio)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoMo).HasMaxLength(50);

                entity.Property(e => e.TelefonoPostBoda)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TipoLentrega).HasColumnName("Tipo_LEntrega");

                entity.Property(e => e.TipoLentregaMo).HasColumnName("Tipo_LEntregaMo");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Zona).HasMaxLength(50);

                entity.Property(e => e.ZonaMo).HasMaxLength(50);
            });

            modelBuilder.Entity<ZtmpExistencia>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ztmp_existencia");

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasColumnName("cod_ubicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("sku")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ZtmpExpoBodas>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZTMP_ExpoBodas");

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(255);

                entity.Property(e => e.FechaBoda).HasMaxLength(255);

                entity.Property(e => e.Nombre).HasMaxLength(255);
            });

            modelBuilder.Entity<ZtmpLiquidaciones>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ztmp_liquidaciones");

                entity.Property(e => e.Fechaliq)
                    .HasColumnName("fechaliq")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("id_evento")
                    .HasMaxLength(25);

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasColumnName("titulo")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZtmpListaregalos>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ztmp_listaregalos");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("id_evento")
                    .HasMaxLength(25);

                entity.Property(e => e.Lista)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZtmpNombresinvitados>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ztmp_nombresinvitados");

                entity.Property(e => e.Nombres)
                    .HasColumnName("nombres")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZtmpPasaparaenvios>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ztmp_pasaparaenvios");

                entity.Property(e => e.IdCaja).HasColumnName("id_caja");

                entity.Property(e => e.Preciodesc)
                    .HasColumnName("preciodesc")
                    .HasColumnType("money");

                entity.Property(e => e.Sku).HasColumnName("sku");

                entity.Property(e => e.Transaccion).HasColumnName("transaccion");
            });

            modelBuilder.Entity<ZtmpPersonaeventoPopaSacor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ztmp_personaevento_popa_sacor");

                entity.Property(e => e.Apellido1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Apellido2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Celular)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CodTipoCont).HasColumnName("Cod_TipoCont");

                entity.Property(e => e.CodTipoIdent).HasColumnName("Cod_TipoIdent");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMail")
                    .HasMaxLength(100);

                entity.Property(e => e.Fax)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FechaNac).HasColumnType("datetime");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("Id_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.Nombre1)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Nombre2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NumeroId)
                    .IsRequired()
                    .HasColumnName("NumeroID")
                    .HasMaxLength(100);

                entity.Property(e => e.RecMonia)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RecRegalos)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SerieId)
                    .IsRequired()
                    .HasColumnName("SerieID")
                    .HasMaxLength(10);

                entity.Property(e => e.TelOficina)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ZtmpPersonaeventoSaquilmer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ztmp_personaevento_saquilmer");

                entity.Property(e => e.Apellido1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Apellido2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Celular)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CodTipoCont).HasColumnName("Cod_TipoCont");

                entity.Property(e => e.CodTipoIdent).HasColumnName("Cod_TipoIdent");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMail")
                    .HasMaxLength(100);

                entity.Property(e => e.Fax)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("Id_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.Nombre1)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Nombre2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NumeroId)
                    .IsRequired()
                    .HasColumnName("NumeroID")
                    .HasMaxLength(100);

                entity.Property(e => e.RecMonia)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RecRegalos)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SerieId)
                    .IsRequired()
                    .HasColumnName("SerieID")
                    .HasMaxLength(10);

                entity.Property(e => e.TelOficina)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ZtmpPersonaeventosinevento>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ztmp_personaeventosinevento");

                entity.Property(e => e.Apellido1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Apellido2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Celular)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CodTipoCont).HasColumnName("Cod_TipoCont");

                entity.Property(e => e.CodTipoIdent).HasColumnName("Cod_TipoIdent");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMail")
                    .HasMaxLength(100);

                entity.Property(e => e.Fax)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FechaNac).HasColumnType("datetime");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("Id_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.Nombre1)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Nombre2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NumeroId)
                    .IsRequired()
                    .HasColumnName("NumeroID")
                    .HasMaxLength(100);

                entity.Property(e => e.RecMonia)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RecRegalos)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SerieId)
                    .IsRequired()
                    .HasColumnName("SerieID")
                    .HasMaxLength(10);

                entity.Property(e => e.TelOficina)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ZtmpSinlista>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ztmp_sinlista");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("id_evento")
                    .HasMaxLength(25);

                entity.Property(e => e.SinLista)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZtmpUsuariosbodasactivos>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ztmp_usuariosbodasactivos");

                entity.Property(e => e.Usuario)
                    .HasColumnName("USUARIO")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZtmpVentasevento>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ztmp_ventasevento");

                entity.Property(e => e.IdEvento)
                    .HasColumnName("id_evento")
                    .HasMaxLength(25);

                entity.Property(e => e.VentasEvento).HasColumnType("money");
            });

            modelBuilder.Entity<ZtmpdetEnviosinenvios>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ztmpdet_enviosinenvios");

                entity.Property(e => e.Ambiente)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CodTamano).HasColumnName("Cod_Tamano");

                entity.Property(e => e.CodTipoEmpaque).HasColumnName("Cod_TipoEmpaque");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(350);

                entity.Property(e => e.EmpaqTienda)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("ID_Envio")
                    .HasMaxLength(25);

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(25);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TiendasB).HasMaxLength(100);
            });

            modelBuilder.Entity<ZtmpdetListaregalos>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ztmpdet_listaregalos");

                entity.Property(e => e.Ambiente)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Ean)
                    .IsRequired()
                    .HasColumnName("EAN")
                    .HasMaxLength(50);

                entity.Property(e => e.IdLista)
                    .IsRequired()
                    .HasColumnName("Id_Lista")
                    .HasMaxLength(25);

                entity.Property(e => e.Marca)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(50);

                entity.Property(e => e.UnidMed)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ZviwListadoBebes>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ZViw_ListadoBebes");

                entity.Property(e => e.ApCasada)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Apellido1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Apellido2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CodTipoCont).HasColumnName("Cod_TipoCont");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMail")
                    .HasMaxLength(100);

                entity.Property(e => e.FechaEvento).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("Id_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Nombre1)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Nombre2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NombreEvento)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TarjetaPrivilegio)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TiendaRegistro)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<ZviwRegaloDetalle>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ZViw_regaloDetalle");

                entity.Property(e => e.AñoVenta).HasColumnName("AÑO VENTA");

                entity.Property(e => e.FechaDeInscripción)
                    .HasColumnName("FECHA DE INSCRIPCIÓN")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaEvento)
                    .HasColumnName("FECHA EVENTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdAsesora)
                    .HasColumnName("ID ASESORA")
                    .HasMaxLength(25);

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("ID EVENTO")
                    .HasMaxLength(25);

                entity.Property(e => e.MesVenta).HasColumnName("MES VENTA");

                entity.Property(e => e.MontoVenta)
                    .HasColumnName("MONTO VENTA")
                    .HasColumnType("money");

                entity.Property(e => e.NoRegalos).HasColumnName("NO. REGALOS");

                entity.Property(e => e.NombreAsesora)
                    .HasColumnName("NOMBRE ASESORA")
                    .HasMaxLength(100);

                entity.Property(e => e.NombreEvento)
                    .IsRequired()
                    .HasColumnName("NOMBRE EVENTO")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TiendaDeInscripción)
                    .IsRequired()
                    .HasColumnName("TIENDA DE INSCRIPCIÓN")
                    .HasMaxLength(10);

                entity.Property(e => e.TiendaVenta)
                    .IsRequired()
                    .HasColumnName("TIENDA VENTA")
                    .HasMaxLength(10);

                entity.Property(e => e.TipoAsesora)
                    .HasColumnName("TIPO ASESORA")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.TipoVenta)
                    .IsRequired()
                    .HasColumnName("TIPO VENTA")
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZvwEnvioRuta>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ZVW_ENVIO_RUTA");

                entity.Property(e => e.FechaRutaEntrega)
                    .HasColumnName("FECHA_RUTA_ENTREGA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("ID_Envio")
                    .HasMaxLength(25);

                entity.Property(e => e.NumeroRutaEntrega)
                    .HasColumnName("NUMERO_RUTA_ENTREGA")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ZvwVistaTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Zvw_Vista_Temp");

                entity.Property(e => e.AcreditaPuntos)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodArea).HasColumnName("Cod_Area");

                entity.Property(e => e.CodAreaMo).HasColumnName("Cod_AreaMo");

                entity.Property(e => e.CodDepartamento).HasColumnName("Cod_Departamento");

                entity.Property(e => e.CodDepartamentoMo).HasColumnName("Cod_DepartamentoMo");

                entity.Property(e => e.CodMunicipio).HasColumnName("Cod_Municipio");

                entity.Property(e => e.CodMunicipioMo).HasColumnName("Cod_MunicipioMo");

                entity.Property(e => e.CodPais)
                    .HasColumnName("Cod_Pais")
                    .HasMaxLength(5);

                entity.Property(e => e.CodPaisMo)
                    .HasColumnName("Cod_PaisMo")
                    .HasMaxLength(5);

                entity.Property(e => e.CodTiendaLiq)
                    .HasColumnName("Cod_TiendaLiq")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTipoLista).HasColumnName("Cod_TipoLista");

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasColumnName("Cod_Ubicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.CodUbicacionEnt)
                    .HasColumnName("Cod_UbicacionEnt")
                    .HasMaxLength(10);

                entity.Property(e => e.CodUbicacionEntMo)
                    .HasColumnName("Cod_UbicacionEntMo")
                    .HasMaxLength(10);

                entity.Property(e => e.CodUbicacionLista)
                    .IsRequired()
                    .HasColumnName("Cod_UbicacionLista")
                    .HasMaxLength(10);

                entity.Property(e => e.ColorMo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.DireccionMo).HasMaxLength(100);

                entity.Property(e => e.DireccionPostBoda)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.Ecologico)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaEvento).HasColumnType("datetime");

                entity.Property(e => e.FechaLista).HasColumnType("datetime");

                entity.Property(e => e.FechaMonia).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.GeoRefXmo).HasColumnName("GeoRefXMo");

                entity.Property(e => e.GeoRefYmo).HasColumnName("GeoRefYMo");

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("ID_Envio")
                    .HasMaxLength(25);

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("Id_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.IdPersonal)
                    .IsRequired()
                    .HasColumnName("Id_Personal")
                    .HasMaxLength(50);

                entity.Property(e => e.Pwdinternet)
                    .IsRequired()
                    .HasColumnName("PWDInternet")
                    .HasMaxLength(50);

                entity.Property(e => e.Referencias).HasMaxLength(100);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StatusMonia)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TarjetaPrivilegio)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoMo).HasMaxLength(50);

                entity.Property(e => e.TelefonoPostBoda)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TipoLentrega).HasColumnName("Tipo_LEntrega");

                entity.Property(e => e.TipoLentregaMo).HasColumnName("Tipo_LEntregaMo");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Zona).HasMaxLength(50);

                entity.Property(e => e.ZonaMo).HasMaxLength(50);
            });

            modelBuilder.Entity<ZvwVistaTemp1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Zvw_Vista_Temp", "DOMINO\\itdeleon");

                entity.Property(e => e.AcreditaPuntos)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodArea).HasColumnName("Cod_Area");

                entity.Property(e => e.CodAreaMo).HasColumnName("Cod_AreaMo");

                entity.Property(e => e.CodDepartamento).HasColumnName("Cod_Departamento");

                entity.Property(e => e.CodDepartamentoMo).HasColumnName("Cod_DepartamentoMo");

                entity.Property(e => e.CodMunicipio).HasColumnName("Cod_Municipio");

                entity.Property(e => e.CodMunicipioMo).HasColumnName("Cod_MunicipioMo");

                entity.Property(e => e.CodPais)
                    .HasColumnName("Cod_Pais")
                    .HasMaxLength(5);

                entity.Property(e => e.CodPaisMo)
                    .HasColumnName("Cod_PaisMo")
                    .HasMaxLength(5);

                entity.Property(e => e.CodTiendaLiq)
                    .HasColumnName("Cod_TiendaLiq")
                    .HasMaxLength(10);

                entity.Property(e => e.CodTipo).HasColumnName("Cod_Tipo");

                entity.Property(e => e.CodTipoLista).HasColumnName("Cod_TipoLista");

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasColumnName("Cod_Ubicacion")
                    .HasMaxLength(10);

                entity.Property(e => e.CodUbicacionEnt)
                    .HasColumnName("Cod_UbicacionEnt")
                    .HasMaxLength(10);

                entity.Property(e => e.CodUbicacionEntMo)
                    .HasColumnName("Cod_UbicacionEntMo")
                    .HasMaxLength(10);

                entity.Property(e => e.CodUbicacionLista)
                    .IsRequired()
                    .HasColumnName("Cod_UbicacionLista")
                    .HasMaxLength(10);

                entity.Property(e => e.ColorMo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.DireccionMo).HasMaxLength(100);

                entity.Property(e => e.DireccionPostBoda)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.Ecologico)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaEvento).HasColumnType("datetime");

                entity.Property(e => e.FechaLista).HasColumnType("datetime");

                entity.Property(e => e.FechaMonia).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.GeoRefXmo).HasColumnName("GeoRefXMo");

                entity.Property(e => e.GeoRefYmo).HasColumnName("GeoRefYMo");

                entity.Property(e => e.IdEnvio)
                    .IsRequired()
                    .HasColumnName("ID_Envio")
                    .HasMaxLength(25);

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasColumnName("Id_Evento")
                    .HasMaxLength(25);

                entity.Property(e => e.IdPersonal)
                    .IsRequired()
                    .HasColumnName("Id_Personal")
                    .HasMaxLength(50);

                entity.Property(e => e.Pwdinternet)
                    .IsRequired()
                    .HasColumnName("PWDInternet")
                    .HasMaxLength(50);

                entity.Property(e => e.Referencias).HasMaxLength(100);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StatusMonia)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TarjetaPrivilegio)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoMo).HasMaxLength(50);

                entity.Property(e => e.TelefonoPostBoda)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TipoLentrega).HasColumnName("Tipo_LEntrega");

                entity.Property(e => e.TipoLentregaMo).HasColumnName("Tipo_LEntregaMo");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Zona).HasMaxLength(50);

                entity.Property(e => e.ZonaMo).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
