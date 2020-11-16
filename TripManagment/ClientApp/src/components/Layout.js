import React from 'react';
import { Container} from 'reactstrap';
import { NavMenu } from './NavMenu';


const Layout = (props) => {
    return (
        <Container>
            <NavMenu />
            <main>
                {props.children}
            </main>
        </Container>
    )
}
export default Layout;

