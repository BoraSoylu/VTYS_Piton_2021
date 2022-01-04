/** @format */

import Header from "../components/Header/Header";

import { useAuth0 } from "@auth0/auth0-react";
import { useState } from "react";
import { useRouter } from "next/router";
import { useToast } from "@chakra-ui/react";

import {
  InputGroup,
  Input,
  InputRightElement,
  InputLeftAddon,
  Button,
  IconButton,
  Radio,
  RadioGroup,
  Stack,
} from "@chakra-ui/react";
import { ArrowBackIcon } from "@chakra-ui/icons";

const Register = () => {
  const toast = useToast();
  const router = useRouter();
  const [value, setValue] = useState("N");
  const [password, setPassword] = useState("");
  const [confirmPassword, setConfirmPassword] = useState("");
  const [birthDate, setBirthDate] = useState("");
  const [email, setEmail] = useState("");
  const [firstName, setFirstName] = useState("");
  const [lastName, setLastName] = useState("");
  const [phoneNumber, setPhoneNumber] = useState("");
  const [show, setShow] = useState(false);
  const handleClick = () => setShow(!show);

  const submitHandler = async () => {
    console.log(
      value,
      password,
      confirmPassword,
      birthDate,
      email,
      firstName,
      lastName,
      phoneNumber
    );
    if (
      password === confirmPassword &&
      password.length > 0 &&
      confirmPassword.length > 0
    ) {
      const response = await fetch(
        "https://localhost:44336/api/auth/citizens/register",
        {
          method: "POST",
          headers: {
            Accept: "application/json",
            "Content-Type": "application/json",
          },
          body: JSON.stringify({
            FirstName: firstName,
            LastName: lastName,
            Email: email,
            PhoneNumber: phoneNumber,
            Gender: value,
            Password: password,
            BirthDate: birthDate,
          }),
        }
      );
      const data = response.json();
      if (data.status) {
        router.push("/login");
      }
    } else if (
      firstName.length > 0 &&
      lastName.length > 0 &&
      email.length > 0 &&
      phoneNumber.length > 0 &&
      value &&
      confirmPassword !== password
    ) {
      toast({
        title: "Password hatası",
        description: "Password ve confirm password aynı olmalı",
        status: "error",
        duration: 3000,
        isClosable: true,
      });
    } else {
      toast({
        title: "Bilgileri doldurunuz",
        description: "Bilgileri doldurunuz",
        status: "error",
        duration: 3000,
        isClosable: true,
      });
    }
  };

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
        <h1
          style={{
            textAlign: "center",
            fontWeight: "bold",
            marginBottom: "20px",
            fontSize: "2rem",
          }}>
          İlgili alanları doldurarak kayıt olabilirsiniz.
        </h1>
        <Input
          variant="outline"
          placeholder="Name"
          value={firstName}
          onChange={(e) => setFirstName(e.target.value)}
        />
        <Input
          variant="outline"
          placeholder="Surname"
          value={lastName}
          onChange={(e) => setLastName(e.target.value)}
        />
        <Input
          variant="outline"
          placeholder="Email"
          value={email}
          onChange={(e) => setEmail(e.target.value)}
        />
        <InputGroup>
          <InputLeftAddon children="+90" />
          <Input
            type="number"
            placeholder="Phone Number"
            value={phoneNumber}
            onChange={(e) => setPhoneNumber(e.target.value)}
          />
        </InputGroup>
        <RadioGroup onChange={setValue} value={value}>
          <Stack direction="row">
            <Radio value="E">Erkek</Radio>
            <Radio value="K">Kadın</Radio>
            <Radio value="N">Belirtmek istemiyorum</Radio>
          </Stack>
        </RadioGroup>
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
        <InputGroup size="md">
          <Input
            pr="4.5rem"
            type={show ? "text" : "password"}
            placeholder="Confirm password"
            value={confirmPassword}
            onChange={(e) => setConfirmPassword(e.target.value)}
          />
          <InputRightElement width="4.5rem">
            <Button h="1.75rem" size="sm" onClick={handleClick}>
              {show ? "Hide" : "Show"}
            </Button>
          </InputRightElement>
        </InputGroup>
        <Input
          variant="outline"
          placeholder="BirthDate"
          type="datetime-local"
          value={birthDate}
          onChange={(e) => setBirthDate(e.target.value)}
        />

        <Button
          colorScheme="blue"
          onClick={submitHandler}
          variant="solid"
          style={{ width: "50%", margin: "auto" }}>
          Kayıt Ol
        </Button>
      </div>
    </>
  );
};

export default Register;
