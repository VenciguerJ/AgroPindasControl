using System.ComponentModel.DataAnnotations;
using System;
using System.Text.RegularExpressions;
namespace agropindas.Models;

public class Fornecedor
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Campo Obrigat�rio")]
    [MaxLength(14, ErrorMessage = "O campo deve conter {1} caracteres")]
    public String CNPJ { get; set; }

    [Required(ErrorMessage = "Campo Obrigat�rio")]
    [MaxLength(45, ErrorMessage = "O campo deve conter {1} caracteres")]
    public string RazaoSocial { get; set; }

    [MaxLength(250, ErrorMessage = "O campo deve conter {1} caracteres")]
    public string Endereco { get; set; }

    [MaxLength(11, ErrorMessage = "O campo deve conter {1} caracteres")]
    public string Fone { get; set; }

    [MaxLength(45, ErrorMessage = "O campo deve conter {1} caracteres")]
    public string Email { get; set; }

    public void Debugger()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"CNPJ: {CNPJ}");
        Console.WriteLine($"Raz�o Social: {RazaoSocial}");
        Console.WriteLine($"Endere�o: {Endereco}");
        Console.WriteLine($"Telefone: {Fone}");
        Console.WriteLine($"Email: {Email}");
    }

    public Fornecedor() { }

}