/** @format */

import { useState, useEffect } from "react";
import { DeleteIcon, AddIcon } from "@chakra-ui/icons";
import Header from "../components/Header/Header";
import { Button, Select, Textarea, Input } from "@chakra-ui/react";
import jwt_decode from "jwt-decode";

const Dashboard = () => {
  const [selectedImage, setSelectedImage] = useState("");
  const [show, setShow] = useState(false);
  const [selectedComplainType, setSelectedComplainType] = useState(null);
  const [desc, setDesc] = useState("");
  //   useEffect(() => {
  //     let token = localStorage.getItem("token");
  //     let decoded = jwt_decode(token);
  //     console.log(
  //       decoded["http://schemas.microsoft.com/ws/2008/06/identity/claims/role"]
  //     );
  //   }, []);
  const [complainTypes, setComplainTypes] = useState([
    {
      typeID: 3,
      typeName: "ComplaintType3",
    },
    {
      typeID: 2,
      typeName: "ComplaintType2",
    },
    {
      typeID: 1,
      typeName: "ComplaintType1",
    },
  ]);

  console.log(desc);

  useEffect(() => {
    // const response = await fetch(
    //   "https://localhost:44336/api/complainttypes/getall"
    // );
    // const types = await response.json();
    // setComplainTypes(types.data);
  }, []);

  return (
    <div>
      <Header />
      <div
        style={{
          display: "flex",
          flexDirection: "column",
          justifyContent: "center",
          alignItems: "center",
          margin: "40px auto",
          gap: "20px",
          width: "50%",
          paddingTop: "20px",
        }}>
        <h2
          style={{ fontSize: "2rem", fontWeight: "800", textAlign: "center" }}>
          Gerekli bilgileri belirterek ihbar oluşturabilirsiniz.
        </h2>
        <Select
          placeholder="Şikayet Türünü Seçiniz."
          value={selectedComplainType}
          onChange={(e) => setSelectedComplainType(e.target.value)}>
          {complainTypes?.map(({ typeName }) => (
            <option value={typeName}>{typeName}</option>
          ))}
        </Select>
        <Textarea
          placeholder="İhbarın detaylarını giriniz."
          value={desc}
          onChange={(e) => setDesc(e.target.value)}
        />
        <Input variant="outline" placeholder="District" />
        <Input variant="outline" placeholder="City" />
        <Input variant="outline" placeholder="Street" />
        <Input variant="outline" placeholder="NeighbourHood" />
        <Input variant="outline" placeholder="AddressDescription" />
        <Input variant="outline" placeholder="Longitude" />
        <Input variant="outline" placeholder="Latitude" />
        <Input variant="outline" placeholder="ZipCode" />
        
        <input
          type="file"
          name="myImage"
          placeholder="Resim Yükle"
          onChange={(event) => {
            console.log(event.target.files[0]);
            setSelectedImage(event.target.files[0]);
          }}
        />
        {selectedImage && (
          <div>
            <img
              alt="not fount"
              width={"250px"}
              src={URL.createObjectURL(selectedImage)}
            />
            <br />

            <Button
              onClick={() => setSelectedImage(null)}
              leftIcon={<DeleteIcon />}
              colorScheme="red"
              variant="solid">
              Remove the Image
            </Button>
          </div>
        )}
        <Button
          onClick={() => setSelectedImage(null)}
          leftIcon={<AddIcon />}
          colorScheme="blue"
          variant="solid">
          İhbar Oluştur
        </Button>
      </div>
    </div>
  );
};

export default Dashboard;
