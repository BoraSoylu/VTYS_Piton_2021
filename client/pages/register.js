/** @format */

import Header from "../components/Header/Header";

import { useAuth0 } from "@auth0/auth0-react";
import { useState, useEffect } from "react";

const Register = () => {
  const { loginWithRedirect, logout, user, isAuthenticated } = useAuth0();
  console.log(user, isAuthenticated);

  useEffect(() => {
    const signIn = async () => {
      const response = await fetch("https://localhost:3000/api/auth/citizens/login", {
        method: "POST",
        body: JSON.stringify({
          email: "hs@gmail.com",
          password: "123456",
        }),
      });
      const data = await response.json();
      console.log(data);
    };
    signIn();
  }, []);

  return (
    <>
      <Header />
      <button onClick={() => loginWithRedirect()}>Login</button>
      <button onClick={() => logout()}>Logout</button>
    </>
  );
};

export default Register;
