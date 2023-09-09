
//const urlGpu = '/api/Gpus';
const urlGpu = '/catalog/gpu/';


function createNode(element) {
    return document.createElement(element);
}

function append(parent, child) {
    return parent.appendChild(child);
}
const btnfilter = document.getElementById("btnFilter");

// const fornData = {
//     minPrice,
//     maxPrice,
//     manf,
//     prod
// }
let genUrl
function formChange(){
    const minp = document.getElementById("minPrice");
    const maxp = document.getElementById("maxPrice");
    const manufac = document.getElementById("manufactur");
    const procProd = document.getElementById("proc-prod");
    genUrl = `/catalog/gpu/?minPrice=${minp.value}&maxPrice=${maxp.value}&manf=${manufac.value}&prod=${procProd.value}`
    console.log(genUrl);
    console.log(minp.value);
    console.log(maxp.value);
}

btnfilter.addEventListener("click", formChange());
//let imgClear = createNode('img');
//let aClear = createNode('a');
//let divProductCart = createNode('div');
//let divImgCart = createNode('div');
//let abtnProduct = createNode('a');
//let pPrice = createNode('p');
//let aBtnBuy = createNode('a');
const ell = document.querySelector('.products-list');
//divProductCart.className = 'product-cart';
//divImgCart.className = 'img-cart';
//abtnProduct.className = 'btn-product';
//pPrice.className = 'p-price';
//aBtnBuy.className = 'btn-buy';
console.log(urlGpu);
fetch(genUrl)
    .then((response) => response.json())
        .then((data) => {

            console.log(data);
            console.log(urlGpu);
        
            for (let i = 0; i < data.length; i++)
            {
                
                /*console.log(data[i]);*/

                let pattern = `<div class="product-cart">
                                    <div class="img-cart">
                                        <a href="#">
                                            <img src="/images/gpu/${data[i].imageNamePng}" alt="product-image">
                                        </a>
                                    </div>
                                    <a class="btn-product" href="#">${data[i].name}</a>
                                    <p class="p-price">${data[i].price}&nbsp;₽</p>
                                    <a class="btn-buy" href="#">Купить</a>
                                </div>`;

                ell.insertAdjacentHTML("afterbegin", pattern);


            }    


        })







