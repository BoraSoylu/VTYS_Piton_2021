/** @format */

import "../styles/globals.css";
import { Auth0Provider } from "@auth0/auth0-react";

function MyApp({ Component, pageProps }) {
  return (
    <Auth0Provider
      domain="dev-amtv-npj.us.auth0.com"
      clientId="BGdLveuGL7dINpg40K1sR0Xy60Jms5JK"
      redirectUri={process.env.NEXT_PUBLIC_URL}>
      <Component {...pageProps} />
    </Auth0Provider>
  );
}

export default MyApp;
