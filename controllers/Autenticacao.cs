using Charming_house.repository;
using Charming_house.models;
using System.Collections.Generic;
using Charming_house.exception;
using Charming_house.utils;

namespace Charming_house.controllers
{
    public class Autenticacao
    {
        public static Pessoa autentica(string usuario, string senha){
            List<Pessoa> pessoas = PessoaRepository.findAll();
            
            Pessoa pessoa = pessoas.Find( (x) => x.Usuario == usuario.ToLower() );

            if( pessoa == null ) throw new ExAutentica("Usuario nao existe no sistema.");

            bool validarSenha = Password.Validate(senha, pessoa.Senha );

            if( !validarSenha ) throw new ExAutentica("Senha incorreta.");

            return pessoa;
        }

        public static bool cadastro( string usuario, string senha, string nome, int idade ){
            List<Pessoa> pessoas = PessoaRepository.findAll();

            Pessoa pessoa = pessoas.Find( (x) => x.Usuario == usuario.ToLower() );

            if( pessoa != null ) throw new ExCadastro("Usuario ja existe no sistema.");

            pessoas.Add( new Cliente( nome, idade, usuario.ToLower(), Password.Encript(senha) ) );

            PessoaRepository.Save(pessoas);

            return true;
        }

    }

}