/** @format */

import Head from "next/head";
import { Box, Badge, Button } from "@chakra-ui/react";
import { StarIcon, ArrowForwardIcon } from "@chakra-ui/icons";
import Header from "../components/Header/Header";

const Complains = () => {
  const properties = [
    {
      imageUrl: "https://i.sozcu.com.tr/wp-content/uploads/2019/04/04/h5.jpg",
      imageAlt: "Rear view of modern home with pool",
      beds: "Eskişehir",
      baths: "Odunpazarı",
      title: "Sokakta yardıma muhtaç bir köpek bulunuyor. İlgilenir misiniz?",
      formattedPrice: "Durum: ",
      reviewCount: "Acil",
      rating: 4,
      status: "Bekliyor",
    },
    {
      imageUrl:
        "https://st4.depositphotos.com/1016729/22126/i/600/depositphotos_221260388-stock-photo-damaged-asphalt-road-with-potholes.jpg",
      imageAlt: "Rear view of modern home with pool",
      beds: "Eskişehir",
      baths: "Tepebaşı",
      title: "Buradaki kaldırımda bir çökme olmuş. İnsanlar düşebilir.",
      formattedPrice: "Durum: ",
      reviewCount: "Acil",
      rating: 4,
      status: "Yönlendirildi",
    },
  ];

  const complainsAll = properties.map((property) => (
    <Box maxW="sm" borderWidth="1px" borderRadius="lg" overflow="hidden">
      <img src={property.imageUrl} alt={property.imageAlt} style={{height:"200px", width:"100%"}} />

      <Box p="6">
        <Box display="flex" alignItems="baseline">
          <Badge borderRadius="full" px="2" colorScheme="teal">
            {property.status}
          </Badge>
          <Box
            color="gray.500"
            fontWeight="semibold"
            letterSpacing="wide"
            fontSize="xs"
            textTransform="uppercase"
            ml="2">
            {property.beds} &bull; {property.baths}
          </Box>
        </Box>

        <Box
          mt="1"
          fontWeight="semibold"
          as="h4"
          lineHeight="tight"
          isTruncated>
          {property.title}
        </Box>

        <Box>
          {property.formattedPrice}
          <Box as="span" color="gray.600" fontSize="sm">
            {property.reviewCount}
          </Box>
        </Box>
        <Button
          rightIcon={<ArrowForwardIcon />}
          colorScheme="teal"
          variant="outline">
          Detay
        </Button>
      </Box>
    </Box>
  ));

  return (
    <div>
      <Head>
        <title>İhbarlarım</title>
      </Head>
      <Header />
      <h1
        style={{
          fontSize: "1.5rem",
          fontWeight: "800",
          textAlign: "center",
          marginTop: "30px",
        }}>
        İhbarlarım
      </h1>
      <div
        style={{
          padding: "30px",
          margin: "auto",
          display: "flex",
          gap: "20px",
          justifyContent: "space-evenly",
        }}>
        {complainsAll}
      </div>
    </div>
  );
};

export default Complains;
