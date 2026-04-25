
namespace Foodcall.Domain.Entities {

public class Cliente {

 int ClienteID { get; private set;}
 String Nome {get; private set;}
 int Telefone {get; private set; }


 public Cliente(ClienteID, Nome, Telefone) {
    this.ClienteID = ClienteID;
    this.Nome = Nome;
    this.Telefone = Telefone;
 }

}
}