/** @format */

import { useState } from "react";
import { DeleteIcon } from "@chakra-ui/icons";


const Dashboard = () => {
  const [selectedImage, setSelectedImage] = useState("");

  return (
    <div>
      <div
        style={{
          display: "flex",
          flexDirection: "column",
          justifyContent: "center",
          marginTop: "40px",
          width: "50%",
        }}>
        
        <input
          type="file"
          name="myImage"
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
      </div>
    </div>
  );
};

export default Dashboard;
