/* selecionar o input com o numero digitado */
// let valorDigitado = document.querySelector('#valor')

/* Obtenm a referência do campo de entrada */
let valorInserido = document.getElementById("#valorInserido").value;

/* converter de string para float */

valorInserido = parseFloat(valorInserido);

/* Para o cursos piscar na seção. */
 window.addEventListener("load", function() {
     valorInserido.focus();
 });


/* Selecionar os elementos no select*/

let moedaSelecionada1 = document.getElementById('#floatingSelect1')

let moedaSelecionada2 = document.getElementById('#floatingSelect2')

/* Seleciona o botao*/
let btnConverter = document.querySelector('#botao')
{

}

/* let resultado = document.querySelector -------------------- */

let valorDoDolar = 5.01
let valorDoEuro = 5.41
let valorDoReal = 1.00
let valorDoLibra = 6.26


/* Converter para outra moeda (dolar) */

switch (moedaSelecionada1) {


    case value = 'Euro':
        resultado = value * valorDoEuro / moedaSelecionada2
        moedaSelecionada1.toLocaleString('en', { style: 'currency', currency: 'USD' })

        break
}


/*Converte a string digitada para float*/

btnConverter.addEventListener('click', function () {

    valor = parseFloat(valorInserido.value)

    for (let i = 0; i < moedaSelecionada1.clientHeight; i++) {
        if (moedaSelecionada1[i].seletcted) {
            moedaEstrangeira = moedaSelecionada2[i].value
            console.log(moeda)
        }
    }
}
)

        // case value='Dólar' &&  moedaSelecionada2 : 'USD - Euro';
        //     resultado : valorDoEuro =  value / valorDoDolar
        //    moedaSelecionada1.toLocaleString('en-US', {style: 'currency', currency:'USD'})

        // break

        // case value='Real':
        //     moedaSelecionada2 =  value / valorDoDoReal
        //    moedaSelecionada1.toLocaleString('pt-BR', {style: 'currency', currency:'BRA'})

        // break

        // case value='Libra':
        //     moedaSelecionada2 =  value / valorDoLibra
        //    moedaSelecionada1.toLocaleString('en-US', {style: 'currency', currency:'USD'})
        // break;
