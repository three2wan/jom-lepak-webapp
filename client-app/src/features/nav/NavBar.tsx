import React from 'react';
import { Menu, Container, Button } from 'semantic-ui-react';

interface IProps {
  openCreateForm: () => void;
}

const NavBar: React.FC<IProps> = ({openCreateForm}) => {
  return (
    <Menu fixed='top' inverted>
      <Container>
        <Menu.Item header>
            <img src="/assets/logo.png" alt="logo" style={{marginRight: 10}}/>
            Jom Lepak!
        </Menu.Item>
        <Menu.Item name='Senarai Aktiviti' />
        <Menu.Item>
            <Button onClick={openCreateForm} positive content='Cipta Aktiviti' />
        </Menu.Item>
      </Container>
    </Menu>
  );
};

export default NavBar;
