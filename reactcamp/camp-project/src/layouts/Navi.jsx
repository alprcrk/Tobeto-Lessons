import React, { useState } from "react";
import { useNavigate } from 'react-router-dom';
import CartSummary from "./CartSummary";
import { Container, Menu } from "semantic-ui-react";
import SignedOut from "./SignedOut";
import SignedIn from "./SignedIn";

export default function Navi() {
  const [isAuthenticated, setisAuthenticated] = useState(true);
  const navigate = useNavigate();

  function handleSignOut() {
    setisAuthenticated(false);
    navigate('/');
  }

  function handleSignIn() {
    setisAuthenticated(true);
  }

  return (
    <div>
      <Menu inverted fixed="top" >
        <Container >
          <Menu.Item name="home" />
          <Menu.Item name="messages" />

          <Menu.Menu position="right">
            <CartSummary />
            {isAuthenticated ? (
              <SignedIn signOut={handleSignOut} bisey="1" />
            ) : (
              <SignedOut signIn={handleSignIn} />
            )}
          </Menu.Menu>
        </Container>
      </Menu>
    </div>
  );
}
