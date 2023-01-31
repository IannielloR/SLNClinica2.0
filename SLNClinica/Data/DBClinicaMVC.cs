using Microsoft.EntityFrameworkCore;
using SLNClinica.Models;

namespace SLNClinica.Data
{
    public class DBClinicaMVC : DbContext 
    {
        public DBClinicaMVC(DbContextOptions<DBClinicaMVC> options) : base(options) { }


        public DbSet<Medico> Medicos { get; set; }

    }
}
