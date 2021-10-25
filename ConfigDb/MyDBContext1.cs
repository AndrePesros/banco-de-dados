using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.ConfigDb
{
    class MyDBContext1: DbContext
    {
        DbSet<Evento> Eventos { get; set; }
    }
}
