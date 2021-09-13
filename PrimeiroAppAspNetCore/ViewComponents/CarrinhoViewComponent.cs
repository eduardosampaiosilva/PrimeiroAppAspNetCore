using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiroAppAspNetCore.ViewComponents
{
    //Esse é nome que vai chamar o componente nas outras telas
    [ViewComponent(Name = "Carrinho")]

    public class CarrinhoViewComponent : ViewComponent
    {
        //simulando uma busca no banco de dados
        public int Itenscarrinho { get; set; }

        //simula que trouxe uma quantidade 3 do banco de dados
        public CarrinhoViewComponent() {
            Itenscarrinho = 3;
        }

        //tem que ter este método invoke para funcionar corretaente  
        public async Task<IViewComponentResult> InvokeAsync() {
            return View(Itenscarrinho);
        }
    }
}
