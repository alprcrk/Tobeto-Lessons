import React, { useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import { Button, Card, Image } from "semantic-ui-react";
import ProductService from "../services/productService";

export default function ProductDetail() {
  let { id } = useParams();
  const [product, setProduct] = useState({});

  useEffect(() => {
    ProductService.getProductById(id)
      .then((data) => {
        setProduct(data);
      })
      .catch((error) => {
        console.error("Error fetching products:", error);
      });
  });

  return (
    <div>
      <Card.Group style={{ marginTop: "1em" }}>
        <Card fluid>
          <Card.Content>
            <Image.Group size="small">
              {product.images &&
                product.images.map((image, index) => (
                  <Image
                    key={index}
                    src={image}
                    style={{ cursor: "pointer" }}
                  />
                ))}
            </Image.Group>
            <Card.Header>{product.title}</Card.Header>
            <Card.Meta>{product.category}</Card.Meta>
            <Card.Description>{product.description}</Card.Description>
            <span className="price">Fiyat: ${product.price}</span>
          </Card.Content>
          <Card.Content extra>
            <div className="ui two buttons">
              <Button basic color="green">
                Approve
              </Button>
              <Button basic color="red">
                Decline
              </Button>
            </div>
          </Card.Content>
        </Card>
      </Card.Group>
    </div>
  );
}
