/// <summary>
/// <para>Resumo: Classe responsavel por representar tb_postagens no banco.
/// para >
/// <para>Criado por: Generation</para>
/// <para>Versão: 1.0</para>
/// <para>Data: 17/07/2022</para>
/// </summary>

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("tb_postagens")]
public class Postagem : PostagemBase
{
    private Tema tema;
    #region Atributos
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public string Foto { get; set; }

    #endregion

    public Tema GetTema()
    {
        return tema;
    }

    public void SetTema(Tema value)
    {
        tema = value;
    }

    public Postagem(Usuario criador)
    {
        this.Criador = criador;
    }

    [ForeignKey("fk_tema")]
    public Tema Tema { get; set; }

    public Postagem(Tema tema) => this.SetTema(tema);
}
