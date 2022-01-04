/** @format */

import Header from "../components/Header/Header";

import { useAuth0 } from "@auth0/auth0-react";
import { useState, useEffect } from "react";
import { useRouter } from "next/router";
import {
  InputGroup,
  Input,
  InputLeftAddon,
  Button,
  IconButton,
} from "@chakra-ui/react";
import { ArrowBackIcon } from "@chakra-ui/icons";

const Register = () => {
  const router = useRouter()
  return (
    <>
      <Header />
      <IconButton
        aria-label="Search database"
        icon={<ArrowBackIcon />}
        style={{ marginTop: "40px", marginLeft: "100px" }}
        onClick={() => router.push("/")}
      />
      <div
        style={{
          width: "50%",
          padding: "20px",
          gap: "10px",
          margin: "auto",

          display: "flex",
          flexDirection: "column",
        }}>
        <Input variant="outline" placeholder="Name" />
        <Input variant="outline" placeholder="Surname" />
        <Input variant="outline" placeholder="Email" />
        <InputGroup>
          <InputLeftAddon children="+90" />
          <Input type="tel" placeholder="phone number" />
        </InputGroup>
        <Input variant="outline" placeholder="Flushed" />
        <Input variant="outline" placeholder="Flushed" />
        <Button
          colorScheme="blue"
          variant="solid"
          style={{ width: "50%", margin: "auto" }}>
          Kayıt Ol
        </Button>
      </div>
    </>
  );
};

export default Register;
