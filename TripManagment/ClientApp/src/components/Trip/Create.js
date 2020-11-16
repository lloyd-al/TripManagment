import React, { Component } from 'react';
import { v4 as uuidv4 } from 'uuid';
import axios from 'axios';

import './Trip.css'

class Create extends Component {
    constructor(props) {
        super(props);
        this.onChangeName = this.onChangeName.bind(this);
        this.onChangeDescription = this.onChangeDescription.bind(this);
        this.onChangeDateStarted = this.onChangeDateStarted.bind(this);
        this.onChangeDateCompleted = this.onChangeDateCompleted.bind(this);
        this.onSubmit = this.onSubmit.bind(this);

        this.state = {
            tripName: '',
            tripDescription: '',
            dateStarted: '',
            dateCompleted: ''
        };
    }

    onChangeName(e) {
        this.setState({
            tripName: e.target.value
        });
    }

    onChangeDescription(e) {
        this.setState({
            tripDescription: e.target.value
        });
    }

    onChangeDateStarted(e) {
        this.setState({
            dateStarted: e.target.value
        });
    }

    onChangeDateCompleted(e) {
        this.setState({
            dateCompleted: e.target.value
        });
    }

    onSubmit(e) {
        e.preventDefault();
        const { history } = this.props;

        let trip =
        {
            Id: uuidv4(),
            tripName: this.state.tripName,
            tripDescription: this.state.tripDescription,
            dateStarted: this.state.dateStarted,
            dateCompleted: this.state.dateCompleted ? this.state.dateCompleted : null
        }
        console.log("Trip data - ", trip)

        axios.post("api/Trips/Create", trip)
            .then(result => {
                history.push('/trips');
            }).catch(function (error) {
                console.log('Something went wrong! ', error);
            });
    }

    render() {
        return (
            <div className="trip-from" >
                <h3>Add new trip</h3>
                <form onSubmit={this.onSubmit}>

                    <div className="form-group">
                        <label>Trip name:  </label>
                        <input type="text" className="form-control" value={this.state.tripName} onChange={this.onChangeName} />
                    </div>

                    <div className="form-group">
                        <label>Trip description: </label>
                        <textarea type="text" className="form-control" value={this.state.tripDescription} onChange={this.onChangeDescription} />
                    </div>

                    <div className="row">
                        <div className="col col-md-6 col-sm-6 col-xs-12">
                            <div className="form-group">
                                <label>Date of start:  </label>
                                <input type="date" className="form-control" value={this.state.dateStarted} onChange={this.onChangeDateStarted} />
                            </div>
                        </div>

                        <div className="col col-md-6 col-sm-6 col-xs-12">
                            <div className="form-group">
                                <label>Date of completion:  </label>
                                <input type="date" className="form-control" value={this.state.dateCompleted} onChange={this.onChangeDateCompleted} />
                            </div>
                        </div>
                    </div>


                    <div className="form-group">
                        <input type="submit" value="Add trip" className="btn btn-primary" />
                    </div>

                </form>
            </div>
        );
    }
}

export default Create;