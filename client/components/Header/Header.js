/** @format */

import styles from "./Header.module.css";
import { Link, Button } from "@chakra-ui/react";
import { useEffect, useState } from "react";
import { AddIcon } from "@chakra-ui/icons";
import { useRouter } from "next/router";

import Head from "next/head";

const Header = () => {
  const [user, setUser] = useState(false);

  const router = useRouter();

  //   useEffect(() => {
  //     let token = localStorage.getItem("token");
  //     let decoded = jwt_decode(token);
  //     console.log(
  //       decoded["http://schemas.microsoft.com/ws/2008/06/identity/claims/role"]
  //     );
  //     setToken(
  //       decoded["http://schemas.microsoft.com/ws/2008/06/identity/claims/role"]
  //     );
  //   }, []);

  useEffect(() => {
    const us = localStorage.getItem("isAuth");
    if (us) {
      setUser((prevState) => !prevState);
    }
  }, []);

  return (
    <header className={styles.header_container}>
      <Head>
        <title>Ana Sayfa</title>
      </Head>
      <nav className={styles.nav_container}>
        <h1 className={styles.headerTitle}>İHBAR TAKİP SİSTEMİ</h1>
        <div style={{ display: "flex", alignItems: "center" }}>
          {user && (
            <div style={{ display: "flex", gap: "20px" }}>
              <button>
                {" "}
                <Link
                  onClick={() => {
                    localStorage.removeItem("token");
                    localStorage.removeItem("isAuth");
                  }}
                  style={{
                    color: "white",
                    fontWeight: "800",
                    fontSize: "1.2rem",
                    marginRight: "10px",
                  }}
                  href="/">
                  İhbarlarım
                </Link>
              </button>
              <button>
                {" "}
                <Link
                  onClick={() => {
                    localStorage.removeItem("token");
                    localStorage.removeItem("isAuth");
                  }}
                  style={{
                    color: "white",
                    fontWeight: "800",
                    fontSize: "1.2rem",
                    marginRight: "10px",
                  }}
                  href="/">
                  Çıkış
                </Link>
              </button>
            </div>
          )}

          <img className={styles.logo} src="policeman.png" />
        </div>
      </nav>
    </header>
  );
};

export default Header;
