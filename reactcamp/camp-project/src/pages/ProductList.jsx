import React, { useState, useEffect } from "react";
import { Item, Button } from "semantic-ui-react";
import ProductService from "../services/productService";
import { Link } from "react-router-dom";

export default function ProductList() {
  const [products, setProducts] = useState([]);

  useEffect(() => {
    // productService'ten tüm ürünleri almak için ProductService class
    ProductService.getAllProducts()
      .then((data) => {
        setProducts(data); // Ürünleri state'e kaydediyoruz
      })
      .catch((error) => {
        console.error("Error fetching products:", error);
      });
  }, []);

  return (
    // for semantic ui

    <div>
      <Item.Group>
        {products.map((product) => (
          <Item key={product.id} style={{ marginTop: "1em" }}>
            <img
              src={product.thumbnail}
              style={{ maxWidth: "200px" }}
              className="card-img-top"
              alt="..."
            />
            <Item.Content>
              <Item.Header><Link to={`/products/${product.id}`}>{product.title}</Link></Item.Header>
              <hr style={{ width: "75px" }}></hr>
              <Item.Meta>
                <span className="brand">Marka: {product.brand}</span>
                <br></br>
                <br></br>
                <span className="price">Fiyat: ${product.price}</span>
                <br></br>
                <br></br>
                <span className="puan">Puan: ⭐{product.rating}</span>
              </Item.Meta>
              <hr style={{ width: "10em" }}></hr>
              <Item.Description>{product.description}</Item.Description>
              <Item.Extra>
                <Button floated="right"><Link to={`/products/${product.id}`}>Detay</Link></Button>
              </Item.Extra>
            </Item.Content>
          </Item>
        ))}
      </Item.Group>
    </div>
  );
}
