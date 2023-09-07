//let productCart = document.querySelector(".product-cart");
//const url = '/api/Gpus';
//const test = fetch(url)
//                .then((response) => {
//                    if (!response.ok) {
//                        throw new Error(`HTTP error: ${response.status}`);
//                    }
//                    return response.json();
//                });

//let fo = JSON.parse(test);
//console.log(fo);
///*    .then((json) => JSON.parse(json));*/

const urlGpu = '/api/Gpus';

function createNode(element) {
    return document.createElement(element);
}

function append(parent, child) {
    return parent.appendChild(child);
}
//function generationCart(obj) {
//    const divProductCart = createNode('div');
//    const divImgCart = createNode('div');
//    const abtnProduct = createNode('a');
//    const pPrice = createNode('p');
//    const aBtnBuy = createNode('a');
//    const aClear = createNode('a');
//    // const imgClear =createNode('img');
//    divProductCart.className = 'product-cart';
//    divImgCart.className = 'img-cart';
//    abtnProduct.className = 'btn-product';
//    pPrice.className = 'p-price';
//    aBtnBuy.className = 'btn-buy';

//    append(aClear, imgClear);
//    append(divImgCart, aClear);
//    append(divProductCart, divImgCart);
//    append(divProductCart, abtnProduct);
//    append(divProductCart, aBtnBuy);
//    append(divProductCart, pPrice);
//}


let imgClear = createNode('img');
let aClear = createNode('a');
let divProductCart = createNode('div');
let divImgCart = createNode('div');
let abtnProduct = createNode('a');
let pPrice = createNode('p');
let aBtnBuy = createNode('a');


fetch(urlGpu)
    .then((response) => response.json())
    .then(data => {
        console.log(data);
        const ell = document.querySelector('.products-list');
        for (let i = 0; i <= data.length; i++) {
            //let imgClear = createNode('img');
            //let aClear = createNode('a');
            //let divProductCart = createNode('div');
            //let divImgCart = createNode('div');
            //let abtnProduct = createNode('a');
            //let pPrice = createNode('p');
            //let aBtnBuy = createNode('a');

            divProductCart.className = 'product-cart';
            divImgCart.className = 'img-cart';
            abtnProduct.className = 'btn-product';
            pPrice.className = 'p-price';
            aBtnBuy.className = 'btn-buy';

            /*imgClear.src = data[i]["imageName"];*/
            abtnProduct.textContent = data[i]["name"];
            pPrice.textContent = data[i]["price"];
            aBtnBuy.textContent = 'Купить';

            aClear.appendChild(imgClear);
            divImgCart.appendChild(aClear);
            divProductCart.appendChild(divImgCart);
            divProductCart.appendChild(abtnProduct);
            divProductCart.appendChild(aBtnBuy);
            divProductCart.appendChild(pPrice);

            ell.appendChild(divProductCart);


        }


    });







