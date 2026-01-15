namespace Aplicando_Principios_SOLID2
{
    public interface ICalculaDescontoStatusContaFactory
    {
        ICalculaDescontoStatusConta GetCalculaDescontoStatusConta(StatusContaCliente statusContaCliente);
    }
}
