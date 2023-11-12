using System.Runtime.Serialization;

namespace Parcial3_MazoQuicenoFredyAntonio.DAL
{
    public class SeederDB
    {
        private readonly DataBaseContext _context;

        public SeederDB(DataBaseContext context)
        {
            _context = context;
        }

        //Crear un método llamado SeederAsync()
        //Éste método es una especie de MAIN()
        //Éste método tendrá la responsabilidad de prepoblar las diferentes tablas de la BD

        public async Task SeederAsync()
        {
            //Primero: se agregará un método propio de EF que hace las veces del comando "update-database"
            //En otras palabras: es un método que creará la BD inmediatamente ponga en ejecución la API
            await _context.Database.EnsureCreatedAsync();

            //A partir de aquí se crearán métodos para prepoblar la BD
            await PopulateTicketsAsync();
            await _context.SaveChangesAsync();
        }

        #region Private Methods
        private async Task PopulateTicketsAsync()
        {
            //El método Any() indica que la tabla tiene al menos un registro
            //El método Any() negado (!) indica que no hay ningún registro en la tabla
            if (!_context.Tickets.Any())
            {
                for (int i = 0; i < 1000;  i++)
                {
                    Guid newGuid = Guid.NewGuid();
                    _context.Tickets.Add(new Entities.Ticket { Id = newGuid, EntranceGate = null, IsUsed = false, UseDate = null });
                }
            }
        }
    }
        #endregion
}
