window.mapaClientes = {

    map: null,

    init: function (clientes) {

        // Crear mapa
        this.map = L.map('map').setView([40.4168, -3.7038], 6);

        // Capa OpenStreetMap
        L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
            attribution: '© OpenStreetMap contributors'
        }).addTo(this.map);

        const bounds = [];

        clientes.forEach(c => {

            if (!c.clienLatitud || !c.clienLongitud)
                return;

            const lat = parseFloat(c.clienLatitud);
            const lng = parseFloat(c.clienLongitud);

            const marker = L.marker([lat, lng])
                .addTo(this.map)
                .bindPopup(`<b>${c.clievNombre}</b>`);

            bounds.push([lat, lng]);
        });

        if (bounds.length > 0) {
            this.map.fitBounds(bounds);
        }
    }
};