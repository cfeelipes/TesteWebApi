using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using TesteWebApi.Models;

namespace TesteWebApi.Controllers
{
    [EnableCors("*", "*", "*")]
    public class TesteController : ApiController
    {
        // GET: api/Teste
        public IEnumerable<Aluno> Get()
        {
            Aluno aluno = new Aluno();
            return aluno.ListarAluno();
        }

        // GET: api/Teste/5
        public Aluno Get(int id)
        {
            Aluno aluno = new Aluno();
            return aluno.ListarAluno().Where(Aluno => Aluno.Id == id).FirstOrDefault();
        }

        // POST: api/Teste
        public List<Aluno> Post(Aluno aluno)
        {
            Aluno _aluno = new Aluno();
            _aluno.Inserir(aluno);
            return _aluno.ListarAluno();
        }

        // PUT: api/Teste/5
        public void Put(int id, [FromBody]Aluno aluno)
        {
            Aluno _aluno = new Aluno();
            _aluno.Atualizar(id, aluno);
        }

        // DELETE: api/Teste/5
        public void Delete(int id)
        {
            Aluno _aluno = new Aluno();
            _aluno.Deletar(id);
        }
    }
}
