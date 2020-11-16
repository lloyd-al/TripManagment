import React, { Component } from "react";
import { Redirect } from "react-router";
import { Link, withRouter } from "react-router-dom";
import axios from "axios";

export class Delete extends Component {
    constructor(props) {
        super(props);
        this.onCancel = this.onCancel.bind(this);
        this.onConfirmation = this.onConfirmation.bind(this);

        this.state = {
            tripName: "",
            tripDescription: "",
            dateStarted: "",
            dateCompleted: ""
        };
    }

    onCancel(e) {
        const { history } = this.props;
        history.push("/trips");
    }

    onConfirmation(e) {
        const { id } = this.props.match.params;
        const { history } = this.props;

        axios.delete(`api/Trips/Delete/${id}`).then(result => {
                history.push("/trips");
            })
            .catch(error => {
                console.log("Trip could not be deleted!");
            });
    }

    componentDidMount() {
        const { id } = this.props.match.params;

        axios.get(`api/Trips/SingleTrip/${id}`).then(result => {
            const response = result.data;

            this.setState({
                tripName: response.tripName,
                tripDescription: response.tripDescription,
                dateStarted: response.dateStarted,
                dateComplete: response.dateCompleted,
                loading: false
            });
        });
    }

    render() {
        return (
            <div style={{ marginTop: 10 }}>
                <h2>Delete trip confirmation</h2>

                <div class="card">
                    <div class="card-body">
                        <h4 class="card-title">{this.state.tripName}</h4>
                        <p class="card-text">{this.state.tripDescription}</p>
                        <button onClick={this.onCancel} class="btn btn-default">Cancel</button>
                        <button onClick={this.onConfirmation} class="btn btn-danger">Confirm</button>
                    </div>
                </div>
            </div>
        );
    }
}

export default Delete;