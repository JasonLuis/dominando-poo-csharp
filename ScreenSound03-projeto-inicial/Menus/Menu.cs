using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class Menu
{
    public void ExibirTituloDaOpcao(string titulo)
    {
        int quantidadeDeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }

    // palavra reservada: virtual
    // Usamos essa palavra quando temos um metodo na Classe ancestral para permitir ser alterado nas classes Descendentes.

    // palavra reservada: override
    // usamos essa palavra quando desejamos alterar o metodo herdado da classe ancestral
    public virtual void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
    }
}