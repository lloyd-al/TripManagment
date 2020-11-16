import React from 'react';
import { Col, Row } from 'react-bootstrap';
import '../Home.css';

const Home = (props) => {
    return (
        <div>
        <Row>
            <Col md={12}>
                <div className={'homeText'}>
                    "WELCOME TO TRIP MANAGEMENT"
                </div>
            </Col>
            </Row>
        </div>
    )
}

export default Home;
