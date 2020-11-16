import React, { Component } from 'react';
import axios from 'axios';

import './Trip.css'

class Update extends Component {
    constructor(props) {
        super(props);
        this.onChangeName = this.onChangeName.bind(this);
        this.onChangeDescription = this.onChangeDescription.bind(this);
        this.onChangeDateStarted = this.onChangeDateStarted.bind(this);
        this.onChangeDateCompleted = this.onChangeDateCompleted.bind(this);
        this.onUpdateCancel = this.onUpdateCancel.bind(this);
        this.onSubmit = this.onSubmit.bind(this);

        this.state = {
            tripName: '',
            tripDescription: '',
            dateStarted: '',
            dateCompleted: ''
        };
    }

    componentDidMount() {
        const { id } = this.props.match.params;

        axios.get(`api/Trips/GetById/${id}`)
            .then(result => {
                const response = result.data;
                this.setState({
                    tripName: response.tripName,
                    tripDescription: response.tripDescription,
                    dateStarted: new Date(response.dateStarted).toISOString().slice(0,10),
                    dateCompleted: response.dateCompleted ? new Date(response.dateCompleted).toISOString().slice(0, 10):null,
                    loading: false
                });
            })
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

    onUpdateCancel() {
        const { history } = this.props;
        history.push('/trips');
    }

    onSubmit(e) {
        e.preventDefault();
        const { history } = this.props;
        const { id } = this.props.match.params;

        let trip =
        {
            tripName: this.state.tripName,
            tripDescription: this.state.tripDescription,
            dateStarted: new Date(this.state.dateStarted).toISOString().slice(0, 10),
            dateCompleted: this.state.dateCompleted ? new Date(this.state.dateCompleted).toISOString().slice(0, 10) : null
        }
        console.log("Trip data - ", trip)

        axios.put("api/Trips/Update/"+id, trip)
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
                        <button type="submit" className="btn btn-success">Update</button>
                        <button onClick={this.onUpdateCancel} className="btn btn-default">Cancel</button>
                    </div>

                </form>
            </div>
        );
    }
}

export default Update;