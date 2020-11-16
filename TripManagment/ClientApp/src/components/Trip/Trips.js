import React, { Component } from 'react';
import axios from 'axios';
import { FormGroup } from 'react-bootstrap';
import { connect } from 'react-redux';
import { getAllTrips } from '../../actions/tripActions'; 


export class Trips extends Component {
    constructor(props) {
        super(props);
        this.onTripUpdate = this.onTripUpdate.bind(this);
        this.onTripDelete = this.onTripDelete.bind(this);

        this.state = {
            trips: [],
            loading: true,
            failed: false,
            error:""
        };
    }


    componentDidMount() {
        // this.populateTripsData();
        this.props.getAllTrips();
    }

    componentDidUpdate(prevProps) {
        if (prevProps.trips.data != this.props.trips.data) {
            this.setState({ trips: this.props.trips.data})
        }
    }

    //populateTripsData() {
    //    axios.get("api/Trips/GetAll")
    //        .then(result => {
    //            const response = result.data;
    //            this.setState({ trips: response, loading: false, failed: false, error: "" });
    //        })
    //        .catch(error => {
    //            this.setState({ trips: [], loading: false, failed: true, error: "Trips could not be loaded" });
    //        });
    //}

    onTripUpdate(id) {
        const { history } = this.props;
        history.push('/Update/'+id);
    }

    onTripDelete(id) {
        const { history } = this.props;
        history.push('/Delete/' + id);
    }

    renderAllTrips(trips) {
        return (
            <table className="table table-striped">
                <thead>
                    <tr>
                        <th>Name</th>
                        <th>Description</th>
                        <th>Date Started</th>
                        <th>Date Completed</th>
                        <th>Action</th>
                    </tr>
                </thead>
                <tbody>
                    {
                        trips.map(trip => (
                            <tr key={trip.id}>
                                <td>{trip.tripName}</td>
                                <td>{trip.tripDescription}</td>
                                <td>{new Date(trip.dateStarted).toISOString().slice(0, 10)}</td>
                                <td>{trip.dateCompleted ?
                                    new Date(trip.dateCompleted).toISOString().slice(0, 10) : "-"
                                }</td>
                                <td>
                                    <div className="form-group">
                                        <button className="btn btn-success" onClick={() => this.onTripUpdate(trip.id)}>Update</button>&nbsp;
                                        <button className="btn btn-danger" onClick={() => this.onTripDelete(trip.id)}>Delete</button>
                                    </div>
                                </td>
                            </tr>
                        ))
                    }

                </tbody>
            </table>
        );
    }



    render() {
       // let content = this.state.loading ? (
       //     <p>
       //         <em>Loading...</em>
       //     </p>
       //     ) : (this.state.failed ? (
       //             <p className="text-danger">
       //                 <em>{ this.state.error }</em>
       //             </p>
       //     ) : ( 
       //             this.renderAllTrips(this.state.trips)
       //         )
       //);

        let content = this.props.trips.loading ? (
            <p>
                <em>Loading...</em>
            </p>
        ) : (
                this.state.trips.length && this.renderAllTrips(this.state.trips)
            );

        return (
            <div>
                {content}
            </div>
        );
    }
}

//allows to access data from store. Connects store as argument and use props. to get app state and get new value
const mapStateToProps = ({ trips }) => ({
    trips
});

export default connect(mapStateToProps, { getAllTrips })(Trips);