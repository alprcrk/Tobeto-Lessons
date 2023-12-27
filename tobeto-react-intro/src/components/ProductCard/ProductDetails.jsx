import React, { useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import axios from "axios";

export default function ProductDetails() {
  let { id } = useParams();
  const [productDetail, setProductDetail] = useState(null);

  const getProduct = async () => {
    try {
      let response = await axios.get(`https://dummyjson.com/products/${id}`);
      setProductDetail(response.data);
    } catch (error) {
      console.error("Ürün bulunamadı:", error);
    }
  };

  useEffect(() => {
    getProduct();
  }, [id]);

  return (
    <div className='card'>
      <div className='card-body'>
        {productDetail && (
            <div class="card mb-3" >
            <div class="row g-0">
                <div class="col-md-4">
                <img src={productDetail.thumbnail} class="img-fluid rounded-start" alt="..."></img>
                </div>
                <div class="col-md-8">
                <div class="card-body" style={{textAlign: "center"}}>
                    <h5 class="card-title">{productDetail.title}</h5>
                    <p class="card-text">{productDetail.category}</p>
                    <p class="card-text">{productDetail.description}</p>
                    <p class="card-text"><small class="text-body-secondary">${productDetail.price}</small></p>
                </div>
                </div>
            </div>
            </div>
        )}
      </div>
    </div>
  );
}
