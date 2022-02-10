using Escola.Dominio.Shared;
using Escola.Infra.ORM.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Infra.ORM.Features.Shared
{
    public class ORMBase<T> : IORMBase<T> where T : EntidadeBase
    {
        readonly AulaContext contexto;
        readonly DbSet<T> registros;
        public ORMBase(AulaContext contexto)
        {
            this.contexto = contexto;
            registros = contexto.Set<T>();
        }
        public void Editar(T registro)
        {
            try
            {
                registros.Update(registro);
                contexto.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void Excluir(T registro)
        {
            try
            {
                registros.Remove(registro);
                contexto.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public IList<T> GetAll()
        {
            return registros.ToList();
        }

        public T GetById(int id)
        {
            return registros.SingleOrDefault(x => x.Id == id);
        }

        public void Inserir(T registro)
        {
            try
            {
                registros.Add(registro);
                contexto.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
