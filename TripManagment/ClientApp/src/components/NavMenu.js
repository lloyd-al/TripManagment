import React, { Component } from 'react';
import { Collapse, Container, Navbar, NavbarBrand, NavbarToggler, NavItem, NavLink, Col } from 'reactstrap';
import { Link } from 'react-router-dom';
import './NavMenu.css';

export class NavMenu extends Component {
  static displayName = NavMenu.name;

  constructor (props) {
    super(props);

    this.toggleNavbar = this.toggleNavbar.bind(this);
    this.state = {
      collapsed: true
    };
  }

  toggleNavbar () {
    this.setState({
      collapsed: !this.state.collapsed
    });
  }

  render () {
      return (
          <Col md={12} >
              <header>
                  <Navbar className="navbar-expand-sm navbar-toggleable-sm bg-primary navbar-dark border-bottom box-shadow mb-3" light>
                  <Container>
                    <NavbarBrand tag={Link} to="/">Trip Management</NavbarBrand>
                    <NavbarToggler onClick={this.toggleNavbar} className="mr-2" />
                    <Collapse className="d-sm-inline-flex flex-sm-row-reverse" isOpen={!this.state.collapsed} navbar>
                      <ul className="navbar-nav flex-grow">
                        <NavItem>
                          <NavLink tag={Link} className="text-light" to="/">Home</NavLink>
                        </NavItem>
                        <NavItem>
                          <NavLink tag={Link} className="text-light" to="/Trips">Trip List</NavLink>
                        </NavItem>
                        <NavItem>
                          <NavLink tag={Link} className="text-light" to="/Create">Add Trip</NavLink>
                        </NavItem>
                      </ul>
                    </Collapse>
                  </Container>
                </Navbar>
              </header>
              </Col>
    );
  }
}
