using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq.mapping;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;


static void main(string[] args)
{
    string email, temail, senha, tsenha;
    Console.Write("E-mail");
    email = readline();
    Console.Write("senha");
    senha = readline();
    try
    {
        OpenConnection();
        
    }
    if (email = temail)
    {
        if(senha = tsenha)
        {

        }
        else
        Console.Write("Senha Invalida");
    }
    else 
    Console.Write("Email invalido");
}