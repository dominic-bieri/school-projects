'use strict';
import {Application, Router, send, REDIRECT_BACK} from "https://deno.land/x/oak@v6.3.1/mod.ts";
import {renderFileToString, renderFile} from "https://deno.land/x/dejs@0.9.3/mod.ts";
import {isEmail} from "https://deno.land/x/deno_validator/mod.ts";
const Products = JSON.parse(Deno.readTextFileSync(Deno.cwd()+"/backend/products/products.json")); 

const app = new Application();
const router = new Router();

app.addEventListener('listen', () => {
  console.log("Server läuft");
});

router.get("/", async (context) => {
  try {
    console.log("\nhomepage");
    let totalProducts = 0;
    for(let i = 0; i < Products.length; i++)
    {
        if(context.cookies.get(Products[i].id))
        {
          totalProducts += parseInt(context.cookies.get(Products[i].id));
        }
    }
    context.cookies.set("totalProducts", totalProducts);
    console.log("\ncookie set")
    context.response.body = await renderFile(Deno.cwd() + "/frontend/home.ejs", {Products:Products, totalProducts:totalProducts});
    context.response.type = "html";
  } catch (error) {
      console.log(error);
  }
});

router.post("/validation", async (context)=>{
  try{
    const body = await context.request.body().value;
    const firstname = body.get("firstname");
    const lastname = body.get("lastname");
    const email= body.get("email")
    if(isEmail(email)){
      context.cookies.set("firstname", firstname);
      context.cookies.set("lastname", lastname);
      context.cookies.set("email", email);
      context.response.redirect("http://localhost:8000/confirmation");
    }
    else{
      context.response.redirect("http://localhost:8000/checkout")
    }
  }
  catch(error){
    
  }
})

router.get("/shoppingCart", async (context) => {
  try {
    let itemDictionary = new Map();
    for(let i = 0; i< Products.length; i++){
        if(context.cookies.get(Products[i].id)){
            itemDictionary.set(Products[i].id, {itemName: Products[i].productName, itemCart: context.cookies.get(Products[i].id), itemOffer: Products[i].specialOffer});
        }
    }
    context.response.body = await renderFileToString(Deno.cwd() + 
        "/frontend/shoppingCart.ejs", { itemDictionary: itemDictionary });
    context.response.type = "html"
  } catch (error) {
      console.log(error);
  }
});


router.post("/product", async (context) => {
  try {
    console.log("Hallo");
    const body = await context.request.body().value;
    console.log("Body context: "+body);
    const productId = body.get("productId");
    console.log("Product ID: "+productId);
    const totalProducts = (context.cookies.get("totalProducts")) ? context.cookies.get("totalProducts") : 0;
    context.response.body = await renderFileToString(Deno.cwd() + 
        "/frontend/product.ejs", { productId: productId, Products: Products, totalProducts: totalProducts});
    context.response.type = "html";
    
  } catch (error) {
      console.log(error);
  }
});

router.post("/addProduct", async (context) => {
  try {
      console.log("\naddProduct:");
      const body = await context.request.body().value;
      const productId = body.get("productId");
      const amount = parseInt(body.get("amount"));
      console.log("Product Id: "+productId+", Amount: "+amount);

      if(!context.cookies.get(productId)){
          console.log("productId undefined");
          context.cookies.set(productId, amount);
      }
      else{
          console.log("productId defined");
          const temp = parseInt(context.cookies.get(productId))+amount;
          context.cookies.set(productId, temp);
      }
      console.log("Cookie content of "+productId+": "+context.cookies.get(productId));
      context.response.redirect("http://localhost:8000");     
  } catch (error) {
      console.log(error);
  }
}); 

router.post("/editAmount", async (context) => {
  try {
    
      const body = await context.request.body().value;

      if(body.get("product-plus"))
      {
          const item = body.get("product-plus");
          const value = parseInt(context.cookies.get(item))+1;
          context.cookies.set(item, value);
      }
      if(body.get("product-minus"))
      {
          const item = body.get("product-minus");
          const value = parseInt(context.cookies.get(item)) > 0 ? parseInt(context.cookies.get(item))-1 : 0;
          context.cookies.set(item, value);
      }


      context.response.redirect("http://localhost:8000/shoppingCart");
  } catch (error) {
      console.log(error);
  }
});

router.get("/checkout", async (context) => {
  try {
      context.response.body = await renderFileToString(Deno.cwd() + 
      "/frontend/checkout.ejs", {});
     
      context.response.type = "html";
  } catch (error) {
      console.log(error);
  }
});

router.get("/confirmation", async (context) => {
  try {
      const body = await context.request.body().value;
      const firstname = context.cookies.get("firstname");
      const lastname =  context.cookies.get("lastname");
      const email= context.cookies.get("email");

      for(let i = 0; i < Products.length; i++)
      {
          if(context.cookies.get(Products[i].id))
          {
              context.cookies.set(Products[i].id, 0);
          }
      }
      context.response.body = await renderFileToString(Deno.cwd() + 
          "/frontend/confirmation.ejs", { firstName: firstname, lastName: lastname, email: email});
      context.response.type = "html";
  } catch (error) {
      console.log(error);
  }
});

app.use(router.routes());
app.use(router.allowedMethods());

app.use(async (context) => {
  await send(context, context.request.url.pathname, {
  root: `${Deno.cwd()}/backend/products`,
  });
  });

await app.listen({port:8000});