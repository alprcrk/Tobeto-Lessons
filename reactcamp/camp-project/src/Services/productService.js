import axios from "axios";

const ProductService = {
  getAllProducts: async () => {
    try {
      const response = await axios.get("https://dummyjson.com/products");
      if (response && response.data && response.data.products) {
        return response.data.products; // Tüm ürünleri döndür
      }
      return []; // Veri yoksa boş bir dizi döndür
    } catch (error) {
      console.error("Error fetching products:", error);
      return []; // Hata oluştuğunda boş bir dizi döndür
    }
  },
  getProductById: async (id) => {
    try {
      const response = await axios.get(`https://dummyjson.com/products/${id}`);
      if (response && response.data) {
        return response.data; // Belirli bir ID'ye sahip ürünü döndür
      }
      return null; // Veri yoksa veya hata oluştuysa null döndür
    } catch (error) {
      console.error(`Error fetching product with ID ${id}:`, error);
      return null; // Hata oluştuğunda null döndür
    }
  },
};
export default ProductService;
