using Cavalheiro.Ashbel.Application.Interfaces;
using Cavalheiro.Ashbel.Model;
using Cavalheiro.Ashbel.Persistance;
using Cavalheiro.Ashbel.WebApi.Controllers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Cavalheiro.Ashbel.WebApiTester
{
    public class PessoaTest
    {
        private PessoaController _controller;
        private readonly IPessoaApp<PessoaModel> _app;

        public PessoaTest(IPessoaApp<PessoaModel> app)
        {
            var options = new DbContextOptionsBuilder<AshbelDbContext>()
                .UseInMemoryDatabase(databaseName: "Ashbel")
                .Options;

            var memoryContext = new AshbelDbContext(options);

            _app = app;

            SeedStatusPessoaTests(memoryContext);
            SeedPessoaTests(memoryContext);
            SeedAlunoTests(memoryContext);
            //SeedPessoaInfoAdicionalTests(memoryContext);
            SeedTurmaTests(memoryContext);

            _controller = new PessoaController(memoryContext, _app);
        }

        private void SeedPessoaTests(AshbelDbContext context)
        {
            var persons = new List<PessoaModel>();

            persons.Add(new PessoaModel
            {
                Id = 1,
                Nome = "Denis Douglas Cavalheiro",
                DataCriacao = DateTime.Now,
                UsuarioCriacao = "Denis",
                DataAlteracao = null,
                UsuarioAlteracao = null,
                Ativo = true,
                IdAluno = null,
                IdPessoaConjugue = 2,
                IdPessoaPai = null,
                IdStatusPessoa = 1,
                IdPessoaInfoAdicional = 1
                //Aluno = new AlunoModel
                //{
                //    Id = 1,
                //    DataCriacao = DateTime.Now,
                //    UsuarioCriacao = "Denis",
                //    DataAlteracao = null,
                //    UsuarioAlteracao = null,
                //    Ativo = true,
                //    Matriculado = true,
                //    IdTurma = 1
                //},
                //InfoAdicional = new PessoaInfoAdicionalModel
                //{
                //    Id = 1,
                //    DataCriacao = DateTime.Now,
                //    UsuarioCriacao = "Denis",
                //    DataAlteracao = null,
                //    UsuarioAlteracao = null,
                //    Ativo = true,
                //    IdPessoa = 1,
                //    Batizado = true,
                //    DataNascimento = new DateTime(1977, 3, 6),
                //    Empresa = "Sipal Agronegocio Ltda",
                //    MembroProfesso = true,
                //    NaturalCidade = "Curitiba",
                //    NaturalEstado = "Paraná",
                //    NaturalPais = "Brasil"
                //}
            });

            persons.Add(new PessoaModel
            {
                Id = 2,
                Nome = "Mary Anne Andersen Cavalheiro",
                DataCriacao = DateTime.Now,
                UsuarioCriacao = "Denis",
                DataAlteracao = null,
                UsuarioAlteracao = null,
                Ativo = true,
                IdAluno = null,
                IdPessoaConjugue = 1,
                IdPessoaPai = null,
                IdStatusPessoa = 1,
                IdPessoaInfoAdicional = 2
                //Aluno = new AlunoModel
                //{
                //    Id = 2,
                //    DataCriacao = DateTime.Now,
                //    UsuarioCriacao = "Denis",
                //    DataAlteracao = null,
                //    UsuarioAlteracao = null,
                //    Ativo = true,
                //    IdPessoa = 2,
                //    Matriculado = true,
                //    IdTurma = 1
                //},
                //InfoAdicional = new PessoaInfoAdicionalModel
                //{
                //    Id = 2,
                //    DataCriacao = DateTime.Now,
                //    UsuarioCriacao = "Denis",
                //    DataAlteracao = null,
                //    UsuarioAlteracao = null,
                //    Ativo = true,
                //    IdPessoa = 2,
                //    Batizado = true,
                //    DataNascimento = new DateTime(1977, 3, 1),
                //    Empresa = "Stebner Moda Pet",
                //    MembroProfesso = true,
                //    NaturalCidade = "Curitiba",
                //    NaturalEstado = "Paraná",
                //    NaturalPais = "Brasil"
                //}
            });

            context.Pessoa.AddRange(persons);

            context.SaveChanges();
        }

        private void SeedPessoaInfoAdicionalTests(AshbelDbContext context)
        {
            var personsInfo = new List<PessoaInfoAdicionalModel>();

            personsInfo.Add(new PessoaInfoAdicionalModel
            {
                Id = 1,
                DataCriacao = DateTime.Now,
                UsuarioCriacao = "Denis",
                DataAlteracao = null,
                UsuarioAlteracao = null,
                Ativo = true,
                IdPessoa = 1,
                Batizado = true,
                DataNascimento = new DateTime(1977, 3, 6),
                Empresa = "Sipal Agronegocio Ltda",
                MembroProfesso = true,
                NaturalCidade = "Curitiba",
                NaturalEstado = "Paraná",
                NaturalPais = "Brasil"
            });

            personsInfo.Add(new PessoaInfoAdicionalModel
            {
                Id = 2,
                DataCriacao = DateTime.Now,
                UsuarioCriacao = "Denis",
                DataAlteracao = null,
                UsuarioAlteracao = null,
                Ativo = true,
                IdPessoa = 2,
                Batizado = true,
                DataNascimento = new DateTime(1977, 3, 1),
                Empresa = "Stebner Moda Pet",
                MembroProfesso = true,
                NaturalCidade = "Curitiba",
                NaturalEstado = "Paraná",
                NaturalPais = "Brasil"
            });

            context.PessoaInfoAdicional.AddRange(personsInfo);

            context.SaveChanges();

        }

        private void SeedStatusPessoaTests(AshbelDbContext context)
        {
            var status = new List<StatusPessoaModel>();

            status.Add(new StatusPessoaModel
            {
                Id = 1,
                Nome = "Comungante",
                DataCriacao = DateTime.Now,
                UsuarioCriacao = "Denis",
                DataAlteracao = null,
                UsuarioAlteracao = null,
                Ativo = true,

            });

            status.Add(new StatusPessoaModel
            {
                Id = 2,
                Nome = "Não Comungante",
                DataCriacao = DateTime.Now,
                UsuarioCriacao = "Denis",
                DataAlteracao = null,
                UsuarioAlteracao = null,
                Ativo = true
            });

            context.StatusPessoa.AddRange(status);

            context.SaveChanges();
        }

        private void SeedAlunoTests(AshbelDbContext context)
        {
            var alunos = new List<AlunoModel>();

            alunos.Add(new AlunoModel
            {
                Id = 1,
                DataCriacao = DateTime.Now,
                UsuarioCriacao = "Denis",
                DataAlteracao = null,
                UsuarioAlteracao = null,
                Ativo = true,
                Matriculado = true,
                IdTurma = 1
            });

            alunos.Add(new AlunoModel
            {
                Id = 2,
                DataCriacao = DateTime.Now,
                UsuarioCriacao = "Denis",
                DataAlteracao = null,
                UsuarioAlteracao = null,
                Ativo = true,
                Matriculado = true,
                IdTurma = 1
            });

            context.Aluno.AddRange(alunos);

            context.SaveChanges();
        }

        private void SeedTurmaTests(AshbelDbContext context)
        {
            var turmas = new List<TurmaModel>();

            turmas.Add(new TurmaModel
            {
                Id = 1,
                DataCriacao = DateTime.Now,
                UsuarioCriacao = "Denis",
                DataAlteracao = null,
                UsuarioAlteracao = null,
                Ativo = true,
                IdadeMaxima = 0,
                IdadeMinima = 18,
                Nome = "Herois da Fé"
            });

            turmas.Add(new TurmaModel
            {
                Id = 2,
                DataCriacao = DateTime.Now,
                UsuarioCriacao = "Denis",
                DataAlteracao = null,
                UsuarioAlteracao = null,
                Ativo = true,
                IdadeMaxima = 0,
                IdadeMinima = 18,
                Nome = "Atalaia"
            });

            context.Turma.AddRange(turmas);

            context.SaveChanges();
        }

        [Fact]
        public void GetPessoaTest()
        {
            var result = _controller.Get();
            Assert.Equal(2, result.Result.Value.Count());
        }
    }
}
