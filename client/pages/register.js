/** @format */

import Header from "../components/Header/Header";

import { useAuth0 } from "@auth0/auth0-react";

const Register = () => {
  const { loginWithRedirect, logout, user, isAuthenticated } = useAuth0();
  console.log(user, isAuthenticated);

  return (
    <>
      <Header />
      <button onClick={() => loginWithRedirect()}>Login</button>
      <button onClick={() => logout()}>Logout</button>
    </>
  );
};

export default Register;
