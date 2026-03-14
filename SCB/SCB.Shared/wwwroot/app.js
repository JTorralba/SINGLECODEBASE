async function GetTimeStamp() {
	return new Date().toLocaleTimeString();
}

async function GetLocalIPAddress() {
    return new Promise((Resolve, Reject) => {
        try {
            const RTCPC = new RTCPeerConnection({ iceServers: [] });
            const IPs = new Set();

            // create a bogus data channel
            RTCPC.createDataChannel("");

            // listen for ICE candidates
            RTCPC.onicecandidate = (Event) => {
                if (!Event.candidate) {
                    // no more candidates
                    RTCPC.close();

                    Resolve(IPs.size > 0 ? Array.from(IPs)[0] : null);

                    return;
                }

                const Candidate = Event.candidate.candidate;
                const IPMatch = Candidate.match(/([0-9]{1,3}(\.[0-9]{1,3}){3})/);

                if (IPMatch) {
                    IPs.add(IPMatch[1]);
                }
            };

            // create and set local description
            RTCPC.createOffer()
                .then((Offer) => RTCPC.setLocalDescription(Offer))
                .catch(Reject);
        }
        catch (E) {
            Reject(E);
        }
    });
};
