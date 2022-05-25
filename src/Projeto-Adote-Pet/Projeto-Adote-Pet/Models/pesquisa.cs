using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.ComponentModel.DataAnnotations.Schema;
using Amazon.EC2.Model;

//sintaxe table estava errada
// ln 56 public string Especie não seria sexo?
// não está reconhecendo "Storage

[Table ("Animal")]
public class Animal   
{
    private string _Idanimal;
    [Column(IsPrimaryKey = true, Storage = "_Idanimal")]
    public string Idanimal
    {
        get
        {
            return this._Idanimal;
        }
        set
        {
            this._Idanimal = value;
        }
    }

    private string _NomePet;
    [Column(Storage = "_NomePet")]
    public string NomePet
    {
        get
        {
            return this._NomePet;
        }
        set
        {
            this._NomePet = value;
        }
    }
    private string _Especie;
    [Column(Storage = "_Especie")]
    public string Especie
    {
        get
        {
            return this._Especie;
        }
        set
        {
            this._Especie = value;
        }
    }
    private string _Sexo;
    [Column(Storage = "_Sexo")]
    public string Especie
    {
        get
        {
            return this._Sexo;
        }
        set
        {
            this._Sexo = value;
        }
    }
    private string _Raca;
    [Column(Storage = "_Raca")]
    public string Raca
    {
        get
        {
            return this._Raca;
        }
        set
        {
            this._Raca = value;
        }
    }
    private string _Idade;
    [Column(Storage = "_Idade")]
    public string Idade
    {
        get
        {
            return this._Idade;
        }
        set
        {
            this._Idade = value;
        }
    }
    private string _Porte;
    [Column(Storage = "_Porte")]
    public string Porte
    {
        get
        {
            return this._Porte;
        }
        set
        {
            this._Porte = value;
        }
    }
    private string _Cor;
    [Column(Storage = "_Cor")]
    public string Cor
    {
        get
        {
            return this._Cor;
        }
        set
        {
            this._Cor = value;
        }
    }
    private string _CidadePet;
    [Column(Storage = "_CidadePet")]
    public string CidadePet
    {
        get
        {
            return this._CidadePet;
        }
        set
        {
            this._CidadePet = value;
        }
    }
    private string _EstadoPet;
    [Column(Storage = "_EstadoPet")]
    public string EstadoPet
    {
        get
        {
            return this._EstadoPet;
        }
        set
        {
            this._EstadoPet = value;
        }
    }
    private string _Descricao;
    [Column(Storage = "_Descricao")]
    public string Descricao
    {
        get
        {
            return this._Descricao;
        }
        set
        {
            this._Descricao = value;
        }
    }
    private string _Pstatus;
    [Column(Storage = "_Pstatus")]
    public string Pstatus
    {
        get
        {
            return this._Pstatus;
        }
        set
        {
            this._Pstatus = value;
        }
    }
}
public class main
{
    Foreach(Animal cust in custQuery)
    {
        Console.WriteLine("ID={0}, Nome={1}, Especie={2}, Sexo{3}, Raca{4}", cust.Idanimal, cust.NomePet, cust.Especie, cust.Sexo, cust.Raca);
    }


Console.ReadLine();
}