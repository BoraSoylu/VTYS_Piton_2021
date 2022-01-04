/** @format */

import {
  Input,
  InputGroup,
  Button,
  InputRightElement,
  IconButton,
} from "@chakra-ui/react";
import { useState } from "react";
import Header from "../components/Header/Header";
import { useRouter } from "next/router";
import { ArrowBackIcon } from "@chakra-ui/icons";
import { useToast } from "@chakra-ui/react";

const Login = () => {
  const [email, setEmail] = useState("");
  const toast = useToast();

  const [password, setPassword] = useState("");
  const [show, setShow] = useState(false);
  const handleClick = () => setShow(!show);

  const submitHandler = async () => {
    if (email.length > 0 && password.length > 0) {
      await fetch("https://localhost:44336/api/auth/citizens/login", {
        method: "POST",
        headers: {
          Accept: "application/json",
          "Content-Type": "application/json",
        },
        body: JSON.stringify({
          Email: email,
          Password: password,
        }),
      });
    } else {
      toast({
        title: "Password ve Email",
        description: "Password ve email'i doldurunuz",
        status: "warning",
        duration: 3000,
        isClosable: true,
      });
    }
  };
  const router = useRouter();

  return (
    <div>
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
        <h1
          style={{
            textAlign: "center",
            fontWeight: "bold",
            marginBottom: "20px",
            fontSize: "2rem",
          }}>
          İlgili alanları doldurarak giriş yapabilirsiniz.
        </h1>
        <Input
          variant="outline"
          placeholder="Email"
          value={email}
          onChange={(e) => setEmail(e.target.value)}
        />
        <InputGroup size="md">
          <Input
            pr="4.5rem"
            type={show ? "text" : "password"}
            placeholder="Enter password"
            value={password}
            onChange={(e) => setPassword(e.target.value)}
          />
          <InputRightElement width="4.5rem">
            <Button h="1.75rem" size="sm" onClick={handleClick}>
              {show ? "Hide" : "Show"}
            </Button>
          </InputRightElement>
        </InputGroup>
        <Button
          colorScheme="blue"
          onClick={submitHandler}
          variant="solid"
          style={{ width: "50%", margin: "auto" }}>
          Giriş Yap
        </Button>
      </div>
    </div>
  );
};

export default Login;
