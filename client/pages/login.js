/** @format */

import {
  Input,
  InputGroup,
  Button,
  InputRightElement,
  IconButton,
} from "@chakra-ui/react";
import { useState, useEffect } from "react";
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
  const router = useRouter();
  const submitHandler = async () => {
    if (email.length > 0 && password.length > 0) {
      // const response = await fetch(
      //   "https://localhost:44336/api/auth/citizens/login",
      //   {
      //     method: "POST",
      //     headers: {
      //       Accept: "application/json",
      //       "Content-Type": "application/json",
      //     },
      //     body: JSON.stringify({
      //       Email: email,
      //       Password: password,
      //     }),
      //   }
      // );
      // const data = await response.json();
      // if (data.success) router.push("/dashboard");
      // localStorage.setItem("token", data?.data.accessToken);
      localStorage.setItem(
        "token",
        "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1laWRlbnRpZmllciI6IjEwMDgiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3JvbGUiOiJDaXRpemVuIiwibmJmIjoxNjQxMzI3ODk5LCJleHAiOjE2NDE5MzI2OTl9.vL71jB0hXJMtinqL7f8Rl6cQgs8Zl_kQUGQMJZmZQT0"
      );
      localStorage.setItem("isAuth", true);
      router.push("/dashboard");
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
        <h2
          style={{
            color: "blue",
            textAlign: "center",
            fontWeight: "bold",
            marginBottom: "20px",
            fontSize: "2rem",
          }}>
          Vatandaş Girişi
        </h2>
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
