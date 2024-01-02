import {Form, Formik } from "formik";
import React from "react";
import * as Yup from "yup";
import { Button } from "semantic-ui-react";
import ATextInput from "../utilities/customFromControls/ATextInput";

export default function ProductAdd() {
  const initialValues = { title: "", price: 10 };

  const schema = Yup.object({
    title: Yup.string().required("Ürün adı zorunlu"),
    price: Yup.number().required("Ürün fiyatı zorunludur"),
  });
  return (
    <div>
      <Formik
        initialValues={initialValues}
        validationSchema={schema}
        onSubmit={(values) => {}}
      >
        <Form className="ui form" style={{ marginTop: "1em" }}>
          <ATextInput name="title" placeholder="Ürün adı" />
          <ATextInput name="price" placeholder="Ürün fiyatı" />
          <Button color="green" type="submit">
            Ekle
          </Button>
        </Form>
      </Formik>
    </div>
  );
}
