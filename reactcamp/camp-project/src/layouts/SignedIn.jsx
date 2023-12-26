import React from "react";
import { Dropdown, Menu, Image } from "semantic-ui-react";

export default function SignedIn({ signOut }) {
  return (
    <div>
      <Menu.Item>
        <Image
          avatar
          spaced="right"
          src="https://media.licdn.com/dms/image/D4D03AQG_1M2P1t1E9w/profile-displayphoto-shrink_100_100/0/1691796513613?e=1709164800&v=beta&t=W-LQk2d7h9Ih326wI1J-Wvp0n53IagULwDNOMI9fMV8"
        />
        <Dropdown pointing="top left" text="Alper">
          <Dropdown.Menu>
            <Dropdown.Item text="Bilgilerim" icon="info" />
            <Dropdown.Item onClick={signOut} text="Çıkış Yap" icon="sign-out" />
          </Dropdown.Menu>
        </Dropdown>
      </Menu.Item>
    </div>
  );
}
