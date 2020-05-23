Vue.use(VueTables.ServerTable);


new Vue({
    el: '#app',
    data: {
        selectedEmail: {},
        counter: 0,
        CamposAFiltrar: {
            IdSec: "",
            AsuntoCorreo: "",
            EstadoSec: "A",
        },
        dataContacto: {
            NombreCon: "",
            ApellidoCon: "",
            CorreoCon: "",
            FonoCon: "",
            OrigenCon: "",
            IdTrab: 0,
        },
        filtro: '',
        vt_gestautomail: {
            loading: false,
            columns: [
                '0',
                '1',
                '2',
                '3',
                '4',
            ],
            options: {
                params: {
                    Filtro: ''
                },
                skin: 'table table-sm CRM-table-headers',
                columnsClasses: {
                    'Estado': 'text-center',

                },
                perPage: 10,
                perPageValues: [10],
                orderBy: {
                    ascending: false,
                    column: 'IdSec'
                },
                dateColumns: ['FchEmis'],
                dateFormat: 'YYYY-MM-DD',
                filterable: false,
                headings: {
                    0: 'ID',
                    1: 'Nombre Farmacia',
                    2: 'Longitud',
                    3: 'Latitud',
                    4: 'Sector',
                },
                sortable: ['Folio', 'FchEmis', 'FchVenc'],
                requestFunction: function (data) {
                    axios.defaults.headers.post['Content-Type'] = "application/json";
                    return axios.post('Farmacias/getListado', data)
                        .catch(function (e) {
                            this.dispatch('error', e);
                        }.bind(this))
                }
            }
        },
    },
    methods: {
        reloadTable: function () {
            this.$refs.vtAutoMail.setPage(this.$refs.vtAutoMail.page);
        },
        Detalles: function (log,lat) {
            // window.location.assign("/Mapa/ubi_farmacia/" + log + "/" + lat);
            var x = parseFloat(lat);
            var y = parseFloat(log);

            asignarMapa(x, y);
        },
        exportar: function (formato) {
            window.location.href = '../Exportar/' + formato;
        },
    }
});


