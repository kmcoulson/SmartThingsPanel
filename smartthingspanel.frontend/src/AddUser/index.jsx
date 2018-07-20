import React from 'react';
import PropTypes from "prop-types";
import TextField from "@material-ui/core/TextField";

export class AddUser extends React.Component {
    constructor(props) {
        super(props);
    }

    render() {
        return (
            <div>
                <p>
                    Please enter details below to sign up.
                </p>
                <TextField required label={"Name"} />
                <TextField required label={"Username"} />
                <TextField required label={"Password"} type={"password"} />
            </div>
        );
    }
}

AddUser.propTypes = {

}

export default AddUser;