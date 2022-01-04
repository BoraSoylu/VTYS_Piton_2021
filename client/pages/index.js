/** @format */

import { useRouter } from "next/router";
import { useEffect, useState } from "react";
import Header from "../components/Header/Header";
import { Button, ButtonGroup } from "@chakra-ui/react";
import { ArrowForwardIcon, DeleteIcon } from "@chakra-ui/icons";

export default function Home() {
  const router = useRouter();
  return (
    <div>
      <Header />
      <h2
        style={{
          textAlign: "center",
          fontWeight: "bold",
          fontSize: "2rem",
          marginTop: "20px",
        }}>
        Takip Sistemine Hoşgeldiniz.
      </h2>
      <p
        style={{
          textAlign: "center",
          fontWeight: "600",
          marginTop: "90px",
          fontSize: "1.2rem",
        }}>
        Yaşadığınız şehirde gördüğünüz problemleri bildirebildiğiniz bir
        platform.
      </p>

      <p
        style={{
          textAlign: "center",
          fontWeight: "600",
          marginTop: "10px",
          fontSize: "1.2rem",
        }}>
        Hesabınızı oluşturduktan sonra giriş yaparak, mevcut probleminizi
        paylaşabilirsiniz.
      </p>
      <div
        style={{
          display: "flex",
          justifyContent: "center",
          marginTop: "50px",
          gap: "80px",
        }}>
        <img
          style={{ width: "100px", height: "100px" }}
          src="police-badge.png"
        />
        <img style={{ width: "100px", height: "100px" }} src="police-car.png" />
        <img style={{ width: "100px", height: "100px" }} src="police.png" />
      </div>

      <div
        style={{
          display: "flex",
          justifyContent: "center",
          gap: "60px",
          marginTop: "40px",
        }}>
        <Button
          rightIcon={<ArrowForwardIcon />}
          colorScheme="telegram"
          variant="outline"
          onClick={() => router.push("/login")}>
          Giriş Yap
        </Button>
        <Button
          rightIcon={<ArrowForwardIcon />}
          colorScheme="twitter"
          variant="outline"
          onClick={() => router.push("/register")}>
          Kayıt Ol
        </Button>
      </div>
    </div>
  );
}
