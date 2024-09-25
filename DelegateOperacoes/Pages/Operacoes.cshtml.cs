using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DelegateOperacoes.Pages
{
public class OperacoesModel : PageModel
{
 public delegate int Operacao(int x, int y);
  [BindProperty]
 public int Numero1 { get; set; }
 [BindProperty]
 public int Numero2 { get; set; }
 [BindProperty]
public string OperacaoEscolhida { get; set; }

public int Resultado { get; set; }
 public string Mensagem { get; set; }
 public void OnPost()
  {
    Operacao operacao = null;
     switch (OperacaoEscolhida)
  {
       case "Soma":
        operacao = Soma;
        break;
       case "Subtracao":
        operacao = Subtracao;
        break;
        case "Multiplicacao":
        operacao = Multiplicacao;
        break;
        default:
        Mensagem = "Opção inválida!";
    return;
  }

Resultado = operacao(Numero1, Numero2);
 Mensagem = $"Resultado: {Resultado}";
  }
 private int Soma(int x, int y) => x + y;
 private int Subtracao(int x, int y) => x - y;
 private int Multiplicacao(int x, int y) => x * y;
  }
}
