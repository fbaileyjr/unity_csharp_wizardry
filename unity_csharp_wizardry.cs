

// Example of using switch statement for powerupIDs
        // when enemies hit, choose a random number from list
        switch (_powerupID)
        {
            case var _ when _lowRateList.Contains(_powerupID):

                break;
            case var _ when _mediumRateList.Contains(_powerupID):

                break;
            case var _ when _highRateList.Contains(_powerupID):

                break;
            default:
                Debug.Log("Default value");
                break;
        }
