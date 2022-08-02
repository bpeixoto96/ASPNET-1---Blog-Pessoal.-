/// <summary>
/// <para>Resumo: Classe responsavel por representar tb_postagens no banco.
/// para >
/// <para>Criado por: Generation</para>
/// <para>Versão: 1.0</para>
/// <para>Data: 17/07/2022</para>
/// </summary>

using System.ComponentModel.DataAnnotations.Schema;

[Table("tb_postagens")]
public class PostagemBase
{
    [ForeignKey("fk_usuario")]
    public Usuario Criador { get; set; }

    [ForeignKey("fk_usuario")]
    public Usuario Criador { get; set; }
}